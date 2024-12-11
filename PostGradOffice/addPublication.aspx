<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addPublication.aspx.cs" Inherits="DBproject.addPublication" MasterPageFile="~/Student.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Add Publication
        <br />
        <br />

        Title: <asp:TextBox ID="TitleTextBox" runat="server"  ></asp:TextBox>
        <br />
        <br />

        Date: <asp:TextBox ID="DateTextBox" runat="server"  TextMode="Date" ></asp:TextBox>
        <br />
        <br />

        Host: <asp:TextBox ID="HostTextBox" runat="server"  ></asp:TextBox>

        <br />
        <br />

        Place: <asp:TextBox ID="PlaceTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="AcceptedCheckBox" runat="server"  Text="Accepted"/>
       
        <br />
        <br />
        <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click"  />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
        </div>
</asp:Content>
