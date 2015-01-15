<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabDemo.aspx.cs" Inherits="Lab1.LabDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl1" runat="server"></asp:Label>
    
    </div>
        <p>
            <asp:TextBox ID="txtName" runat="server" style="margin-top: 1px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnProcess" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 34px; top: 186px; position: absolute; height: 29px; width: 441px" Text="Button" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
