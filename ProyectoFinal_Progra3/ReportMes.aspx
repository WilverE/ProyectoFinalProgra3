﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportMes.aspx.cs" Inherits="ProyectoFinal_Progra3.ReportMes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Total de pacientes entre dos fechas"></asp:Label>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Fecha Inicial "></asp:Label>
</p>
<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
    <DayStyle BackColor="#CCCCCC" />
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
    <TodayDayStyle BackColor="#999999" ForeColor="White" />
</asp:Calendar>
<p>
    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Fecha Final "></asp:Label>
</p>
<asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
    <DayStyle BackColor="#CCCCCC" />
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
    <TodayDayStyle BackColor="#999999" ForeColor="White" />
</asp:Calendar>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" Font-Size="X-Large" Height="56px" OnClick="Button1_Click" Text="Visualizar Citas entre esas fechas" Width="557px" />
</p>
<p>
    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Total de pacientes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="383px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Listado de pacientes"></asp:Label>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" Height="198px" Width="293px">
    </asp:GridView>
</p>
</asp:Content>
