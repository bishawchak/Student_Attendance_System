using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Attendance_System
{
    public partial class userprofile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"].ToString() == "" || Session["username"] == null)
                {
                    Response.Write("<script>alert('Session Expired.Login Again ');</script>");
                    Response.Redirect("userlogin.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Session Expired.Login Again ');</script>");
                Response.Redirect("userlogin.aspx");
            }
        }

        //update button
        protected void Button1_Click(object sender, EventArgs e)
        {
            updateMemberDetail();
            getUserData();
        }

        //void update function
        void updateMemberDetail()
        {
            string password = "";
            if(TextBox19.Text.Trim() == "")
            {
                password = TextBox18.Text.Trim();
            }
            else
            {
                password = TextBox19.Text.Trim();
            }

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE member_master_table SET full_name=@full_name,doj=@doj,contact=@contact,email=@email,qualification=@qualification,course_no=@course_no,full_address=@full_address,password=@password where member_id='"+Session["username"].ToString().Trim()+"'", con);

                cmd.Parameters.AddWithValue("@full_name", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@doj", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox13.Text.Trim());
                cmd.Parameters.AddWithValue("@qualification", TextBox14.Text.Trim());
                cmd.Parameters.AddWithValue("@course_no", TextBox15.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox16.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox19.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Member Details Updated Successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }


            //user defined function
            void getUserData()
        { 
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='"+Session["username"].ToString()+"';", con);

                //Creating a temporary dt & storing all the data that match the input values of TextBox18 from the SQL Data Tables
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox7.Text = dt.Rows[0][0].ToString();
                    TextBox8.Text = dt.Rows[0][1].ToString();
                    TextBox9.Text = dt.Rows[0][2].ToString();
                    TextBox13.Text = dt.Rows[0][3].ToString();
                    TextBox14.Text = dt.Rows[0][4].ToString();
                    TextBox15.Text = dt.Rows[0][5].ToString();
                    TextBox16.Text = dt.Rows[0][6].ToString();
                    TextBox17.Text = dt.Rows[0][7].ToString();
                    TextBox18.Text = dt.Rows[0][8].ToString();
                }
                else
                {
                    
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }
    }
}