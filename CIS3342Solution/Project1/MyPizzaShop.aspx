<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPizzaShop.aspx.cs" Inherits="Project1.MyPizzaShop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="http://localhost:58768/maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #0000FF;
            background-image: url(http://assets.nydailynews.com/polopoly_fs/1.1761454!/img/httpImage/image.jpg_gen/derivatives/article_970/pizza-cake.jpg);
    background-size: 300px;
    background-repeat: repeat;
            }
        .gv {
            margin: 0 auto;
            width: 260px;
          
        }
        .dogs {
        background-color:white;
          width:800px;
          opacity:.8;
          margin:0 auto;
       height:95vh;
    
        }
    </style>
</head>
<body class="auto-style1">
    <div class="dogs">
    <form id="form1" runat="server">
    <div class="header">
    <h1 class="auto-style1">Pizza Pizza</h1>
         <asp:Label runat="server" ID="lblError" Text=""></asp:Label>
        <br />
       <asp:Label runat="server" ID="lblFirstName" Text="First Name   "></asp:Label>
         <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
         <br />
        <asp:TextBox runat="server" ID="txtFirstName" ></asp:TextBox>
 
        <asp:TextBox runat="server" ID="txtLastName" />
        <br />
         <asp:Label ID="lblStreet" runat="server" Text="Street"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtStreet" style="right: 20px" Width="164px"/>
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblState" runat="server" Text="State  "></asp:Label>
         <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label>
         <br />
        <asp:TextBox runat="server" ID="txtCity" Width="112px"/>
         <asp:TextBox runat="server" ID="txtState" style="margin-left: 0px;" Width="38px"></asp:TextBox>
        <asp:TextBox runat="server" ID="txtZip"  Width="58px"/>
        <br />
         <asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label>
         <br />
        <asp:TextBox runat="server" ID="txtPhone" style="right: 20px" Width="164px"/>
        <br />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="text-align: center; height: 52px; width: 76px;">
            <asp:ListItem>Delivery</asp:ListItem>
            <asp:ListItem>Pickup</asp:ListItem>
        </asp:RadioButtonList>
    <asp:GridView class="gv table" ID="gvPizzas" runat="server" AutoGenerateColumns="False" style="text-align: center" Visible="False" OnSelectedIndexChanged="gvPizzas0_SelectedIndexChanged1">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chkPizza" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="PizzaType" HeaderText="Pizza Type" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Size">
                <ItemTemplate>
                    <asp:DropDownList ID="ddlSize" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Small</asp:ListItem>
                        <asp:ListItem>Medium</asp:ListItem>
                        <asp:ListItem>Large</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:GridView class="gv table" ID="gvPizzas0" runat="server" AutoGenerateColumns="False" style="text-align: center" >
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chkSelect" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="PizzaType" HeaderText="Pizza Type" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
        
    </form>
</body>
</html>
