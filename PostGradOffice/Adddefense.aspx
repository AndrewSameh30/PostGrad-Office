<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adddefense.aspx.cs" Inherits="DBproject.Adddefense" MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
     Add defense for a thesis, for nonGucian students
        <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Defense Date: <asp:TextBox ID="DefenseDateTextBox" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        Defense Location: <asp:TextBox ID="DefenseLocationTextBox" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
