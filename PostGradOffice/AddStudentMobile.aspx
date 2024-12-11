<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudentMobile.aspx.cs" Inherits="DBproject.AddStudentMobile" MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    Add student mobile number

        <br />
        <br />

        Mobile: <asp:TextBox ID="MobileTextBox" runat="server"  TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" Text="Save" OnClick="AddButton_Click" />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
