<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExaminer.aspx.cs" Inherits="DBproject.AddExaminer" MasterPageFile="~/Supervisor.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    Add examiner for a defense
        <br />
        <br />
        Thesis Serial No: <asp:TextBox ID="ThesisSerialNoTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Defense Date: <asp:TextBox ID="DefenseDateTextBox" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        Examiner Name: <asp:TextBox ID="ExaminerNameTextBox" runat="server" ></asp:TextBox>
        <br />
        <br />
        Password: <asp:TextBox ID="PasswordTextBox" runat="server" ></asp:TextBox>
        <br />
        <br />
        fieldOfWork: <asp:TextBox ID="fieldOfWorkTextBox" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="NationalCheckBox" runat="server"  Text="Is National"/>
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
</asp:Content>
