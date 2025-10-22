<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="Student_Attendance_System.userprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8 mx-auto">

                <div class="card">
                    <div class="card-body">

                        <!-- user_logo -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100" src="Image/user_profile.png" />
                                </center>
                            </div>
                        </div>

                        <!-- profile -->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Your Profile</h3>
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
                                    <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Date of Joining</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox8" runat="server" TextMode="Date"></asp:TextBox>
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
                                    <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Contact No." TextMode="Phone"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Email ID</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox13" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
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
                                    <asp:TextBox class="form-control" ID="TextBox14" runat="server" placeholder="Degree"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Course No.</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox15" runat="server" placeholder="Course No."></asp:TextBox>
                                </div>
                            </div>

                        </div>

                        <br>

                        <!-- Row 4 -->
                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox16" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
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
                        <br>

                        <!-- Row 6 -->
                        <div class="row">
                            <div class="col-md-4">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox17" runat="server" placeholder="ID" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Old Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox18" runat="server" placeholder="Password" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>New Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="TextBox19" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <br>

                        <!-- Update button -->
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <center>
                                        <asp:Button class="btn btn-lg btn-block btn-primary" ID="Button1" runat="server" Text="Update" OnClick="Button1_Click"/>
                                    </center>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>

                <br>
            </div>
        </div>
    </div>


</asp:Content>
