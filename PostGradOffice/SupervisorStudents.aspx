<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupervisorStudents.aspx.cs" Inherits="DBproject.SupervisorStudents" MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    my students’s names and years spent in the thesis
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        <br />
    </div>
</asp:Content>
