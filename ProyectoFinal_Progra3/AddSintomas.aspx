<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSintomas.aspx.cs" Inherits="ProyectoFinal_Progra3.AddSintomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>Ingreso de Sintomas</h1>
    <p class="lead">
        Codigo Sintoma&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px"></asp:TextBox>
    </p>
    <p class="lead">
        Sintoma&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Height="16px"  Width="628px"></asp:TextBox>
    </p>
    <p class="lead">
        <asp:Button ID="Button3" runat="server" Height="42px" OnClick="Button3_Click" Text="Agregar Sintoma" Width="542px" />
    </p>
</asp:Content>
