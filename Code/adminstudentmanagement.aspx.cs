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
    public partial class adminstudentmanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           GridView1.DataBind();
        }

        //search button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            getStudentByID();
        }

        //add button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                Response.Write("<script>alert('This Student ID already exists.Enter new one.');</script>");
            }
            else
            {
                addNewStudent();
            }
        }

        //update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkMemberExist())
            {
                updateStudent();
            }
            else
            {
                Response.Write("<script>alert('Student ID doesn't exist');</script>");
            }
        }

        //delete button click
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

                SqlCommand cmd = new SqlCommand("SELECT * from admin_student_table where student_id='" + TextBox1.Text.Trim() + "';", con);

                //Creating a temporary dt & storing all the data that match the input values of TextBox18 from the SQL Data Tables
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox8.Text = dt.Rows[0][2].ToString();
                    TextBox3.Text = dt.Rows[0][3].ToString();
                    TextBox4.Text = dt.Rows[0][4].ToString();
                    TextBox9.Text = dt.Rows[0][5].ToString();
                    TextBox10.Text = dt.Rows[0][6].ToString();
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


        //void clear function
        void clearForm()
        {
            TextBox1.Text="";
            TextBox2.Text="";
            TextBox8.Text="";
            TextBox3.Text="";
            TextBox4.Text="";
            TextBox9.Text="";
            TextBox10.Text="";
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

                SqlCommand cmd = new SqlCommand("DELETE from admin_student_table WHERE student_id='"+TextBox1.Text.Trim()+"'", con);       

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student ID Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }

        //void update function
        void updateStudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE admin_student_table SET full_name=@full_name,roll_no=@roll_no,dob=@dob,course_teacher=@course_teacher,year_sem=@year_sem,course_no=@course_no where student_id='" +TextBox1.Text.Trim()+"'", con);

                cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@roll_no", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@course_teacher", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@year_sem", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@course_no", TextBox10.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student Details Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }

        //void add function
        void addNewStudent()
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

                SqlCommand cmd = new SqlCommand("INSERT INTO admin_student_table(student_id,full_name,roll_no,dob,course_teacher,year_sem,course_no)" +
                    "values(@student_id,@full_name,@roll_no,@dob,@course_teacher,@year_sem,@course_no)", con);

                cmd.Parameters.AddWithValue("@student_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@full_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@roll_no", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@dob",TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@course_teacher",TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@year_sem", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@course_no", TextBox10.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Student Added to the Database');</script>");
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