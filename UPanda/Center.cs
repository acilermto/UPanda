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
    public partial class Center : Form
    {
        private string pValue;
        string[] CusInfo;
        string oId = "";

        public string passValue
        {
            set
            {
                pValue = value; //[mId],[RealName],[MemberType],[Gender],[phone]


            }
        }
        public Center()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;

        private void Center_Load(object sender, EventArgs e)
        {
            CusInfo = pValue.Split(',');
            

            username_lb.Text = CusInfo[1];
            if(CusInfo[3] == "M")
            {
                gender_lb.Text = "先生";
            }
            else if(CusInfo[3] == "F")
            {
                gender_lb.Text = "小姐";
            }
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = @"SELECT [oId]                  
                          FROM [Order] 
                         WHERE [ReceiverId] ='" + CusInfo[0] + "' AND NOT ([OrderStatus] ='5' OR [OrderStatus] ='X') ";

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oId = dr[0].ToString();
                }
                             
               
            }
            if(oId !="" ) {
                vieworder_btn.Visible = true;
                store_bt.Visible = false;
            
            }
        }


        private void logout_lb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void cservice_bt_Click(object sender, EventArgs e)
        {
            CService cService = new CService();
            cService.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            cService.Show();
            this.Hide();

        }

        private void store_bt_Click(object sender, EventArgs e)
        {
            ResMenu resMenu = new ResMenu();
            resMenu.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            resMenu.Show();
            this.Hide();
        }

        private void past_bt_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            pass.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            pass.Show();
            this.Hide();
        }

        private void vieworder_btn_Click(object sender, EventArgs e)
        {
            Take_Product take_Product = new Take_Product();
            take_Product.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            take_Product.passOId = oId;
            take_Product.Show();
            this.Hide();
        }
    }
}
