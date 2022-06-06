<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteMes.aspx.cs" Inherits="ProyectoFinal_Progra3.ReporteMes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Día del mes con más pacientes"></asp:Label>
<br />
<br />
<asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Escoja el mes "></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server" Height="279px" Width="627px">
    <asp:ListItem>Enero</asp:ListItem>
    <asp:ListItem>Febrero</asp:ListItem>
    <asp:ListItem>Marzo</asp:ListItem>
    <asp:ListItem>Abril</asp:ListItem>
    <asp:ListItem>Mayo</asp:ListItem>
    <asp:ListItem>Junio</asp:ListItem>
    <asp:ListItem>Julio</asp:ListItem>
    <asp:ListItem>Agosto</asp:ListItem>
    <asp:ListItem>Septiembre</asp:ListItem>
    <asp:ListItem>Octubre</asp:ListItem>
    <asp:ListItem>Noviembre</asp:ListItem>
    <asp:ListItem>Diciembre</asp:ListItem>
</asp:DropDownList>
<br />
<br />
<asp:Button ID="Button1" runat="server" Font-Size="X-Large" Height="56px" OnClick="Button1_Click" Text="Visualizar Dia del mes con más pacientes" Width="812px" />
<br />
<br />
<br />
<asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Listado de pacientes"></asp:Label>
<asp:GridView ID="GridView1" runat="server" Height="198px" Width="293px">
</asp:GridView>
</asp:Content>
