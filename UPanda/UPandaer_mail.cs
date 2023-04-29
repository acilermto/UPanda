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
    public partial class UPandaer_mail : Form
    {
        private string pValue;
        private string pOId;
        string[] CusInfo;
        string rating;

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
        public UPandaer_mail()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (star1_rdbtn.Checked)
            {
                rating = "1";

            }
            else if (star2_rdbtn.Checked)
            {
                rating = "2";
            }
            else if (star3_rdbtn.Checked)
            {
                rating = "3";
            }
            else if (star4_rdbtn.Checked)
            {
                rating = "4";
            }
            else if (star5_rdbtn.Checked) {
                rating = "5";
            }
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = "UPDATE  [Order] SET [Rating]= @Rating WHERE [oId] =@oId  ";


                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@oId", pOId));
                cmd.Parameters.Add(new SqlParameter("@Rating", rating));
                cmd.ExecuteNonQuery();
              
            }
            MessageBox.Show("感謝您的評價!歡迎再次訂購~");
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }

        private void UPandaer_mail_Load(object sender, EventArgs e)
        {
            CusInfo = pValue.Split(',');
        }
    }
}
