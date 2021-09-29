using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Configuration;
using System.Web.Security;

namespace auth
{
    public partial class user_login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=BEBOPC\SQLEXPRESS01;Initial Catalog=NCWDatabase;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public bool cheackpass()
        {
            string s1 = WebConfigurationManager.ConnectionStrings["userlogin"].ConnectionString;
            con = new SqlConnection(s1);
            con.Open();
            cmd = new SqlCommand("select * from Users where uname=@uname and Pwd=@Pwd", con);
            cmd.Parameters.AddWithValue("@uname", txtun.Text);
            cmd.Parameters.AddWithValue("@Pwd", txtpass.Text);
            object obj = cmd.ExecuteScalar();

            if (obj != null)
                return true;

            else
                return false;

            con.Close();
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            if (cheackpass())
            {
                FormsAuthentication.RedirectFromLoginPage(txtun.Text, false);
            }
            else
            {
                Response.Write("Login fail!");
            }
           
        }
    }
}