﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ModeloDeEnlace.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Modelo de enlace</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:GridView ID="gvProfes" runat="server"
        AutoGenerateColumns="False"
        ItemType="ModeloDeEnlace.ModeloDeDatos.profesor"
        DataKeyNames="id_profesor"
        SelectMethod="ObtenerProfesores"
        UpdateMethod="ModificarProfesores"
        DeleteMethod="BorrarProfesores"
        AutoGenerateEditButton="True"
        AutoGenerateDeleteButton="True">
        <Columns>
          <asp:BoundField DataField="nombre" HeaderText="Nombre" />
          <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
        </Columns>
      </asp:GridView>
    </div>
    <br />
    <br />
    <div>
      <asp:FormView ID="FormView1" runat="server"
        ItemType="ModeloDeEnlace.ModeloDeDatos.profesor"
        DefaultMode="Insert"
        InsertMethod="InsertarProfesor">
        <InsertItemTemplate>
          Nombre:
          <asp:TextBox ID="tbNombre" runat="server"
                       Text="<%# BindItem.nombre %>" />
          Apellidos:
          <asp:TextBox ID="tbApellidos" runat="server"
                       Text="<%# BindItem.apellidos %>"/>
          <asp:Button ID="Button1" runat="server" Text="Insertar" CommandName="Insert" />
        </InsertItemTemplate>
      </asp:FormView>
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowModelStateErrors="true" />
  </form>
</body>
</html>
