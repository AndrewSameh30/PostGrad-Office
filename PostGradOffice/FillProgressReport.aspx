<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillProgressReport.aspx.cs" Inherits="DBproject.FillProgressReport"MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    Fill progress report
        <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Progress Report No: <asp:TextBox ID="progressReportNoTextBox" runat="server" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        State: <asp:TextBox ID="StateTextBox" runat="server" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        Description: <asp:TextBox ID="descriptionTextBox" runat="server"  ></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="AddButton" runat="server" Text="Fill" OnClick="AddButton_Click"   />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
