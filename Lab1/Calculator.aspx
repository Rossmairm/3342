<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Lab1.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
     
            &nbsp;        
                    
            <asp:Button ID="BtnMultiply" runat="server" style="z-index: 1; left: 31px; top: 67px; position: absolute; height: 41px; width: 40px" Text="x" OnClick="BtnMultiply_Click" />
            <asp:Button ID="BtnSubtract" runat="server" style="z-index: 1; left: 31px; top: 122px; position: absolute; height: 41px; width: 40px" Text="-" OnClick="BtnAdd_Click" />
       
                <asp:TextBox ID="TxtNumberOne" runat="server" TextMode="Number" style="z-index: 1; left: 286px; top: 52px; position: absolute" OnTextChanged="TxtOutput0_TextChanged"></asp:TextBox>
       
            <asp:Button ID="BtnDivision" runat="server" style="z-index: 1; left: 32px; top: 10px; position: absolute; height: 41px; width: 40px" Text="÷" OnClick="BtnDivision_Click" />
            <asp:Button ID="BtnAdd2" runat="server" style="z-index: 1; left: 31px; top: 168px; position: absolute; height: 41px; width: 40px" Text="+" OnClick="BtnAdd2_Click" />
         
        <p>
       
                <asp:TextBox ID="TxtNumberTwo" runat="server" textmode="Number" style="z-index: 1; left: 285px; top: 118px; position: absolute"></asp:TextBox>
       
                <asp:Label ID="LblSolution" runat="server" style="z-index: 1; left: 488px; top: 82px; position: absolute"></asp:Label>
       
            </p>
        
            <asp:Button ID="BtnClear" runat="server" style="z-index: 1; left: 91px; top: 80px; position: absolute; height: 75px; width: 46px" Text="Clear" OnClick="BtnClear_Click" />
            <p>
                <asp:Label ID="LblFirstNumber" runat="server" style="z-index: 1; left: 181px; top: 62px; position: absolute; height: 19px" Text="First Number"></asp:Label>
        </p>
        <asp:Label ID="lblSecondNumber" runat="server" style="z-index: 1; left: 173px; top: 120px; position: absolute" Text="Second Number"></asp:Label>
        
    </form>
</body>
</html>
