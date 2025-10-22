<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Student_Attendance_System.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-family: Arial">
        <table style="border:1px solid black;border-collapse: collapse;">
            <tr>
                <td colspan="2" style="border:1px solid black;border-collapse: collapse;">
                    <h1>Showing the Cookie!</h1>
                </td>
            </tr>
            <tr>
                <td style="border:1px solid black;border-collapse: collapse;">
                    <b>Name</b>
                </td>
                <td style="border:1px solid black;border-collapse: collapse;">:<asp:Label ID="lblName" runat="server">
                </asp:Label>
                </td>
            </tr>
            <tr>
                <td style="border:1px solid black;border-collapse: collapse;">
                    <b>Password</b>
                </td>
                <td style="border:1px solid black;border-collapse: collapse;">:<asp:Label ID="lblPassword" runat="server">
                </asp:Label>
                </td>
            </tr>
        </table>
    </div>


</asp:Content>
