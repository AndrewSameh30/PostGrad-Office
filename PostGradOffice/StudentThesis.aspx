<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentThesis.aspx.cs" Inherits="DBproject.StudentThesis"  MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        My Thesis
        <br />
        <br />
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
   </div>
</asp:Content>