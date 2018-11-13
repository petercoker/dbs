<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex1Week1.aspx.cs" Inherits="ExerciseWk1.Ex1Week1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>You</title>
    <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="frmWk1" runat="server">
        <div>
            <asp:Panel ID="pnlInfo" runat="server">
                <h2> Enter your information</h2>
                <p>
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name" CssClass="lable"></asp:Label> <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </p>
                 <p>
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name" CssClass="lable"></asp:Label> <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </p>
                 <p>
                    <asp:Label ID="lblEmailName" runat="server" Text="Email Name" CssClass="lable"></asp:Label> <asp:TextBox ID="txtEmailName" runat="server"></asp:TextBox>
                </p>
                 <p>
                    <asp:Label ID="lblPhoneName" runat="server" Text="Phone Name" CssClass="lable"></asp:Label> <asp:TextBox ID="txtPhoneName" runat="server"></asp:TextBox>
                </p>
                 <p>
                    <asp:Label ID="lblAddress" runat="server" Text="Address" CssClass="lable"></asp:Label> <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </p>
                 <p>
                    <asp:Label ID="lblHobbies" runat="server" Text="Choose your hobbies"></asp:Label> 
                     <asp:CheckBoxList ID="chkHobbies" runat="server">
                         <asp:ListItem>Reading</asp:ListItem>
                         <asp:ListItem>Swimming</asp:ListItem>
                         <asp:ListItem>Horse Riding</asp:ListItem>
                         <asp:ListItem>Music</asp:ListItem>
                     </asp:CheckBoxList>
                </p>
                <p>
                    <asp:Button ID="btnSubmit" runat="server" Text="Sumbit" OnClick="btnSubmit_Click" />
                </p>
            </asp:Panel>
            <h2>Your information</h2>
                 <asp:Panel ID="pnlShow" runat="server"></asp:Panel>
                 <asp:Label ID="lblShow" runat="server" Text="" CssClass="lable"></asp:Label>
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
