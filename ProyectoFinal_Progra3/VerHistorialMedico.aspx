<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerHistorialMedico.aspx.cs" Inherits="ProyectoFinal_Progra3.VerHistorialMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Visualizar historial Medico"></asp:Label>
<br />
<asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Ingrese el NIT del paciente "></asp:Label>
<br />
<br />
<asp:TextBox ID="TextBox1" runat="server" Height="53px" Width="785px"></asp:TextBox>
<br />
<br />
<br />
<asp:Button ID="Button1" runat="server" Font-Size="X-Large" Height="56px" OnClick="Button1_Click" Text="Visualizar Historial" Width="812px" />
<br />
<asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Listado de pacientes"></asp:Label>
<asp:GridView ID="GridView1" runat="server" Height="198px" Width="293px">
</asp:GridView>
</asp:Content>
