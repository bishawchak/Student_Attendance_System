<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminstudentmanagement.aspx.cs" Inherits="Student_Attendance_System.adminstudentmanagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            //$('#myTable').DataTable();
            $('.table').prepend($('<thead></thead>').append($(this).find('tr:first'))).DataTable();
        });
    </script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">

            <!-- 1st column -->
            <div class="col-md-5">

                <div class="card">
                    <div class="card-body">

                        <!--row 1-->
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Student  Information</h4>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100" src="Image/user_profile.png" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <!--row 2 -->
                        <div class="row">
                            <div class="col-md-5">
                                <label>Student ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-7">
                                <label>Full Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>
                        </div>


                        <!--row 3-->
                        <div class="row">
                            <div class="col-md-6">
                                <label>Roll No.</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Roll No."></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Date of Birth</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        
                        <!--row 4-->
                        <div class="row">
                            <div class="col">
                                <label>Course Teacher</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Teacher Name"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <!--row 5-->
                        <div class="row">
                            <div class="col-md-6">
                                <label>Year & Semester</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Ex : 1-1"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Course No.</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Course No."></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <br>



                        <!--Buttons -->
                        <div class="row">
                            <div class="col-3">
                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-outline-success" runat="server" Text="Add" OnClick="Button1_Click"/>
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-outline-danger" runat="server" Text="Update" OnClick="Button3_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-outline-dark" runat="server" Text="Delete" OnClick="Button2_Click" />
                            </div>
                        </div>

                    </div>
                </div>

                <!--Link to homepage-->
                <a href="homepage.aspx"><< Back to Home</a><br>
                <br>
            </div>


            <!-- 2nd column -->
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Student List</h4>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:attendanceDBConnectionString %>" SelectCommand="SELECT [student_id], [full_name], [year_sem], [course_no] FROM [admin_student_table]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="student_id" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="student_id" HeaderText="Student ID" ReadOnly="True" SortExpression="student_id" />
                                        <asp:BoundField DataField="full_name" HeaderText="Name" SortExpression="full_name" />
                                        <asp:BoundField DataField="year_sem" HeaderText="Semester" SortExpression="year_sem" />
                                        <asp:BoundField DataField="course_no" HeaderText="Course No." SortExpression="course_no" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
