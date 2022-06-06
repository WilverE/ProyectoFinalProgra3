<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportPacientesNoPresentes.aspx.cs" Inherits="ProyectoFinal_Progra3.ReportPacientesNoPresentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Total de pacientes que no se presentaron"></asp:Label>
<asp:Button ID="Button1" runat="server" Font-Size="X-Large" Height="56px" OnClick="Button1_Click" Text="Visualizar pacientes que no se presentaron" Width="812px" />
<br />
<asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Total de pacientes"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="383px"></asp:TextBox>
<br />
<asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Listado de pacientes"></asp:Label>
<asp:GridView ID="GridView1" runat="server" Height="198px" Width="293px">
</asp:GridView>
</asp:Content>
