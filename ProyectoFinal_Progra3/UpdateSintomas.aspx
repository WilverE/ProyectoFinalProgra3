<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateSintomas.aspx.cs" Inherits="ProyectoFinal_Progra3.UpdateSintomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <br /></h1>
    <h1>
        &nbsp;</h1>
    <p>
        &nbsp;</p>
    <h1>
        Editor de Sintomas</h1>
    <p>
        Codigo del sintoma <span>&nbsp;</span><asp:TextBox ID="TextBox1" runat="server" style="font-size: large" Width="738px"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Buscar Sintoma" Width="272px" />
    <p class="lead">
        Codigo del sintoma&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px"></asp:TextBox>
    </p>
    <p class="lead">
        Sintoma&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Height="16px"  Width="628px"></asp:TextBox>
    </p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-size: large" Text="Modificar Sintoma" Width="275px" />
</asp:Content>
