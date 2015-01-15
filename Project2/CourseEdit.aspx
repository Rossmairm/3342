<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseEdit.aspx.cs" Inherits="Project2.CourseEdit" %>

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
                <h1>Course Edit</h1>


                <br />
                 <asp:Label ID="lblType" runat="server" Text="Search by"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="ddlType" runat="server" OnSelectedIndexChanged="ddlType_SelectedIndexChanged" >
                    <asp:ListItem>CRN</asp:ListItem>
                    <asp:ListItem>DepartmentID</asp:ListItem>
                    <asp:ListItem>CourseTitle</asp:ListItem>
                    <asp:ListItem>Professor</asp:ListItem>
                </asp:DropDownList>
&nbsp;          <asp:Label ID="lblKeyword" runat="server" Text="Search"></asp:Label>
                &nbsp; 
                <asp:TextBox ID="txtKeyword" runat="server" ></asp:TextBox>

                &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                 &nbsp;<asp:Button ID="btnMain" runat="server" Text="Main Menu" OnClick="btnMain_Click" />
                <br />
                <br />
                <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvCourses_RowCancelingEdit" OnRowEditing="gvCourses_RowEditing" OnRowUpdating="gvCourses_RowUpdating" OnRowDeleting="gvCourses_RowDeleteing" style="margin-right: 0px">
                    <Columns>
                        <asp:BoundField DataField="CRN" HeaderText="CRN" ReadOnly="True" />
                        <asp:BoundField DataField="CourseTitle" HeaderText="Courses  Title" />
                        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" />
                        <asp:BoundField DataField="Section" HeaderText="Section" />
                        <asp:BoundField DataField="Professor" HeaderText="Professor" />
                        <asp:BoundField DataField="DayCode" HeaderText="Day Code" />
                        <asp:BoundField DataField="TimeCode" HeaderText="Time Code" />
                        <asp:BoundField DataField="CreditHours" HeaderText="Credit Hours" />
                        <asp:BoundField DataField="NumberofSeatsAvailable" HeaderText="Number of Seats Available" />
                        <asp:BoundField DataField="MaximumSeats" HeaderText="Maximum Seats" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:Label ID="lblDisplay" runat="server" Text="" />

                <br />

                <br />
    
                
    </div>
    </form>
</body>
</html>
