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
    public partial class Pass : Form
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
        public Pass()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();
        DataTable dt_all = new DataTable();
       
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Pass_Load(object sender, EventArgs e)
        {
            CusInfo = pValue.Split(',');
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;

                sql = @"SELECT a.[oId],b.[rName],a.[TotalPrice],a.[OrderStatus]                   
                          FROM [Order] as a LEFT JOIN [ResAddress] as b ON (a.[rId] = b.[rId])
                         WHERE a.[ReceiverId] = '@ReceiverId'
                           AND (a.[OrderStatus] = '5' OR a.[OrderStatus] = 'X') ";

                sql = sql.Replace("@ReceiverId", CusInfo[0]);
                
                SqlDataAdapter da_ResData = new SqlDataAdapter(sql, cn);
                da_ResData.Fill(ds, "History_data");
                dt_all = ds.Tables["History_data"];
                for (int i = 0; i < dt_all.Rows.Count; i++)
                {
                    string temp = dt_all.Rows[i]["OrderStatus"].ToString();
                    switch(temp) 
                    {
                        case "5":
                            dt_all.Rows[i]["OrderStatus"] = "訂單完成";
                            break;
                        case "X":
                            dt_all.Rows[i]["OrderStatus"] = "訂單取消";
                            break;



                    }


                }
                cn.Open();
                ShowData(ds.Tables["History_data"]);

            }
        }
        private void ShowData(DataTable dt)
        {

            past_gv.DataSource = dt;

            this.past_gv.Columns["oId"].HeaderText = "訂單編號";
            this.past_gv.Columns["rName"].HeaderText = "餐廳";
            this.past_gv.Columns["TotalPrice"].HeaderText = "訂單金額";
            this.past_gv.Columns["OrderStatus"].HeaderText = "訂單狀態";
                        

            this.past_gv.Columns["oId"].Width = 100;
            this.past_gv.Columns["rName"].Width = 160;
            this.past_gv.Columns["TotalPrice"].Width = 80;
            this.past_gv.Columns["OrderStatus"].Width = 130;         
            this.past_gv.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
            
        }

       
        private void return_bt_Click(object sender, EventArgs e)
        {
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }

        private void CService_bt_Click(object sender, EventArgs e)
        {
            CService cService = new CService();
            cService.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            cService.Show();
            this.Hide();
        }
    }
}
