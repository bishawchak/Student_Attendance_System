using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Attendance_System
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //when nobody is logged in
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = false;   //user login
                    LinkButton4.Visible = false;   //user signup

                    LinkButton2.Visible = false;   //user profile
                    LinkButton3.Visible = false;   //user logout
                    LinkButton7.Visible = false;   //welcome user link button

                    LinkButton6.Visible = true;   //admin login
                    LinkButton9.Visible = false;   //teacher database
                    LinkButton10.Visible = false;   //student database
                    LinkButton5.Visible = false;   //student attendance
                    LinkButton8.Visible = false;   //cookie
                }
                //when teacher is logged in
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;   //user login
                    LinkButton4.Visible = false;   //user signup

                    LinkButton2.Visible = true;   //user profile
                    LinkButton3.Visible = true;   //user logout
                    LinkButton7.Text = "Welcome " + Session["username"].ToString();

                    LinkButton6.Visible = false;   //admin login
                    LinkButton9.Visible = false;   //teacher database
                    LinkButton10.Visible = true;   //student database
                    LinkButton5.Visible = true;     //student attendance
                    LinkButton8.Visible = true;   //cookie
                }
                //when admin is logged in
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;   //user login
                    LinkButton4.Visible = false;   //user signup

                    LinkButton2.Visible = false;   //user profile
                    LinkButton3.Visible = true;   //user logout
                    LinkButton7.Text = "Welcome Admin";

                    LinkButton6.Visible = false;   //admin login
                    LinkButton9.Visible = true;   //teacher database
                    LinkButton10.Visible = true;   //student database
                    LinkButton5.Visible = true;     //student attendance
                    LinkButton8.Visible = false;   //cookie
                }
            }
            catch (Exception ex)
            {

            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton6_Click(object sender,EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminteachermanagement.aspx");
        }
        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminstudentmanagement.aspx");
        }
        protected void LinkButton5_Click(object sender,EventArgs e)
        {
            Response.Redirect("studentattendance.aspx");
        }
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        //log out session
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session.Clear();


            LinkButton1.Visible = true;   //user login
            LinkButton4.Visible = true;   //user signup

            LinkButton2.Visible = false;   //user profile
            LinkButton3.Visible = false;   //user logout
            LinkButton7.Visible = false;   //welcome user link button

            LinkButton6.Visible = true;   //admin login
            LinkButton9.Visible = false;   //teacher database
            LinkButton10.Visible = false;   //student database

            Response.Redirect("homepage.aspx");
        }
    }   
}