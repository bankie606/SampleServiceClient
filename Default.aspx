<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AUTHOR AUTHORITY</title>
    <link rel=stylesheet href="css/StyleSheet.css"/>
</head>
<body class="mainbody">
    <form id="form1" runat="server">
    <div class="animateme">
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Press Me" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
