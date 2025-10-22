<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="Student_Attendance_System.userlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">

                <div class="card">
                    <div class="card-body">

                        <!-- general user image -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150" src="Image/user_logo.png" />
                                </center>
                            </div>
                        </div>

                        <!-- Teacher login -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Teacher Login</h3>
                                </center>
                            </div>
                        </div>

                        <!-- horizontal rule -->
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <!-- predefined form group in bootstrap -->
                        <div class="row">
                            <div class="col">

                                <!-- enter member id -->
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="Member ID"></asp:TextBox>
                                </div>

                                <br>

                                <!-- enter password -->
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>

                                <br>

                                <!-- login button -->
                                <div class="form-group">
                                    <div class="d-grid gap-2">
                                        <asp:Button class="btn btn-outline-success btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
                                    </div>
                                </div>

                                <br>

                                <!-- sign up button -->
                                <div class="form-group">
                                    <a href="usersignup.aspx" style="text-decoration: none">
                                        <div class="d-grid gap-2">
                                            <input class="btn btn-outline-primary btn-lg" id="Button2" type="button" value="Sign Up" />
                                        </div>
                                    </a>
                                </div>

                            </div>
                        </div>



                    </div>
                </div>

                <a href="homepage.aspx"><< Back to Home</a>
                <br>
                <br>
            </div>
        </div>
    </div>

</asp:Content>
