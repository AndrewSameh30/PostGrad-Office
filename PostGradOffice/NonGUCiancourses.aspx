<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NonGUCiancourses.aspx.cs" Inherits="DBproject.NonGUCiancourses" MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    My courses’ grades

        <br />
        <br />
        

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
   </div>
</asp:Content>
