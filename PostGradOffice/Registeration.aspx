<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="DBproject.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div>
            Register either as a GUCian student or a NonGUCian Student<br/><br/>
            <asp:RadioButtonList ID="UserTypeRadioButtonList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="UserTypeRadioButtonList_SelectedIndexChanged" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="0">Student</asp:ListItem>
                <asp:listitem value="1">Supervisor</asp:listitem>
                <asp:listitem value="2">Examiner</asp:listitem>
            </asp:RadioButtonList>
            <br/><br/>
            First name: <asp:TextBox ID="FNameTextBox" runat="server" ></asp:TextBox><br/><br/>
            Last name: <asp:TextBox ID="LNameTextBox" runat="server"></asp:TextBox><br/><br/>
            password: <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox><br/><br/>
            faculty: <asp:TextBox ID="facultyTextBox" runat="server"></asp:TextBox><br/><br/>
            email: <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox><br/><br/>
            <table>
                <tr id="GUCianRow"  runat="server">
                    <td> 
                        <asp:CheckBox ID="GUCianCheckBox" runat="server"  Text="GUCian"/><br/><br/>

                    </td>

                </tr>
                <tr id="addressRow"  runat="server">
                    <td>adress: <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox><br/><br/>

                    </td>

                </tr>
                <tr id="isNationalRow"  runat="server">
                    <td> 
                        <asp:CheckBox ID="isNationalCheckBox" runat="server"  Text="isNational"/><br/><br/>

                    </td>

                </tr>
            </table>
           
            <br/><br/>
            
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  />
                    <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" ></asp:Label>
        </div>

         <br />
        <br />
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" NavigateUrl="~/Login.aspx">Return to login</asp:HyperLink>
        </p>

    </form>
</body>
</html>
