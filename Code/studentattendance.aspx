<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="studentattendance.aspx.cs" Inherits="Student_Attendance_System.studentattendance" %>

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
        <!-- 1st row
        <div class="row1">
            <center>
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
                                <div class="col_1">
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="student_id" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="student_id" HeaderText="student_id" ReadOnly="True" SortExpression="student_id" />
                                            <asp:BoundField DataField="full_name" HeaderText="full_name" SortExpression="full_name" />
                                            <asp:BoundField DataField="year_sem" HeaderText="year_sem" SortExpression="year_sem" />
                                            <asp:BoundField DataField="course_no" HeaderText="course_no" SortExpression="course_no" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </center>
        </div>
        -->
        <br />

        <!-- 2nd row-->
        <div class="row2">
            <div class="card">
                <div class="card-body">

                    <!--row 1-->
                    <div class="row">
                        <center>
                            <h4>Insert Student Attendance</h4>
                        </center>
                    </div>

                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>

                    <!--row 2 -->
                    <div class="row justify-content-center">
                        <div class="col-md-2">
                            <label>Student ID</label>
                            <div class="form-group">
                                <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary" ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <label>Full Name</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <label>Roll No.</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Roll No."></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <label>Course No.</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Course No."></asp:TextBox>
                            </div>
                        </div>

                    </div>


                    <!--row 3-->
                    <div class="row justify-content-center">
                        <div class="col-md-3">
                            <label>Attendance Date</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <label>Attendance Status</label>
                            <div class="form-group">
                                <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Present/Absent"></asp:TextBox>
                                    <asp:Button class="btn btn-outline-danger" ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                                    <asp:Button class="btn btn-outline-dark" ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <br>

        <!--3rd row-->
        <div class="row3">
            <center>
                <div class="col-md-7">
                    <div class="card">
                        <div class="card-body">

                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h4>Attendance List</h4>
                                    </center>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>

                            <div class="row">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:attendanceDBConnectionString %>" SelectCommand="SELECT [full_name], [roll_no], [course_no] ,[date] , [status] FROM [student_attendance]"></asp:SqlDataSource>
                                <div class="col_2">
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" DataKeyNames="full_name">
                                        <Columns>
                                            <asp:BoundField DataField="full_name" HeaderText="Student Name" SortExpression="full_name" ReadOnly="True" />
                                            <asp:BoundField DataField="roll_no" HeaderText="Roll No." SortExpression="roll_no" />
                                            <asp:BoundField DataField="course_no" HeaderText="Course No." SortExpression="course_no" />
                                            <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" />
                                            <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </center>
        </div>
        <hr>
        <a href="homepage.aspx"><< Back to Home</a>
        <br>
        <br>
    </div>
</asp:Content>
