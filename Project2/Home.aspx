<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>Temple University</title>
    <link type="text/css" rel="stylesheet" href="http://www.temple.edu/sites/temple/files/css/css_pbm0lsQQJ7A7WCCIMgxLho6mI_kBNgznNUWmTWcnfoE.css" media="all" />
    <link type="text/css" rel="stylesheet" href="http://www.temple.edu/sites/temple/files/css/css_CR2SCSlcchF_V1JZKALtD7MrcD2v0JPHdUDwNYGkQWk.css" media="all" />
    <!--><link type="text/css" rel="stylesheet" href="http://www.temple.edu/sites/temple/files/css/css_1Z_QIcHNvbuEiRqQcII5sIX9yVOP0oslaKtXcuHG-zw.css" media="all" />
<link type="text/css" rel="stylesheet" href="http://www.temple.edu/sites/temple/files/css/css_mrSXH-5zS04n-yygwL4h0dX0sE3cmMM96Jd7pGfZbMs.css" media="screen" />
<link type="text/css" rel="stylesheet" href="http://www.temple.edu/sites/temple/files/css/css_f0JINAe-xjdiutTtKaZSZvnJAiYNzR00LfG88yGwIVQ.css" media="print" /><!-->

</head>



<body class="background">

    <style type="text/css">
        .Main {
            background-color: white;
            width: 800px;
            margin: 0 auto;
            height: 95vh;
            text-align: center;
            font-family: 'Arial Rounded MT';
        }

        .background {
            background-color: #D50020;
        }
    </style>
    <form id="form1" runat="server">
        <div class="Main">
            <h2>Temple University</h2>
            <h1>Course Registration</h1>
            <img src="http://www.temple.edu/veterans/images/hero/temple_flags.png" />
            <br />
            <asp:Button runat="server" ID="btnNew" Text="New Student" OnClick="btnNew_Click" />
            &nbsp;<asp:Button runat="server" ID="btnStudentRoster" Text="Student Roster" OnClick="btnEditStudent_Click" />
            <br />
            <br />
            <asp:Button runat="server" ID="btnReturningStudent" Text="Returning Student" OnClick="btnReturningStudent_Click" />
            <br />

            <br />
            <asp:Button runat="server" ID="btnCourse" Text="Course Add" OnClick="btnCourse_Click" />
            &nbsp;<asp:Button runat="server" ID="btnCourseEdit" Text="Course Edit" OnClick="btnCourseEdit_Click" />

            <br />

            <br />
            <br />
        </div>
    </form>
</body>
</html>
