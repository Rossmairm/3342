<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditHomes.aspx.cs" Inherits="Project3.EditHomes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Edit Homes</h1>
        <br />
        <br />
        <asp:Label ID="lblDisplay" runat="server" Font-Size="16pt" ForeColor="Red"></asp:Label>
        <br />
        <asp:GridView ID="gvHomes" runat="server" OnSelectedIndexChanged="gvHomes_SelectedIndexChanged" AutoGenerateColumns="False" OnRowCancelingEdit="gvHomes_RowCancelingEdit" OnRowDeleting="gvHomes_RowDeleteing" OnRowEditing="gvHomes_RowEditing" OnRowUpdating="gvCourses_RowUpdating">
            <Columns>
                <asp:BoundField DataField="HomeID" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="ListingPrice" HeaderText="Listing Price" />
                <asp:BoundField DataField="SquareFootage" HeaderText="Square Footage" />
                <asp:BoundField DataField="Availability" HeaderText="Availability" />
                <asp:BoundField DataField="Bedrooms" HeaderText="Bedrooms" />
                <asp:BoundField DataField="Bathrooms" HeaderText="Bathrooms" />
                <asp:BoundField DataField="Type" HeaderText="Type" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    
        <br />
        <br />
        <asp:Button ID="btnMain" runat="server" Text="Main Menu" OnClick="btnMain_Click" />
    
    </div>
    </form>
</body>
</html>
