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
    public partial class adminteachermanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        //search button
        protected void Button1_Click(object sender, EventArgs e)
        {
            getTeacherByID();
        }

        //void getStudentbyID
        void getTeacherByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='"+TextBox1.Text.Trim()+"';", con);

                //Creating a temporary dt & storing all the data that match the input values of TextBox18 from the SQL Data Tables
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][0].ToString();
                    TextBox8.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();
                    TextBox9.Text = dt.Rows[0][4].ToString();
                    TextBox10.Text = dt.Rows[0][5].ToString();
                    TextBox6.Text = dt.Rows[0][6].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Member ID');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }


        //void clear function
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox8.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox6.Text = "";
        }

        //delete button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                deleteStudent();
            }
            else
            {
                Response.Write("<script>alert('Student ID doesn't exist');</script>");
            }
        }

        //void delete function
        void deleteStudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from member_master_table WHERE member_id='"+TextBox1.Text.Trim()+"'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Member ID Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }

        bool checkMemberExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='"+TextBox1.Text.Trim()+"';", con);

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
    }
}