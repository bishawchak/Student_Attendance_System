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
    public partial class usersignup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //sign up button click event
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                Response.Write("<script>alert('This user name already exist. Use Different User ID.');</script>");
            }
            else
            {
                signUpNewUser();
            }

        }

            //user defined method

            bool checkMemberExist()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='"+TextBox18.Text.Trim()+"';", con);

                    //Creating a temporary dt & storing all the data that match the input values of TextBox18 from the SQL Data Tables
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //Counting  total no. of rows present that matches the input value i.e (member_id)
                    //The logic is we can't same user_id/member_id as we are considering it to be the primary key.
                    //Hence if typed user name already exists we need to inform the user to use a different user name.

                    if (dt.Rows.Count >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert(' " + ex.Message + " ');</script>");
                    return false;
                }
            }


            void signUpNewUser()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // inserting into sql datatable

                    //@full_name etc are placeholder for storing the values coming from front-end.Note:You can give any name... ex @name
                    //Trim() function removes any spaces.

                    SqlCommand cmd = new SqlCommand("INSERT INTO member_master_table(full_name,doj,contact,email,qualification,course_no,full_address,member_id,password)" +
                        "values(@full_name,@doj,@contact,@email,@qualification,@course_no,@full_address,@member_id,@password)", con);

                    cmd.Parameters.AddWithValue("@full_name", TextBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@doj", TextBox9.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", TextBox13.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TextBox14.Text.Trim());
                    cmd.Parameters.AddWithValue("@qualification", TextBox15.Text.Trim());
                    cmd.Parameters.AddWithValue("@course_no", TextBox16.Text.Trim());
                    cmd.Parameters.AddWithValue("@full_address", TextBox17.Text.Trim());
                    cmd.Parameters.AddWithValue("@member_id", TextBox18.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox19.Text.Trim());



                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Sign Up Successful.Go to User Login Page to Login.');</script>");

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert(' " + ex.Message + " ');</script>");
                }
            }
    }
}