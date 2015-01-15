<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Returning.aspx.cs" Inherits="Project2.Returning" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   <head>
    
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
                <h1>Register for Classes</h1>


                <br />
                &nbsp; 
                <asp:Label ID="lblStudentID" runat="server" Text="Enter your Student ID"></asp:Label>
                &nbsp;<asp:TextBox ID="txtStudentID" runat="server" ></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="lblDeparment" runat="server" Text="Department"></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtDepartment" runat="server" ></asp:TextBox>

&nbsp;          <asp:Label ID="lblDayCode" runat="server" Text="Day Code" ></asp:Label>
                &nbsp; 
                <asp:TextBox ID="txtDayCode" runat="server" ></asp:TextBox>

                &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

                &nbsp;<br />
                <asp:Button ID="btnMain" runat="server" Text="Main Menu" OnClick="btnMain_Click" />

                <br />
                <br />
                <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:TemplateField HeaderText="Select">
                            <EditItemTemplate>
                                <asp:CheckBox ID="chkSelect" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkSelect" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
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
                    </Columns>
                </asp:GridView>
                <br />
                <asp:Label ID="lblDisplay" runat="server" Text="" />

                <br />
                <br />
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

                <br />

                <br />
    
                
    </div>
    </form>
</body>
</html>
