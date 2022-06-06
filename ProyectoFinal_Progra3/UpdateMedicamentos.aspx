<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateMedicamentos.aspx.cs" Inherits="ProyectoFinal_Progra3.UpdateMedicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
    <br /></h1>
    <h1>
        &nbsp;</h1>
    <h1>
        &nbsp;</h1>
    <h1>
        &nbsp;</h1>
    <h1>
        &nbsp;</h1>
    <h1>
        Editor de Medicamentos</h1>
<p>
    Codigo del medicamento<span>&nbsp; </span>
    <asp:TextBox ID="TextBox1" runat="server" style="font-size: large" Width="738px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Buscar Medicamento" Width="272px" />
</p>
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
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-size: large" Text="Modificar Medicamento" Width="486px" />
</p>
</asp:Content>
