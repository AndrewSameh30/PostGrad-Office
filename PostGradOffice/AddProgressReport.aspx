<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProgressReport.aspx.cs" Inherits="DBproject.AddProgressReport1" MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    Add progress report
        <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Progress Report Date: <asp:TextBox ID="progressreportDateTextBox" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        Progress Report No: <asp:TextBox ID="progressReportNoTextBox" runat="server" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
