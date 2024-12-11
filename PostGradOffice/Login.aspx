<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DBproject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Welcome to DB project
         <br />
        <br />
        <br />
        ID should be a number, strings are not accepted.<br />
        ID: <asp:TextBox ID="IDTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Password: <asp:TextBox ID="passwordTextBox" runat="server" ></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click"   />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
    </div>
    
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" NavigateUrl="~/Registeration.aspx">Register as a new user</asp:HyperLink>
        </p>
    </form>
</body>
</html>
