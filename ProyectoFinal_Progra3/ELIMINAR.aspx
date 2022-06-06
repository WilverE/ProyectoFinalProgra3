<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ELIMINAR.aspx.cs" Inherits="ProyectoFinal_Progra3.DeleteCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        &nbsp;</h1>
    <h1>
        &nbsp;</h1>
    <h1>
    <br />
    </h1>
    <h1>
        &nbsp;Eliminar Cita </h1>
<p>
    Co<span>digo de cita&nbsp; </span>
    <asp:TextBox ID="TextBox1" runat="server" style="font-size: large"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Buscar Cita" Width="272px" />
</p>
<p>
    <span>Paciente </span>
    <asp:TextBox ID="TextBox2" runat="server" Enabled="False" style="font-size: large" Width="858px"></asp:TextBox>
</p>
<p>
    Fecha<span> </span>
    <asp:TextBox ID="TextBox3" runat="server" Enabled="False" style="font-size: large" Width="870px"></asp:TextBox>
</p>
<p>
    Hora
    <asp:TextBox ID="TextBox4" runat="server" Enabled="False" style="font-size: large" Width="880px"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-size: large" Text="Eliminar Cita" Width="272px" />
</p>
</asp:Content>
