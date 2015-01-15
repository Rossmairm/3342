<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchRegister.aspx.cs" Inherits="Project3.SearchRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="22pt" Font-Bold="True">Search and Register</asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDisplay" runat="server" Font-Size="16pt" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
        <br />
        <asp:TextBox ID="txtCity" runat="server" ></asp:TextBox>
&nbsp;
        <asp:TextBox ID="txtState" runat="server" Height="16px" Width="20px"></asp:TextBox>
        <br />
        <asp:Label ID="lblMax" runat="server" Text="Maximum Price"></asp:Label>
        <br />
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSize" runat="server" Text="Min Square Footage"></asp:Label>
        <br />
        <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblType" runat="server" Text="Type"></asp:Label>
        <br />
        <asp:DropDownList ID="ddType" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Single</asp:ListItem>
            <asp:ListItem>Apartment</asp:ListItem>
            <asp:ListItem>Row Home</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnCityState" runat="server" Text="Search City State only" OnClick="btnCityState_Click" />
        <br />
        <br />

        <asp:Button ID="btnMax" runat="server" Text="Search Max" OnClick="btnMax_Click" />
&nbsp;
        <asp:Button ID="btnSize" runat="server" Text="Search Size" OnClick="btnSize_Click" />
&nbsp;
        <asp:Button ID="btnType" runat="server" Text="Search Type" OnClick="btnType_Click" />
        <br />
        <br />
    <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="ckRegister" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
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
            </Columns>
        </asp:GridView>
        <br />
        Client ID<br />
        <asp:DropDownList ID="ddClient" runat="server" DataSourceID="SqlDataSource1" DataTextField="clientId" DataValueField="clientId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FA14_3342_tuc72616ConnectionString %>" SelectCommand="SELECT [clientId] FROM [Client]"></asp:SqlDataSource>
        <br />
        <br />
        Realtor<br />
        <asp:DropDownList ID="ddRealtor" runat="server" DataSourceID="SqlDataSource2" DataTextField="RealtorId" DataValueField="RealtorId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:FA14_3342_tuc72616ConnectionString %>" SelectCommand="SELECT [RealtorId] FROM [Realtor]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" Text="Main Menu" />
    </div>
    </form>
</body>
</html>
