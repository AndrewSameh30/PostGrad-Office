<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvaluateProgressReport.aspx.cs" Inherits="DBproject.EvaluateProgressReport" MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    Evaluate Progress Report

        <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        progress Report No: <asp:TextBox ID="progressReportNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Evaluation: <asp:TextBox ID="evaluationTextBox" runat="server"  TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" Text="Save" OnClick="AddButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
