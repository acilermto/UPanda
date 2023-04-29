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
    public partial class Product_Choose : Form
    {
        private string pValue;
        private string pRId;
        string[] CusInfo;
        string address = "";
        string ResAdd;
        string ResName;
        string Status = "";

        public string passValue
        {
            set
            {
                pValue = value; //[mId],[RealName],[MemberType],[Gender],[phone]
            }
        }
        public string passRId
        {
            set
            {
                pRId = value;
            }
        }

        public Product_Choose()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();
        DataTable dt_all = new DataTable();
        DataTable dt_Original = new DataTable();
        DataTable dt_cart = new DataTable();

        private void Product_Choose_Load(object sender, EventArgs e)
        {
            CusInfo = pValue.Split(',');
            List<string> fType = new List<string>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = $" SELECT [rAddress],[rName] FROM [ResAddress] WHERE [rId] = '{pRId}'";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ResAdd = dr[0].ToString();
                    ResName = dr[1].ToString();
                }


            }

            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;

                sql = @"SELECT a.[fId],a.[fName],a.[fDescription],a.[fPrice],a.[fType],b.[TypeText]                    
                          FROM [ResMenu] as a LEFT JOIN [Types] as b ON (a.[fType] = b.[TypeIndex])
                         WHERE b.[Type] = 2
                           AND a.[rId] = '@ResNo'";

                sql = sql.Replace("@ResNo", pRId);
                SqlDataAdapter da_ResData = new SqlDataAdapter(sql, cn);
                da_ResData.Fill(ds, "Menu");
                cn.Open();

            }

            string temp = "";
            for (int i = 0; i < ds.Tables["Menu"].Rows.Count; i++)
            {
                temp = ds.Tables["Menu"].Rows[i]["TypeText"].ToString();
                if (fType.IndexOf(temp) == -1)
                {
                    fType.Add(temp);
                }

            }
            fType_cbo.Items.Add("全部");
            for (int i = 0; i < fType.Count; i++)
            {
                fType_cbo.Items.Add(fType[i]);
            }




            dt_all = ds.Tables["Menu"];
            dt_Original = dt_all;
            ShowData(dt_Original);

            dt_cart.Columns.Add("fId", typeof(String));
            dt_cart.Columns.Add("fName", typeof(String));
            dt_cart.Columns.Add("fPrice", typeof(String));
            dt_cart.Columns.Add("fQuantity", typeof(String));
            dt_cart.Columns.Add("fTotal", typeof(String));

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = $" SELECT TOP(1) [Address] FROM [CusAddress] WHERE [mId] = '{CusInfo[0]}'";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    address = dr[0].ToString();
                }
                

            }

            realname_tb.Text = CusInfo[1];
            address_tb.Text = address;
            resName_lb.Text = ResName;
            fType_cbo.SelectedIndex = 0;

        }

        private void ShowData(DataTable dt)
        {
            
            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns["fName"].HeaderText = "餐點名稱";
            this.dataGridView1.Columns["fDescription"].HeaderText = "描述";
            this.dataGridView1.Columns["fPrice"].HeaderText = "單價";
            this.dataGridView1.Columns["fName"].ReadOnly = true;
            this.dataGridView1.Columns["fDescription"].ReadOnly = true;
            this.dataGridView1.Columns["fPrice"].ReadOnly = true;
            this.dataGridView1.Columns["fId"].Visible = false;
            this.dataGridView1.Columns["fType"].Visible = false;
            this.dataGridView1.Columns["TypeText"].Visible = false;

            if (dataGridView1.Columns.Count < 7)
            {
                DataGridViewComboBoxColumn cbo = new DataGridViewComboBoxColumn();      //index 6
                cbo.HeaderText = "數量";
                cbo.Name = "Quant2Cart";
                cbo.Items.Add("1");
                cbo.Items.Add("2");
                cbo.Items.Add("3");
                cbo.Items.Add("4");
                cbo.Items.Add("5");

                dataGridView1.Columns.Add(cbo);

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();      //index 7
                btn.HeaderText = "操作";
                btn.Name = "Add2Cart";
                btn.Text = "加入購物車";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }
            this.dataGridView1.Columns["fPrice"].Width = 40;
            this.dataGridView1.Columns[6].Width = 40;

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells["Quant2Cart"].Value = "1";
            }
            

        }

        private void ShowCart(DataTable dt_cart)//string fId,string fName,string fPrice, string fQuantity, string fTotal
        {
            int total = 0;
            dataGridView2.DataSource = dt_cart;

            dataGridView2.Columns["fName"].HeaderText = "名稱";
            dataGridView2.Columns["fPrice"].HeaderText = "單價";
            dataGridView2.Columns["fQuantity"].HeaderText = "數量";
            dataGridView2.Columns["fTotal"].HeaderText = "小計";
            dataGridView2.Columns["fName"].ReadOnly = true;
            dataGridView2.Columns["fPrice"].ReadOnly = false;
            dataGridView2.Columns["fQuantity"].ReadOnly = true;
            dataGridView2.Columns["fTotal"].ReadOnly = true;
            dataGridView2.Columns["fId"].Visible = false;


            this.dataGridView2.Columns["fPrice"].Width = 40;
            this.dataGridView2.Columns["fQuantity"].Width = 40;
            this.dataGridView2.Columns["fTotal"].Width = 40;

            for (int i = 0; i < dt_cart.Rows.Count; i++)
            {
                total += Int16.Parse(dt_cart.Rows[i]["fTotal"].ToString());
            }

            Total_lb.Text = total.ToString();

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            ResMenu resMenu = new ResMenu();
            resMenu.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            resMenu.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fId, fName, fPrice, fQuantity, fTotal;
            string Quantity_temp = "";
            bool isExist = false;
            int index = 0;
            if (e.ColumnIndex == 7 || e.ColumnIndex == 1)
            {
                //MessageBox.Show(dt_all.Rows[e.RowIndex]["fId"].ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["fId"].Value.ToString());

                //fId = dt_all.Rows[e.RowIndex]["fId"].ToString();
                fId = dataGridView1.Rows[e.RowIndex].Cells["fId"].Value.ToString();
                List<string> dr = new List<string>();
                
                for(int i = 0; i < dt_cart.Rows.Count; i++)
                {
                    dr.Add(dt_cart.Rows[i]["fId"].ToString());
                }

                if (dr.Contains(fId))
                {
                    isExist = true;
                    index = dr.IndexOf(fId);
                }
                fName = dataGridView1.Rows[e.RowIndex].Cells["fName"].Value.ToString();
                fPrice = dataGridView1.Rows[e.RowIndex].Cells["fPrice"].Value.ToString();
                //fQuantity = "1";
                
                Quantity_temp = dataGridView1.Rows[e.RowIndex].Cells["Quant2Cart"].Value.ToString();
                if(Quantity_temp == "")
                {
                    fQuantity = "1";
                }
                else
                {
                    fQuantity = Quantity_temp;
                }
                //fQuantity = dataGridView1.Rows[e.RowIndex].Cells["Quant2Cart"].Value.ToString();
                fTotal = (Int16.Parse(fPrice) * Int16.Parse(fQuantity)).ToString();
                if (isExist == true)
                {
                    fQuantity = (Int16.Parse(dt_cart.Rows[index]["fQuantity"].ToString()) + Int16.Parse(fQuantity)).ToString();
                    fTotal = (Int16.Parse(fPrice) * Int16.Parse(fQuantity)).ToString();
                    dt_cart.Rows[index]["fQuantity"] = fQuantity;
                    dt_cart.Rows[index]["fTotal"] = fTotal;

                }
                else
                {
                    DataRow row = dt_cart.NewRow();

                    row["fId"] = fId;
                    row["fName"] = fName;
                    row["fPrice"] = fPrice;
                    row["fQuantity"] = fQuantity;
                    row["fTotal"] = fTotal;

                    dt_cart.Rows.Add(row);
                }

                ShowCart(dt_cart);
            }
                
        }

        private void Oder_btn_Click(object sender, EventArgs e)
        {
            string oId, ReceiverId, DeliveryManId, rId, ResAddress, DeliveryAddress, TotalPrice, OrderStatus;
            oId = oIdAutoNumbering();
            ReceiverId = CusInfo[0];
            DeliveryManId = "U0006";        //外送員
            rId = pRId;
            ResAddress = ResAdd;
            DeliveryAddress = address_tb.Text;
            TotalPrice = Total_lb.Text;
            OrderStatus = "1";

            
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();
                    string sqlstr = @" INSERT INTO [Order]([oId],[ReceiverId],[DeliveryManId],[rId],[ResAddress],[DeliveryAddress],[TotalPrice],[OrderStatus]) 
                                         VALUES(@oId,@ReceiverId,@DeliveryManId,@rId,@ResAddress,@DeliveryAddress,@TotalPrice,@OrderStatus)";

                    SqlCommand cmd = new SqlCommand(sqlstr, cn);

                    cmd.Parameters.Add(new SqlParameter("@oId", oId));
                    cmd.Parameters.Add(new SqlParameter("@ReceiverId", ReceiverId));
                    cmd.Parameters.Add(new SqlParameter("@DeliveryManId", DeliveryManId));
                    cmd.Parameters.Add(new SqlParameter("@rId", rId));
                    cmd.Parameters.Add(new SqlParameter("@ResAddress", ResAddress));
                    cmd.Parameters.Add(new SqlParameter("@DeliveryAddress", DeliveryAddress));
                    cmd.Parameters.Add(new SqlParameter("@TotalPrice", TotalPrice));
                    cmd.Parameters.Add(new SqlParameter("@OrderStatus", OrderStatus));

                    cmd.ExecuteNonQuery();

                }

                DataTable dt_Detail = new DataTable();
                dt_Detail.Columns.Add("oId", typeof(string));
                dt_Detail.Columns.Add("oIndex", typeof(string));
                dt_Detail.Columns.Add("fId", typeof(string));
                dt_Detail.Columns.Add("oFoodName", typeof(string));
                dt_Detail.Columns.Add("oQuantity", typeof(int));
                dt_Detail.Columns.Add("oFUnitPrice", typeof(int));
                dt_Detail.Columns.Add("oFTotal", typeof(int));

                for (int i = 0; i < dt_cart.Rows.Count; i++)
                {
                    var row = dt_Detail.NewRow();
                    row["oId"] = oId;
                    row["oIndex"] = i + 1;
                    row["fId"] = dt_cart.Rows[i]["fId"].ToString();
                    row["oFoodName"] = dt_cart.Rows[i]["fName"].ToString();
                    row["oQuantity"] = Int32.Parse(dt_cart.Rows[i]["fQuantity"].ToString());
                    row["oFUnitPrice"] = Int32.Parse(dt_cart.Rows[i]["fPrice"].ToString()); ;
                    row["oFTotal"] = Int32.Parse(dt_cart.Rows[i]["fTotal"].ToString()); ;

                    dt_Detail.Rows.Add(row);
                }

                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    using (var sqlBulkCopy = new SqlBulkCopy(cn))
                    {
                        sqlBulkCopy.DestinationTableName = "dbo.OrderDetail";
                        sqlBulkCopy.WriteToServer(dt_Detail);
                    }
                }
            }
            catch
            {
                MessageBox.Show("系統忙碌中，請稍後下單");
                Status = "X";
            }

            if (Status != "X")
            {
                MessageBox.Show("下單成功!");
                Product_Check product_Check = new Product_Check();
                product_Check.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
                product_Check.passOId = oId;
                product_Check.Show();
                this.Hide();

            }
            
        }

        public string oIdAutoNumbering()
        {
            string temp = "";
            string front = "UP";
            string back, New;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = @" SELECT MAX([oId])
                                     FROM [Order]";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    temp = dr[0].ToString();
                }


            }

            if (temp == "")
            {
                back = "00001";
                New = front + back;
            }
            else
            {
                back = "";

                int ExistNum = Int32.Parse(temp.Substring(2));
                back = (ExistNum + 1).ToString();
                int len = back.Length;
                for (int i = 5; i > len; i--)
                {
                    back = "0" + back;
                }

                New = front + back;

            }

            return New;
        }

        private void fType_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = fType_cbo.Text;

            if (value == "全部")
            {
                ShowData(dt_Original);
            }
            else
            {
                var filter = from p in dt_all.AsEnumerable()  //a.[fId],a.[fName],a.[fDescription],a.[fPrice],a.[fType],b.[TypeText]
                             where p.Field<string>("TypeText") == value
                             orderby p.Field<string>("fId") ascending

                             select new
                             {
                                 fId = p.Field<string>("fId"),
                                 fName = p.Field<string>("fName"),
                                 fDescription = p.Field<string>("fDescription"),
                                 fPrice = p.Field<int>("fPrice"),
                                 fType = p.Field<string>("fType"),
                                 TypeText = p.Field<string>("TypeText")
                             };
                dataGridView1.DataSource = filter.ToList();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.dataGridView1.Rows[i].Cells["Quant2Cart"].Value = "1";
                }
            }
        }

        private void Total_lb_Click(object sender, EventArgs e)
        {

        }

        private void Currency_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
