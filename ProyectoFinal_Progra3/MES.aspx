<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MES.aspx.cs" Inherits="ProyectoFinal_Progra3.ReporteMes" %>
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
<asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="137px">
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
<asp:GridView ID="GridView1" runat="server" Height="198px" Width="293px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <RowStyle BackColor="White" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
</asp:Content>
