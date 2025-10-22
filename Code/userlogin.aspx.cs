using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Attendance_System
{
    public partial class userlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //user login
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Create the cookie object
            HttpCookie cookie = new HttpCookie("UserDetails");
            cookie["Name"] = TextBox1.Text;
            cookie["Password"] = TextBox2.Text;

            // Cookie will be persisted for 1 days
            //cookie.Expires = DateTime.Now.AddDays(1);
            cookie.Expires = DateTime.Now.AddSeconds(20);
       
            // Add the cookie to the client machine
            Response.Cookies.Add(cookie);


            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='"+TextBox1.Text.Trim()+"' AND password='"+TextBox2.Text.Trim()+"';", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Login Successful');</script>");
                        Session["username"] = dr.GetValue(7).ToString();
                        Session["fullname"] = dr.GetValue(0).ToString();
                        Session["role"] = "user";
                    }
                    Response.Redirect("userprofile.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Data.Check ID & Password Properly.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}