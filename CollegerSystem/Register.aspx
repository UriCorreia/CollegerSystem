<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CollegerSystem.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> College Register</h2>

            <asp:Label Text="Name:" runat="server" />
            <asp:TextBox ID="txtName" runat="server"/>

            <br />

            <asp:Label Text="CPF:" runat="server"/>
            <asp:TextBox ID="txtCPF" runat="server"/>

            <br />

            <asp:Label Text="Sexo" runat="server"/>
            <asp:TextBox ID="txtSexo" runat="server"/>

            <br />

            <asp:Button ID="btncadastrar" runat="server" Text="Cadastrar" OnClick="btncadastrar_Click"/>

        </div>
    </form>
</body>
</html>
