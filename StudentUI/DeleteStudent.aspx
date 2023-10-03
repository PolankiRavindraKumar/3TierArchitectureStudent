<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudent.aspx.cs" Inherits="StudentUI.DeleteStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             ID: <asp:TextBox ID="tbId" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="Delete_Click"/>
            <asp:GridView ID="gvStudent" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
