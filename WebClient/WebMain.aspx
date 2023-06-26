<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMain.aspx.cs" Inherits="WebClient.WebMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table style ="font-family:Arial; border:1px solid black;">
            <tr>
                <td>
                    <b>ID</b>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server">
                    </asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td>
                    <b>Name</b>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server">
                    </asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td>
                    <b>Author</b>
                </td>
                <td>
                    <asp:TextBox ID="txtAuthor" runat="server">
                    </asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td>
                    <b>Data</b>
                </td>
                <td>
                    <asp:TextBox ID="txtData" runat="server">
                    </asp:TextBox> 
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Button ID="btnGetBooks" runat="server" 
                        Text="Получить"
                        onclick="btnGetBooks_Click"/>
                </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" 
                        Text="Сохранить"
                        onclick="btnSave_Click"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID ="lblMessage" runat="server"
                        ForeColor="Green" Font-Bold="true">
                    </asp:Label>
                </td>
            </tr>
            </table>
    </form>
</body>
</html>
