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

namespace SQLserver2016
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 电机按钮获取SQL中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnData_Click(object sender, EventArgs e)
        {
            string con, sql;
            con = "Server=.;Database=phptest;Trusted_Connection=SSPI";
            sql = "select * from [user]";
            SqlConnection MyCon = new SqlConnection(con);
            MyCon.Open();
            SqlDataAdapter MyData = new SqlDataAdapter(sql,con);
            DataSet MyDataSet = new DataSet();
            MyData.Fill(MyDataSet, "user");
            DGridView.DataSource = MyDataSet.Tables["user"];
            MyCon.Close();
        }
    }
}
