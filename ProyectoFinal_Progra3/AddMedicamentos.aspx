<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMedicamentos.aspx.cs" Inherits="ProyectoFinal_Progra3.AddMedicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>&nbsp;</h1>
    <h1>Ingreso de Medicamentos</h1>
    <p class="lead">
            Codigo Del Medicamento&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px"></asp:TextBox>
    </p>
    <p class="lead">
            Ingrediente Generico&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Height="16px"  Width="628px"></asp:TextBox>
    </p>
    <p class="lead">
            Laboratorio (Marca Comercial)&nbsp;
            <asp:TextBox ID="TextBox11" runat="server" Height="16px" Width="628px"></asp:TextBox>
    </p>
    <p class="lead">
            Enfermedad para ser tratado&nbsp;&nbsp;
            <asp:TextBox ID="TextBox12" runat="server" Height="16px" Width="626px"></asp:TextBox>
    </p>
<p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar enfermedad que trata este medicamento" Width="766px" Height="90px" />
    </p>
    <asp:Button ID="Button3" runat="server" Height="42px" OnClick="Button3_Click" Text="Agregar Medicamento" Width="542px" />
</asp:Content>
