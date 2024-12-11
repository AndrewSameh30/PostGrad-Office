<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPublications.aspx.cs" Inherits="DBproject.StudentPublications"  MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    all publications of a student
        <br />
        <br />
        Student ID: <asp:TextBox ID="StudentIDTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="displayButton" runat="server" Text="Display" OnClick="displayButton_Click" />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
</asp:Content>
