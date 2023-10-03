<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchStudent.aspx.cs" Inherits="StudentUI.SearchStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             ID: <asp:TextBox ID="tbId" runat="server"></asp:TextBox><br />
           Name: <asp:TextBox ID="tbName" runat="server"></asp:TextBox><br />
            Age: <asp:TextBox ID="tbAge" runat="server"></asp:TextBox><br />
            Class: <asp:TextBox ID="tbClass" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="Search_Click"/>
            <asp:GridView ID="gvStudent" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
