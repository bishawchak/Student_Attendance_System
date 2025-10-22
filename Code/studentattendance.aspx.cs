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
    public partial class studentattendance : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataBind();
        }
        //search button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            getStudentByID();
        }
        //delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                deleteStudentAttendance();
            }
            else
            {
                Response.Write("<script>alert('Invalid Student ID');</script>");
            }
        }

        //void delete function
        void deleteStudentAttendance()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from student_attendance WHERE full_name='"+TextBox2.Text.Trim()+"' AND date='"+TextBox6.Text.Trim()+ "' AND course_no='"+TextBox4.Text.Trim()+"'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Attendance Date Deleted Successfully');</script>");
                clearForm();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }

        //add button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                addStudentAttendance();
            }
            else
            {
                Response.Write("<script>alert('Invalid Student ID');</script>");
            }
        }

        //void clear function
        void clearForm()
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        //void add function
        void addStudentAttendance()
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

                SqlCommand cmd = new SqlCommand("INSERT INTO student_attendance(full_name,roll_no,course_no,date,status)" +
                    "values(@full_name,@roll_no,@course_no,@date,@status)", con);

                cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@roll_no", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@course_no", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@date", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@status", TextBox5.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Student Attendance Added to the Database');</script>");
                clearForm();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }

        //void getStudentbyID
        void getStudentByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from admin_student_table where student_id='"+TextBox1.Text.Trim()+"';", con);

                //Creating a temporary dt & storing all the data that match the input values of TextBox18 from the SQL Data Tables
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][6].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Student ID');</script>");
                }

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

                SqlCommand cmd = new SqlCommand("SELECT * from admin_student_table where student_id='"+TextBox1.Text.Trim()+"';", con);

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