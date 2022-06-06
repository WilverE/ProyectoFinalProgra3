<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HISTORIAL.aspx.cs" Inherits="ProyectoFinal_Progra3.VerHistorialMedico" %>
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
<asp:GridView ID="GridView1" runat="server" Height="207px" Width="414px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
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
