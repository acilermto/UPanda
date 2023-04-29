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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Start start = new Start();

            this.Visible = false;
            start.Visible = true;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            string[] mType = { "顧客", "外送員" };
            string[] gender = { "先生", "小姐" };

            for (int i = 0; i < mType.Length; i++)
            {
                mtype_ddl.Items.Add(mType[i]);
            }

            for (int i = 0; i < gender.Length; i++)
            {
                gender_ddl.Items.Add(gender[i]);
            }

            mtype_ddl.SelectedIndex = 0;
            gender_ddl.SelectedIndex = 0;

        }

        private void EnNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 8)
            {
                if ((int)e.KeyChar < 48 | (int)e.KeyChar > 122)
                {
                    e.Handled = true;
                }
            }

        }

        private void NumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 8)
            {
                if ((int)e.KeyChar < 48 | (int)e.KeyChar > 57)
                {
                    e.Handled = true;
                }
            }

        }

        private void GoRegiste_btn_Click(object sender, EventArgs e)
        {

            if (agree_cb.Checked != true)
            {
                MessageBox.Show("請先詳閱UPanda外送平台權益事項，並打勾！");
            }
            else
            {
                string mId, mType, username, password, password_confirm, realname, birthday, gender, phone;
                string isExist;

                isExist = CheckExist(username_tb.Text);

                if( Int16.Parse(isExist) != 0)
                {
                    MessageBox.Show("此帳號已被註冊！");
                }
                else
                {                  

                    mId = mIdAutoNumbering();
                    mType = "";
                    switch (mtype_ddl.SelectedIndex)
                    {
                        case 0:
                            mType = "1";
                            break;
                        case 1:
                            mType = "2";
                            break;
                    }
                    //mType = mtype_ddl.Text;
                    username = username_tb.Text;
                    password = password_tb.Text;
                    password_confirm = confirmpw_tb.Text;
                    realname = Name_tb.Text;
                    birthday = string.Format("{0}/{1}/{2}", birth_year_tb.Text, birth_month_tb.Text, birth_date_tb.Text);
                    if (gender_ddl.Text == "先生")
                    {
                        gender = "M";
                    }
                    else
                    {
                        gender = "F";
                    }
                    phone = Phone_tb.Text;

                    using (SqlConnection cn = new SqlConnection())
                    {
                        
                        cn.ConnectionString = cnstr;
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("InsertMember", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@mId", SqlDbType.Char));
                        cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar));
                        cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                        cmd.Parameters.Add(new SqlParameter("@realname", SqlDbType.NVarChar));
                        cmd.Parameters.Add(new SqlParameter("@mType", SqlDbType.Char));
                        cmd.Parameters.Add(new SqlParameter("@birthday", SqlDbType.Char));
                        cmd.Parameters.Add(new SqlParameter("@gender", SqlDbType.Char));
                        cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.Char));
                        cmd.Parameters["@mId"].Value = mId;
                        cmd.Parameters["@username"].Value = username;
                        cmd.Parameters["@password"].Value = password;
                        cmd.Parameters["@realname"].Value = realname;
                        cmd.Parameters["@mType"].Value = mType;
                        cmd.Parameters["@birthday"].Value = birthday;
                        cmd.Parameters["@gender"].Value = gender;
                        cmd.Parameters["@phone"].Value = phone;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("註冊成功！\n" + realname + "歡迎你的加入！！");

                    Center center = new Center();
                    //[mId],[RealName],[MemberType],[Gender],[phone]
                    center.passValue = mId + "," + realname + "," + mType + "," + gender + "," + phone;
                    center.Show();
                    this.Hide();

                }


            }
        }

        public string CheckExist(string username)
        {
            string flag = "";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = " SELECT COUNT(*) FROM [Member] WHERE [UserName] = '" + username + "'; ";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    flag = dr[0].ToString();
                }


            }

            return flag;
        }

        public string mIdAutoNumbering()
        {
            string temp = "";
            string front = "U";
            string back, New;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = @" SELECT MAX([mId])
                                     FROM [Member]";

                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    temp = dr[0].ToString();
                }


            }

            if (temp == "")
            {
                back = "0001";
                New = front + back;
            }
            else
            {
                back = "";

                int ExistNum = Int32.Parse(temp.Substring(1));
                back = (ExistNum + 1).ToString();
                int len = back.Length;
                for (int i = 4; i > len; i--)
                {
                    back = "0" + back;
                }

                New = front + back;

            }

            return New;
        }

        private void mtype_ddl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
