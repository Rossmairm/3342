<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Project3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Main Menu</h1>
    </div>
        <asp:Button ID="btnAddHome" runat="server" Text="Add Home" OnClick="btnAdd_Click" />
        <br />
        <br />
        <asp:Button ID="btnEdit" runat="server" Text="Edit Home" OnClick="btnEdit_Click" />
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" Text="Search and Register" OnClick="btnSearch_Click" />
        <br />
        <br />
        <asp:Button ID="btnAddClient" runat="server" Text="Add Client" OnClick="btnAddClient_Click" />
        <br />
        <br />
        <asp:Button ID="btnSchedule" runat="server" Text="View Schedule" OnClick="btnSchedule_Click" />
    </form>
</body>
</html>
