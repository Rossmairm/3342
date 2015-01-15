<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSchedule.aspx.cs" Inherits="Project3.ViewSchedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Schedule Requests</h1>
        <p>
            <asp:GridView ID="gvOutput" runat="server">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" Text="Main Menu" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
