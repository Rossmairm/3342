<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddHome.aspx.cs" Inherits="Project3.AddHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Add New House</h1>
        <asp:Label ID="lblDisplay" runat="server" Font-Size="16pt" ForeColor="#CC0000"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <br />
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
        <br />
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:TextBox ID="txtState" runat="server" Width="26px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        <br />
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSquareFootage" runat="server" Text="SquareFootage"></asp:Label>
        <br />
        <asp:TextBox ID="txtSquareFootage" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAvailability" runat="server" Text="Availability"></asp:Label>
        <br />
        <asp:DropDownList ID="ddAvailability" runat="server">
            <asp:ListItem>Sold</asp:ListItem>
            <asp:ListItem Value="foreclosure">Foreclosure</asp:ListItem>
            <asp:ListItem>For Sale</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblBedroom" runat="server" Text="Bedrooms"></asp:Label>
        <br />
        <asp:TextBox ID="txtBedroom" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblBathroom" runat="server" Text="Bathroom"></asp:Label>
        <br />
        <asp:TextBox ID="txtBathroom" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblType" runat="server" Text="Type"></asp:Label>
        <br />
        <asp:DropDownList ID="ddType" runat="server">
            <asp:ListItem>Single</asp:ListItem>
            <asp:ListItem>Row home</asp:ListItem>
            <asp:ListItem>Apartment</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <br />
        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" Text="Main Menu" />
    
    </div>
    </form>
</body>
</html>
