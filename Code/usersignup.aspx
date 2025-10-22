<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="Student_Attendance_System.usersignup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">

                <div class="card">
                    <div class="card-body">

                        <!-- user_logo -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100" src="Image/user_logo.png" />
                                </center>
                            </div>
                        </div>

                        <!-- Teacher login -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Member Sign Up</h3>
                                </center>
                            </div>
                        </div>

                        <!-- horizontal rule -->
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <!-- Row 1 -->
                        <div class="row">
                            <div class="col-md-6">
                                <label>Teacher Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Date of Joining</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox9" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <br>
                        <!-- Row 2 -->
                        <div class="row">
                            <div class="col-md-6">
                                <label>Contact Number</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox13" runat="server" placeholder="Contact No." TextMode="Phone"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Email ID</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox14" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <br>

                        <!-- Row 3 -->
                        <div class="row">
                            <div class="col-md-6">
                                <label>Qualification</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox15" runat="server" placeholder="Degree"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Course No.</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox16" runat="server" placeholder="Course No."></asp:TextBox>
                                </div>
                            </div>

                        </div>

                        <br>

                        <!-- Row 4 -->
                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox17" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <br>

                        <!-- Row 5 -->
                        <div class="row">
                            <center>
                                <div class="col">
                                    <span class="badge rounded-pill bg-danger">Login Credentials</span>
                                </div>
                            </center>
                        </div>

                        <!-- Row 6 -->
                        <div class="row">
                            <div class="col-md-6">
                                <label>User ID</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox18" runat="server" placeholder="User ID"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox19" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <br>

                        <!-- sign up button -->
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <a href="usersignup.aspx" style="text-decoration: none">
                                        <div class="d-grid gap-2">
                                           <!-- <input class="btn btn-outline-primary btn-lg" id="Button2" type="button" value="Sign Up"/> -->
                                            <asp:Button class="btn btn-outline-primary btn-lg" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click"/>
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
