<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRoster.aspx.cs" Inherits="Project2.StudentRoster" %>

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

                <h1>Student Roster</h1>

                <asp:Label ID="lblStudentID" runat="server" Text="Enter Student ID"></asp:Label>
                &nbsp;<asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
                .<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                <br />
                <asp:Button ID="btnMain" runat="server" Text="Main Menu" OnClick="btnMain_Click" />

                <br />
                <br />
                <br />
                <asp:GridView ID="gvRoster" runat="server">
                </asp:GridView>

                <br />

            </div>
        </form>
    </body>
    </html>
