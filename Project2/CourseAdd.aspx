<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseAdd.aspx.cs" Inherits="Project2.CourseAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

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
                <h1>Course Adding</h1>


                <br />
                 <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
                <br />

                <asp:TextBox runat="server" ID="txtTitle" />
                <br />
                <asp:Label ID="lblDepartmentID" runat="server" Text="Department ID"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDepartmentID" Width="41px"  />
                <br />
                <asp:Label ID="lblSection" runat="server" Text="Section"></asp:Label>
               <br  />
             
                <asp:TextBox runat="server" ID="txtSection" Width="66px"  />
                <br />
                 <asp:Label ID="lblProfessor" runat="server" Text="Professor"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtProfessor" ></asp:TextBox>
                <br />
                   <asp:Label ID="lblDayCode" runat="server" Text="Day Code"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtDayCode" Width="72px"  />
                <br />
                <asp:Label ID="lblPhone" runat="server" Text="Time Code"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtTimeCode" Style="right: 20px" Width="118px" />
                <br />
                 <asp:Label ID="lblCreditHours" runat="server" Text="Credit Hours"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtCreditHours" Style="right: 20px" Width="23px" />
                <br />
                <asp:Label ID="lblSeatsAvailable" runat="server" Text="Seats Available"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtSeatsAvailable" Style="right: 20px" Width="22px" />
                <br />
                <asp:Label ID="lblMaximumSeats" runat="server" Text="Maximum Seats"></asp:Label>
                <br />
                <asp:TextBox runat="server" ID="txtMaximumSeats" Style="right: 20px" Width="35px" />
                <br />

                <asp:Label ID="lblOutput" runat="server" Text="" />
                 <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Button1_Click"   />

            &nbsp;
            <asp:Button ID="btnMenu" runat="server" Text="Main Menu" OnClick="btnMenu_Click" />

            <br />
            <br />
                <br />
            </div>
        </form>
    </body>
</html>
