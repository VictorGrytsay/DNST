<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Dnst.Web.App.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100%; border: 1px solid black;">
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
                <asp:Button runat="server" ID="btnCreateUser" OnClick="OnBtnCreateUserClick" Text="Create user" />
            </div>
        </div>
        <div style="width:100%; border: 1px solid black;">

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
