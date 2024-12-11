<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Linkpublication.aspx.cs" Inherits="DBproject.Linkpublication" MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Link publication
        <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        publication No: <asp:TextBox ID="publicationNoTextBox" runat="server" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="AddButton" runat="server" Text="Link" OnClick="AddButton_Click" />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
        </div>
</asp:Content>
