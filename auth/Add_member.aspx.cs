using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace auth
{
    public partial class Add_member : System.Web.UI.Page
    {
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
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=BEBOPC\SQLEXPRESS01;Initial Catalog=LoginDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Users]
           ([ID]
           ,[uname]
           ,[Pwd]
           ,[userRole])
     VALUES
           ('"+txtUn.Text+"', '"+txtPass.Text+"', '"+txtRole.Text+"', '"+TextBox4.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            msgbox("Data Inserted Successfully!", this.Page, this);
            con.Close();
        }
    }
}