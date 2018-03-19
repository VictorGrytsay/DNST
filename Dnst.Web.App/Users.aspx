<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Dnst.Web.App.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="sm1">
        </asp:ScriptManager>

        <div style="width: 100%; border: 1px solid black;">
            <div>
                <label>Name</label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Email</label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Button runat="server" ID="btnCreateUser" OnClick="OnBtnCreateUserClick" Text="Create user" EnableViewState="false" />
            </div>
            <div>
                <asp:Button runat="server" ID="btnNothin" OnClick="btnNothin_Click" Text="Do nothing" />
            </div>

            <asp:UpdatePanel runat="server" ID="ajxPanel1">
                <ContentTemplate>
                    <div>
                        <label>Name</label>
                        <asp:TextBox ID="txtName2" runat="server"></asp:TextBox>
                    </div>
                    <div style="width: 400px; height: 500px; border: 1px solid red;">
                        <asp:Label runat="server" ID="lbl1" Text=""></asp:Label>
                    </div>
                    <asp:Button runat="server" ID="btnAjx" Text="Async" OnClick="btnAjx_Click" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnAjx" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>

        </div>
        <div style="width: 100%; border: 1px solid black;">

            <%--<table>
                <thead>
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Email
                        </th>
                        <th>
                            DateCreation
                        </th>
                    </tr>
                </thead>

                <tbody>
                    
                    <asp:Repeater ID="rptUsers" runat="server">
                        <tr>
                            <td>

                            </td>
                            <td>

                            </td>
                            <td>

                            </td>
                        </tr>
                    </asp:Repeater>

                </tbody>
            </table>--%>
        </div>
    </form>
</body>
</html>
