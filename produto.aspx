<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="produto.aspx.cs" Inherits="Produto.produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
        .auto-style2 {
            width: 116px;
        }
        .auto-style3 {
            width: 379px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <table class="auto-style1" border="1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblId" runat="server" Text="Id:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNome" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblValor" runat="server" Text="Valor:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnInserir" runat="server" Text="Inserir" Width="74px" OnClick="btnInserir_Click" />
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="74px" OnClick="btnAlterar_Click" />
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" Width="74px" OnClick="btnPesquisar_Click" />
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Width="74px" OnClick="btnExcluir_Click" />
                </td>
            </tr>
        </table>
        
        <asp:GridView ID="grdProdutos" runat="server">
        </asp:GridView>
        
    </form>
</body>
</html>
