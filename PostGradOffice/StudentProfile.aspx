<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentProfile.aspx.cs" Inherits="DBproject.StudentProfile" MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    My Profile
        <br />
        <br />

        First Name: <asp:TextBox ID="FirstNameTextBox" runat="server"  ></asp:TextBox>
        <br />
        <br />

        Last Name: <asp:TextBox ID="LastNameTextBox" runat="server"  ></asp:TextBox>
        <br />
        <br />

        Address: <asp:TextBox ID="AddressTextBox" runat="server"  ></asp:TextBox>

        <br />
        <br />

        Type: <asp:TextBox ID="TypeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Email: <asp:TextBox ID="EmailTextBox" runat="server" ></asp:TextBox>
        <br />
        <br />
        
       
    </div>
</asp:Content>
