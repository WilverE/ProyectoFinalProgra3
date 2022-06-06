<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoFinal_Progra3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Pacientes</h1>
        <p class="lead">
            NIT Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px"></asp:TextBox>
        </p>
        <p class="lead">
            Nombres Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Height="16px" OnTextChanged="TextBox6_TextChanged" Width="628px"></asp:TextBox>
        </p>
        <p class="lead">
            Apellidos Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server" Height="16px" Width="628px"></asp:TextBox>
        </p>
        <p class="lead">
            Dirección Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox12" runat="server" Height="16px" Width="626px"></asp:TextBox>
        </p>
        <p class="lead">
            Fecha de nacimiento Del Paciente&nbsp;&nbsp;
            <asp:Calendar ID="Calendar1" runat="server" Width="330px" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
            </asp:Calendar>
        </p>
        <p class="lead">
            Número telefonico Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox15" runat="server" Height="16px" Width="262px"></asp:TextBox>
        </p>
        <asp:Button ID="Button3" runat="server" Height="42px" Text="Agregar Paciente" Width="542px" OnClick="Button3_Click1" />
    </div>

    </asp:Content>
