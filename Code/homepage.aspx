<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="Student_Attendance_System.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
    <section id="hero">
        <div class="hero container">
            <div>
                <h1>Welcome, <span></span></h1>
                <h1>To The Attendance<span></span></h1>
                <h1>System<span></span></h1>
                <br>
                <h2>New Around Here?</h2>
                <a href="usersignup.aspx" type="button" class="cta">Sign Up</a>
                <br><br>
                <h2>OR</h2>
                <a href="userlogin.aspx" type="button" class="cta">Login</a>
            </div>
        </div>
    </section>

</asp:Content>
