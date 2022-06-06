<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="USUARIO.aspx.cs" Inherits="ProyectoFinal_Progra3.AddUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>&nbsp;</h1>
<h1>&nbsp;</h1>
<h1>&nbsp;</h1>
<h1>Ingreso de un nuevo usuario</h1>
<p class="lead">
    Nombre del usuario&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px"></asp:TextBox>
</p>
<p class="lead">
    Contraseña&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" runat="server" Height="16px" OnTextChanged="TextBox6_TextChanged" Width="628px" TextMode="Password"></asp:TextBox>
</p>
<p class="lead">
    Rol del usuario&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="38px" Width="685px">
        <asp:ListItem>Medico</asp:ListItem>
        <asp:ListItem>Secretaria</asp:ListItem>
    </asp:DropDownList>
</p>
<p class="lead">
    &nbsp;</p>
<asp:Button ID="Button3" runat="server" Height="42px" Text="Agregar Usuario" Width="542px" OnClick="Button3_Click1" />
</asp:Content>
