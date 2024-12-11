<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancelThesis.aspx.cs" Inherits="DBproject.CancelThesis" MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    Cancel Thesis

         <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>

