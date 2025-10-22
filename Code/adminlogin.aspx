<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="Student_Attendance_System.adminlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">

                <div class="card">
                    <div class="card-body">

                        <!-- admin user image -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150" src="Image/admin_logo.png" />
                                </center>
                            </div>
                        </div>

                        <!-- Admin login -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Admin Login</h3>
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

                                <!-- Enter User ID -->
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
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
                                <a href="homepage.aspx"'><< Back to Home</a>
                                <br>
                                <br>
                            </div>
                        </div>



                    </div>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
