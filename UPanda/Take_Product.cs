using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UPanda
{
    public partial class Take_Product : Form
    {
        private string pValue;
        private string pOId;
        string StartAdd = "900屏東縣屏東市民生東路51號"; 
        string ResAdd, DeliveryAdd;
        string[] CusInfo;
        
        public string passValue
        {
            set
            {
                pValue = value; //[mId],[RealName],[MemberType],[Gender],[phone]
            }
        }
        public string passOId
        {
            set
            {
                pOId = value;//[oId]
            }
        }
        public Take_Product()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();
        DataTable dt_all = new DataTable();
        DataTable dt_Original = new DataTable();
        DataTable dt_cart = new DataTable();
        DateTime localDate = DateTime.Now;
        

        private void Take_Product_Load(object sender, EventArgs e)
        {   
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = "UPDATE  [Order] SET [OrderStatus]= @OrderStatus, [PickUpFromRess]= @PickUpFromRess WHERE [oId] =@oId  ";
                

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@oId", pOId));
                cmd.Parameters.Add(new SqlParameter("@PickUpFromRess", "1"));                
                cmd.Parameters.Add(new SqlParameter("@OrderStatus", "2"));
                
              
                cmd.ExecuteNonQuery();


            }
            CusInfo = pValue.Split(',');
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;

                sql = @"SELECT [oIndex],[fId],[oFoodName],[oQuantity],[oFUnitPrice],[oFTotal]                     
                          FROM [OrderDetail] 
                         WHERE [OId] ='" + pOId + "' ";

                SqlDataAdapter da_OrderData = new SqlDataAdapter(sql, cn);
                da_OrderData.Fill(ds, "Details");
                cn.Open();
               
                ShowData(ds.Tables["Details"]);
            }

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = $" SELECT [ResAddress],[DeliveryAddress] FROM [Order] WHERE [oId] = '{pOId}'";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ResAdd = dr[0].ToString();
                    DeliveryAdd = dr[1].ToString();
                }
            }

            webBrowser1.Url = new Uri(GetMapUrl(StartAdd, ResAdd));
        }
        private void ShowData(DataTable dt)
        {

            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns["oIndex"].HeaderText = "項次";
            this.dataGridView1.Columns["oFoodName"].HeaderText = "餐點名稱";
            this.dataGridView1.Columns["oFUnitPrice"].HeaderText = "單價";
            this.dataGridView1.Columns["oQuantity"].HeaderText = "數量";
            this.dataGridView1.Columns["oFTotal"].HeaderText = "小計";
            this.dataGridView1.Columns["fId"].Visible = false;

            this.dataGridView1.Columns["oIndex"].Width = 40;
            this.dataGridView1.Columns["oFoodName"].Width = 120;
            this.dataGridView1.Columns["oQuantity"].Width = 40;
            this.dataGridView1.Columns["oFTotal"].Width = 50;
            this.dataGridView1.Columns["oFUnitPrice"].Width = 40;
            this.dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "外送員已取餐，餐點配送中";
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = "UPDATE  [Order] SET [OrderStatus]= @OrderStatus,  [PUFR_time] = @PUFR_time WHERE [oId] =@oId  ";


                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@oId", pOId));                
                cmd.Parameters.Add(new SqlParameter("@PUFR_time", Convert.ToDateTime(localDate)));
                cmd.Parameters.Add(new SqlParameter("@OrderStatus", "3"));
                cmd.ExecuteNonQuery();
                button1.Visible = false;

            }

            webBrowser1.Url = new Uri(GetMapUrl(ResAdd, DeliveryAdd));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "顧客已取餐";
            ConfirmOrder_btn.Visible = true;
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = "UPDATE  [Order] SET [OrderStatus]= @OrderStatus, [PickUpByCus]=@PickUpByCus ,[PUBC_time] = @PUBC_time WHERE [oId] =@oId  ";


                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@oId", pOId));
                cmd.Parameters.Add(new SqlParameter("@PickUpByCus", "1"));
                cmd.Parameters.Add(new SqlParameter("@PUBC_time", Convert.ToDateTime(localDate)));
                cmd.Parameters.Add(new SqlParameter("@OrderStatus", "4"));
                cmd.ExecuteNonQuery();
                
                button2.Visible = false;


            }

        }

        private void ConfirmOrder_btn_Click(object sender, EventArgs e)
        {
            label1.Text = "訂單完成";
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = "UPDATE  [Order] SET [OrderStatus]= @OrderStatus WHERE [oId] =@oId  ";


                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@oId", pOId));
                cmd.Parameters.Add(new SqlParameter("@OrderStatus", "5"));
                cmd.ExecuteNonQuery();



            }
            UPandaer_mail uPandaer_Mail = new UPandaer_mail();
            uPandaer_Mail.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            uPandaer_Mail.passOId = pOId;
            uPandaer_Mail.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }

        private string GetMapUrl(string From, string Destination)
        {
            string url;
            //url = $"https://www.google.com.tw/maps/dir/{From}/{Destination}/";
            url = $"https://www.google.com/maps/dir/?api=1&origin={From}&destination={Destination}&travelmode=driving";

            return url;
        }
    }
    
}
