<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCita.aspx.cs" Inherits="ProyectoFinal_Progra3.AddCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="Paciente a agendar:"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
        <span>NIT Del Paciente&nbsp;&nbsp; </span>
    <asp:TextBox ID="TextBox1" runat="server" style="font-size: large" Width="738px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
</p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Agregar paciente a la cita" Width="557px" />
<p class="lead">
            NIT Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px" Enabled="False"></asp:TextBox>
</p>
<p class="lead">
            Nombres Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Height="16px"  Width="628px" Enabled="False"></asp:TextBox>
</p>
<p class="lead">
            Apellidos Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server" Height="16px" Width="628px" Enabled="False"></asp:TextBox>
</p>
        <p class="lead">
            Dirección Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox12" runat="server" Height="16px" Width="626px" Enabled="False"></asp:TextBox>
        </p>
        <p class="lead">
            Número telefonico Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox15" runat="server" Height="16px" Width="561px" Enabled="False"></asp:TextBox>
        </p>
<p class="lead">
            Fecha de Nacimiento&nbsp;&nbsp;
            <asp:TextBox ID="TextBox16" runat="server" Height="16px" Width="626px" Enabled="False"></asp:TextBox>
        </p>
    <p class="lead">
            <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Datos de cita"></asp:Label>
        </p>
    <p>
        Codi<span>go de cita&nbsp; </span>
    <asp:TextBox ID="TextBox20" runat="server" style="font-size: large" Width="738px"></asp:TextBox>
</p>
    <p class="lead">
            &nbsp;</p>
<p class="lead">
            Fecha De Cita&nbsp;&nbsp;
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
        </p>
    <p class="lead">
            Hora De Inicio&nbsp;&nbsp;
            <asp:TextBox ID="TextBox18" runat="server" Height="16px" Width="626px" TextMode="Time"></asp:TextBox>
        </p>
<p class="lead">
            Hora De Fin&nbsp;&nbsp;
            <asp:TextBox ID="TextBox19" runat="server" Height="16px" Width="626px" TextMode="Time"></asp:TextBox>
        </p>
    <p class="lead">
            <asp:Button ID="Button2" runat="server" Font-Size="X-Large" Height="63px" OnClick="Button2_Click" Text="Agendar Cita " Width="635px" />
        </p>
<p class="lead">
    &nbsp;</p>
</asp:Content>
