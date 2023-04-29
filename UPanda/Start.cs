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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jhw\Downloads\UPanda_0112_3\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();


        private void Registe_btn_Click(object sender, EventArgs e)
        {
            
            Register register = new Register();

            this.Visible = false;
            register.Visible = true;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string flag = "";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();

                string sql = @" SELECT [PassWord] 
                                  FROM [Member] 
                                 WHERE [UserName] = @username; ";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@username", username_tb.Text));
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    flag = dr[0].ToString();
                }

            }

            if(flag == "")
            {
                MessageBox.Show("查無帳號資料！");
            }
            else
            {
                if(flag == password_tb.Text)
                {
                    string[] CusInfo = new string[5]; 
                    using (SqlConnection cn = new SqlConnection())
                    {
                        cn.ConnectionString = cnstr;
                        cn.Open();

                        string sql = @" SELECT [mId],[RealName],[MemberType],[Gender],[phone]
                                  FROM [Member] 
                                 WHERE [UserName] = @username; ";

                        SqlCommand cmd = new SqlCommand(sql, cn);

                        cmd.Parameters.Add(new SqlParameter("@username", username_tb.Text));
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            CusInfo[0] = dr[0].ToString();
                            CusInfo[1] = dr[1].ToString();
                            CusInfo[2] = dr[2].ToString();
                            CusInfo[3] = dr[3].ToString();
                            CusInfo[4] = dr[4].ToString();
                        }

                        Center center = new Center();
                        center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
                        center.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("密碼錯誤！");
                }
            }
        }
    }
}
