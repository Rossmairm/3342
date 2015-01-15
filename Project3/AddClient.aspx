<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="Project3.AddClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Add Client</h1>

        <asp:Label ID="lblDisplay" Text="" runat="server"></asp:Label>

        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" Text="Main Menu" />
        <div>
        </div>
    </form>
</body>
</html>
