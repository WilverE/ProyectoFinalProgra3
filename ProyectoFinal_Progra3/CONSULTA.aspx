<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CONSULTA.aspx.cs" Inherits="ProyectoFinal_Progra3.AddConsulta" %>
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
    <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="Consulta Médico"></asp:Label>
</p>
<p>
        &nbsp;</p>
<p>
    Codi<span>go de cita &nbsp; </span>
    <asp:TextBox ID="TextBox1" runat="server" style="font-size: large" Width="738px"></asp:TextBox>
</p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-size: large" Text="Agregar paciente a la consulta " Width="557px" />
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
            Fecha de Nacimiento&nbsp;&nbsp;
            <asp:TextBox ID="TextBox16" runat="server" Height="16px" Width="626px" Enabled="False"></asp:TextBox>
</p>
<p class="lead">
    <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Datos de consulta"></asp:Label>
</p>
<p>
    <span>Fecha de la consulta &nbsp; </span>
    <asp:TextBox ID="TextBox20" runat="server" style="font-size: large" Width="738px" TextMode="Date"></asp:TextBox>
</p>
<p class="lead">
            Hora De Consulta &nbsp;
    <asp:TextBox ID="TextBox18" runat="server" Height="22px" Width="744px" TextMode="Time"></asp:TextBox>
</p>
<p class="lead">
    Temperatura &nbsp;
    <asp:TextBox ID="TextBox21" runat="server" Height="22px" Width="744px"></asp:TextBox>
</p>
<p class="lead">
    Presion&nbsp;
    <asp:TextBox ID="TextBox22" runat="server" Height="22px" Width="744px"></asp:TextBox>
</p>
<p class="lead">
    Sintomas&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="729px">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Agregar sintoma a la consulta" Width="220px" />
</p>
<p class="lead">
    Diagnostico &nbsp;
    <asp:TextBox ID="TextBox24" runat="server" Height="22px" Width="744px"></asp:TextBox>
</p>
<p class="lead">
    Tratamiento &nbsp;
    <asp:TextBox ID="TextBox23" runat="server" Height="22px" Width="744px"></asp:TextBox>
</p>
<p class="lead">
    Agregar medicamento&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="729px">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Agregar medicina a la receta" Width="220px" />
</p>
<p class="lead">
    Costo de la consulta&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList4" runat="server" Height="20px" Width="729px">
        <asp:ListItem>150</asp:ListItem>
        <asp:ListItem>200</asp:ListItem>
        <asp:ListItem>250</asp:ListItem>
        <asp:ListItem>300</asp:ListItem>
        <asp:ListItem>350</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p class="lead">
    &nbsp;</p>
<p class="lead">
    <asp:Button ID="Button2" runat="server" Font-Size="X-Large" Height="63px" OnClick="Button2_Click" Text="Agregar Consulta " Width="635px" />
</p>
<p class="lead">
    &nbsp;</p>
</asp:Content>
