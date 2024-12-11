<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addsupervisormobile.aspx.cs" Inherits="DBproject.Addsupervisormobile"  MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
    Add supervisor mobile number

        <br />
        <br />

        Mobile: <asp:TextBox ID="MobileTextBox" runat="server"  TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" Text="Save" OnClick="AddButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
