using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPanda
{
    public partial class ResMenu : Form
    {
        private string pValue;
        string[] CusInfo;

        public string passValue
        {
            set
            {
                pValue = value; //[mId],[RealName],[MemberType],[Gender],[phone]
            }
        }
        public ResMenu()
        {
            InitializeComponent();
        }

        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();
        DataTable dt_all = new DataTable();
        DataTable dt_Origin = new DataTable();
        DataTable dt_filted = new DataTable();

        private void ResMenu_Load(object sender, EventArgs e)
        {
            CusInfo = pValue.Split(',');
            List<string> rType = new List<string>();
            //string[] resType = { "0.全部", "1.中式", "2.西式", "3.炸物", "4.甜點", "5.飲料" };
            string[] resRating = {"不依評價排序", "從高到低", "從低到高" };

            //for (int i = 0; i < resType.Length; i++)
            //{
            //    restype_cbo.Items.Add(resType[i]);
            //}

            restype_cbo.Items.Add("全部");
            for (int i = 0; i < resRating.Length; i++)
            {
                resrating_cbo.Items.Add(resRating[i]);
            }

            //restype_cbo.SelectedIndex = 0;
            //resrating_cbo.SelectedIndex = 0;

            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;

                //sql = @"SELECT a.[rId],a.[rName],a.[rAddress],a.[rType],b.[TypeText]                  
                //          FROM [ResAddress] as a LEFT JOIN [Types] as b ON (a.[rType] = b.[TypeIndex])
                //         WHERE b.[Type] = 1
                //           AND a.[rEnable] = 1
                //      ORDER BY [rId]";

                sql = @"SELECT a.[rId],a.[rName],a.[rAddress],a.[rType],b.[TypeText], ROUND((SELECT SUM([Rating]) FROM [Order] WHERE [rId] = a.[rId] ) / (SELECT COUNT(*) FROM [Order] WHERE [rId] = a.[rId] AND [Rating] IS NOT NULL ), 1) as Rating
                          FROM [ResAddress] as a 
                     LEFT JOIN [Types] as b ON (a.[rType] = b.[TypeIndex])
                         WHERE b.[Type] = 1
                           AND a.[rEnable] = 1
                      ORDER BY a.[rId];";

                SqlDataAdapter da_ResData = new SqlDataAdapter(sql, cn);
                da_ResData.Fill(ds, "Restaurants");
                cn.Open();

            }

            dt_all = ds.Tables["Restaurants"];
            dt_Origin = dt_all;

            ShowData(dt_Origin);
                        
            string temp = "";
            for (int i = 0; i < ds.Tables["Restaurants"].Rows.Count; i++)
            {
                temp = ds.Tables["Restaurants"].Rows[i]["TypeText"].ToString();
                if (rType.IndexOf(temp) == -1)
                {
                    rType.Add(temp);
                }
                
            }

            for (int i = 0; i < rType.Count; i++)
            {
                restype_cbo.Items.Add(rType[i]);
            }

            restype_cbo.SelectedIndex = 0;
            resrating_cbo.SelectedIndex = 0;

        }

        private void ShowData(DataTable dt)
        {
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["Rating"].ToString() == "")
                {
                    dt.Rows[i]["Rating"] = 4;
                }
            }
            
            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns["rName"].HeaderText = "餐廳名稱";
            this.dataGridView1.Columns["rType"].HeaderText = "美食類型";
            this.dataGridView1.Columns["TypeText"].HeaderText = "美食類型";
            this.dataGridView1.Columns["Rating"].HeaderText = "評價";
            this.dataGridView1.Columns["rName"].ReadOnly = true;
            this.dataGridView1.Columns["rType"].ReadOnly = true;
            this.dataGridView1.Columns["TypeText"].ReadOnly = true;
            this.dataGridView1.Columns["rId"].Visible = false;
            this.dataGridView1.Columns["rAddress"].Visible = false;
            this.dataGridView1.Columns["rType"].Visible = false;

            this.dataGridView1.Columns["rName"].Width = 180;
            this.dataGridView1.Columns["Rating"].Width = 100;
            this.dataGridView1.Columns["Rating"].Width = 70;

            if (dataGridView1.Columns.Count < 7)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "點擊進入";
                btn.Name = "Enter";
                btn.Text = "進入餐廳";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6 || e.ColumnIndex == 0)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["rId"].Value.ToString());
                Product_Choose product_Choose = new Product_Choose();
                product_Choose.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
                product_Choose.passRId = dataGridView1.Rows[e.RowIndex].Cells["rId"].Value.ToString();
                product_Choose.Show();
                this.Hide();
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }

        private void restype_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = restype_cbo.Text;

            if (value == "全部")
            {
                ShowData(dt_Origin);
            }
            else
            {
                var filter = from p in dt_all.AsEnumerable()
                             where p.Field<string>("TypeText") == value
                             orderby p.Field<string>("rId") ascending

                             select new
                             {
                                 rId = p.Field<string>("rId"),
                                 rName = p.Field<string>("rName"),
                                 rAddress = p.Field<string>("rAddress"),
                                 rType = p.Field<string>("rType"),
                                 TypeText = p.Field<string>("TypeText"),
                                 Rating = p.Field<double>("Rating")
                             };
                dataGridView1.DataSource = filter.ToList();
            }
        }

        private void resrating_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = resrating_cbo.Text;

            switch (value)
            {
                case "不依評價排序":
                    ShowData(dt_Origin);
                    break;
                case "從高到低":
                    var filter = from p in dt_all.AsEnumerable()
                                 orderby p.Field<double>("Rating") descending

                                 select new
                                 {
                                     rId = p.Field<string>("rId"),
                                     rName = p.Field<string>("rName"),
                                     rAddress = p.Field<string>("rAddress"),
                                     rType = p.Field<string>("rType"),
                                     TypeText = p.Field<string>("TypeText"),
                                     Rating = p.Field<double>("Rating")
                                 };
                    dataGridView1.DataSource = filter.ToList();
                    break;
                case "從低到高":
                    var filter2 = from p in dt_all.AsEnumerable()
                                 orderby p.Field<double>("Rating") ascending

                                  select new
                                 {
                                     rId = p.Field<string>("rId"),
                                     rName = p.Field<string>("rName"),
                                     rAddress = p.Field<string>("rAddress"),
                                     rType = p.Field<string>("rType"),
                                     TypeText = p.Field<string>("TypeText"),
                                     Rating = p.Field<double>("Rating")
                                 };
                    dataGridView1.DataSource = filter2.ToList();
                    break;
            }                        
        }
    }
}
