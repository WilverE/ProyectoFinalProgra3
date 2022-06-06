<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="REPORTE.aspx.cs" Inherits="ProyectoFinal_Progra3.ReporteDinero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Total de dinero entre dos fechas"></asp:Label>
<br />
<asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Fecha Inicial "></asp:Label>
<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="222px" NextPrevFormat="FullMonth" Width="521px" DayNameFormat="Shortest" TitleFormat="Month">
    <DayHeaderStyle Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" BackColor="#CCCCCC" />
    <DayStyle Width="14%" />
    <NextPrevStyle Font-Size="8pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
    <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
    <TodayDayStyle BackColor="#CCCC99" />
</asp:Calendar>
<asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Fecha Final "></asp:Label>
<asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="207px" NextPrevFormat="FullMonth" Width="518px" DayNameFormat="Shortest" TitleFormat="Month">
    <DayHeaderStyle Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" BackColor="#CCCCCC" />
    <DayStyle Width="14%" />
    <NextPrevStyle Font-Size="8pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
    <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
    <TodayDayStyle BackColor="#CCCC99" />
</asp:Calendar>
<asp:Button ID="Button1" runat="server" Font-Size="X-Large" Height="56px" OnClick="Button1_Click" Text="Visualizar dinero entre esas fechas" Width="557px" />
<br />
<br />
<asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Total de dinero"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="383px" Enabled="False"></asp:TextBox>
<br />
<asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Listado de consultas"></asp:Label>
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
