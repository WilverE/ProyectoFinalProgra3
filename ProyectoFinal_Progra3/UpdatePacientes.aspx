<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePacientes.aspx.cs" Inherits="ProyectoFinal_Progra3.UpdatePacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <br />
        </h1>
    <h1>
        &nbsp;</h1>
    <p>
        &nbsp;</p>
    <h1>
        Editor de pacientes</h1>
    <p>
        <span>NIT Del Paciente&nbsp;&nbsp; </span>
        <asp:TextBox ID="TextBox1" runat="server" style="font-size: large" Width="738px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Buscar Paciente" Width="272px" />
    </p>
        <p class="lead">
            NIT Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="692px"></asp:TextBox>
        </p>
        <p class="lead">
            Nombres Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Height="16px"  Width="628px"></asp:TextBox>
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
            <asp:Calendar ID="Calendar1" runat="server" Width="894px"></asp:Calendar>
        </p>
        <p class="lead">
            Número telefonico Del Paciente&nbsp;&nbsp;
            <asp:TextBox ID="TextBox15" runat="server" Height="16px" Width="262px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-size: large" Text="Modificar Paciente" Width="275px" />
    </p>
</asp:Content>
