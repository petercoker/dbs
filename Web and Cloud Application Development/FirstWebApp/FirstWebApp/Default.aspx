<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> <%--//This base on xml--%>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlInfo" runat="server">
                <p> I am learning ASP.Net Today is <%=DateTime.Now.ToShortDateString()%>  </p>
                <asp:Label ID="lblName" runat="server" Text="Enter name: " ForeColor="Red"></asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btClick" runat="server" OnClick="btClick_Click" Text="Click" />
            </asp:Panel>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
