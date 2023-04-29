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

    public partial class CService : Form
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
        public CService()
        {
            InitializeComponent();
        }
        //string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\UPanda\0112\UPanda\UPanda\upDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Replication=True";
        string cnstr = Properties.Settings.Default.cnstr;
        DataSet ds = new DataSet();
        DataTable dt_all = new DataTable();
        private void CService_Load(object sender, EventArgs e)
        {
            CusInfo = pValue.Split(',');

            string[] problemType = { "1.外送服務問題", "2.錯誤餐點", "3.餐點品質問題", "4.付款或退款的問題", "5.其他問題" };           

            for (int i = 0; i < problemType.Length; i++)
            {
                item_cbo.Items.Add(problemType[i]);
            }

            item_cbo.SelectedIndex = 0;

            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;

                sql = @"SELECT [oId]                  
                          FROM [Order]
                         WHERE [ReceiverId] = '@ReceiverId'";

                sql = sql.Replace("@ReceiverId", CusInfo[0]);

                SqlDataAdapter da_ResData = new SqlDataAdapter(sql, cn);
                da_ResData.Fill(ds, "Orderlist");
                dt_all = ds.Tables["Orderlist"];
                for (int i = 0; i < dt_all.Rows.Count; i++)
                {
                    orderNumber_cbo.Items.Add(dt_all.Rows[i]["oId"].ToString());
                   
                    
                }
                orderNumber_cbo.SelectedIndex = 0;
                cn.Open();
              

            }
        }

        private void return_bt_Click(object sender, EventArgs e)
        {
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }

        private void send_bt_Click(object sender, EventArgs e)
        {
            string fbId,old,pType,pContent;
            fbId=fbIdAutoNumbering();
            old = orderNumber_cbo.Text;
            pType = item_cbo.Text.Substring(0, 1);
            pContent = commment_tb.Text;
            using (SqlConnection cn = new SqlConnection())
            {
                string sql;
                cn.ConnectionString = cnstr;
                cn.Open();
                sql = @"INSERT INTO [FeedBack]([fbID],[oId],[pType],[pContent]) 
                                        VALUES(@fbID, @oId, @pType, @pContent)";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@fbID", fbId));
                cmd.Parameters.Add(new SqlParameter("@oId", old));
                cmd.Parameters.Add(new SqlParameter("@pType", pType));
                cmd.Parameters.Add(new SqlParameter("@pContent", pContent));

                cmd.ExecuteNonQuery();


            }
            MessageBox.Show("已收到您的回饋，會盡快為您處理。");
            Center center = new Center();
            center.passValue = CusInfo[0] + "," + CusInfo[1] + "," + CusInfo[2] + "," + CusInfo[3] + "," + CusInfo[4];
            center.Show();
            this.Hide();
        }
        public string fbIdAutoNumbering()
        {
            string temp = "";
            string front = "FB";
            string back, New;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlstr = @" SELECT MAX([fbId])
                                     FROM [FeedBack]";

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

                int ExistNum = Int32.Parse(temp.Substring(2));
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
    }
}
