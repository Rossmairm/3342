<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewRegestration.aspx.cs" Inherits="Project2.NewRegestration" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">


<head id="Head1" runat="server">
    <title>Temple University</title>

</head>



<body class="background">

    <style type="text/css">
        .Main {
            background-color: white;
            right: 30%;
            margin: 0 auto;
            height: 95vh;
            text-align: center;
            font-family: "Bebas",Verdana,Tahoma,"DejaVu Sans",sans-serif;
            color: #9e1b34;
            font-weight: normal;
            -webkit-font-smoothing: antialiased;
        }

        .background {
            background-color: #D50020;
        }
    </style>
    <form id="form1" runat="server">
        <div class="Main">

            <h1>New Student Regestration</h1>

            <br /> 
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                <br />
           
                <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>

                <asp:TextBox runat="server" ID="txtLastName" />
                <br />
                <asp:Label ID="lblStreet" runat="server" Text="Street"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtStreet" Style="right: 20px" Width="164px" />
                <br />
                <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblState" runat="server" Text="State  "></asp:Label>
                <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtCity" Width="112px" />
                <asp:TextBox runat="server" ID="txtState" Style="margin-left: 0px;" Width="38px"></asp:TextBox>
                <asp:TextBox runat="server" ID="txtZip" Width="58px" />
                <br />
                <asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtPhone" Style="right: 20px" Width="164px" />
                <br />
                <br />

            <asp:Label ID="lblOutput" runat="server" Text="" />
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Button1_Click"   />

            &nbsp;
            <asp:Button ID="btnMenu" runat="server" Text="Back to Menu " OnClick="btnMenu_Click" />


            <br />
            <br />


        </div>
    </form>
</body>
</html>
