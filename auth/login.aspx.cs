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
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=BEBOPC\SQLEXPRESS01;Initial Catalog=NCWDatabase;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void msgbox(string ex, Page pg, object ob)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = ob.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
        //public bool cheackpass()
        //{
            

        //    //string s1 = WebConfigurationManager.ConnectionStrings["userlogin"].ConnectionString;
        //    //con = new SqlConnection(s1);
        //    //con.Open();
        //    //cmd = new SqlCommand("select * from Users where uname=@uname and Pwd=@Pwd", con);
        //    //cmd.Parameters.AddWithValue("@uname", Login1.UserName.ToString());
        //    //cmd.Parameters.AddWithValue("@Pwd", Login1.Password.ToString());
        //    //object obj = cmd.ExecuteScalar();

        //    //if (obj != null)
        //    //    return true;

        //    //else
        //    //    return false;

        //    //con.Close();
        //}

        protected void btnLog_Click(object sender, EventArgs e)
        {
            
        }

       

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["userlogin"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SprUserCheak4";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlParameter p1 = new SqlParameter("@login", SqlDbType.VarChar, 50);
            SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar, 50);
            SqlParameter p3 = new SqlParameter("@role", SqlDbType.VarChar, 50);

            p1.Value = Login1.UserName.ToString();
            p2.Value = Login1.Password.ToString();

            p3.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.ExecuteNonQuery();

            if ((p3.Value != DBNull.Value))
            {
                Session.Add("role", p3.Value);
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName.ToString(), false);
                if (p3.Value.ToString() == "user")
                {
                    Response.Redirect("~/user/user.aspx");
                }
            }
            else
            {
                msgbox("login failed!", this.Page, this);
            }
            con.Close();
            //SqlCommand cmd = new SqlCommand("SprUserCheak2", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@login", Login1.UserName.ToString());
            //cmd.Parameters.AddWithValue("@password", Login1.Password.ToString());
            //int result = (Int32)cmd.ExecuteScalar();
            //if (result == 1)
            //{
            //    msgbox("login Success!", this.Page, this);
            //    FormsAuthentication.RedirectFromLoginPage(Login1.UserName.ToString(), false);
            //    if (Login1.UserName.ToString() == "user3")
            //    {
            //       Response.Redirect("~/user/user.aspx");
                    
            //    }
            //}
            //else
            //{
            //    msgbox("login failed!", this.Page, this);

            //}
            //con.Close();
            //---------------------------------------------------------------------------------
            //if (cheackpass())
            //{
            //    FormsAuthentication.RedirectFromLoginPage(Login1.UserName.ToString(), false);
            //    if (Login1.UserName.ToString() == "user3")
            //    {
            //        Response.Redirect("~/user/user.aspx");
                    
            //    }
            //}
            //else
            //{
   
            //    msgbox("Wrong Username or password!", this.Page, this);
            //}
 
       }
    }
}