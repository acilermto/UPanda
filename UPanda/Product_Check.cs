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
    public partial class Product_Check : Form
    {
        private string pValue;
        private string pOId;
        string[] CusInfo;        
        string name = "";
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
                pOId = value;
            }
        }
        public Product_Check()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();
        DataTable dt_all = new DataTable();
        DataTable dt_Original = new DataTable();
        DataTable dt_cart = new DataTable();
        string address = "";
        string total = "";
        private void Product_Check_Load(object sender, EventArgs e)
        {   
            CusInfo = pValue.Split(',');
          
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = $" SELECT [DeliveryAddress],[TotalPrice] FROM [Order] WHERE [oId]='" + pOId + "' ";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    address = dr[0].ToString();
                    total = dr[1].ToString();
                }


            }

            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                
                sql = @"SELECT [oIndex],[fId],[oFoodName],[oQuantity],[oFUnitPrice],[oFTotal]                     
                          FROM [OrderDetail] 
                         WHERE [oId] ='"+pOId+"' ";

                SqlDataAdapter da_OrderData = new SqlDataAdapter(sql, cn);
                da_OrderData.Fill(ds, "Details");
                cn.Open();
                ShowData(ds.Tables["Details"]);
            }
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
            this.dataGridView1.Columns["oFoodName"].Width = 180;
            this.dataGridView1.Columns["oQuantity"].Width = 60;
            this.dataGridView1.Columns["oFUnitPrice"].Width = 50;
            this.dataGridView1.Columns["oFTotal"].Width = 100;
            this.dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
            name = CusInfo[1];
            realname_tb.Text = name;
            total_lb.Text = total;
            address_tb.Text = address;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Take_Product take_Product = new Take_Product();
            take_Product.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            take_Product.passOId = pOId;
            take_Product.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void total_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
