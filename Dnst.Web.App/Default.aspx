<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dnst.Web.App.Default" %>

<%@ Register Src="~/UserControls/Header.ascx" TagName="Header" TagPrefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc:Header ID="header" runat="server" />

        <div>

            <div>
                <asp:ListBox runat="server" ID="listItems"></asp:ListBox>
            </div>

            <asp:Panel runat="server" ID="pnlButtons">
                <asp:Button ID="btnAction1" runat="server" Text="Click Me" OnClick="OnBtnAction1Click" />
            </asp:Panel>

        </div>
        <div>
            <a href="Users.aspx">Users</a>
        </div>
    </form>
</body>
</html>
