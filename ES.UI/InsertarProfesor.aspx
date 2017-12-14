<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="InsertarProfesor.aspx.cs" Inherits="ES.UI.InsertarProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
<%--    --mensaje de error--%>
     <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textomensajeError" runat="server"></strong>
    </div>
    <div class="alert alert-info" visible="false" id="mensajeInfo" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textomensajeInfo" runat="server"></strong>
    </div>
    <%--    --mensaje de error--%>
    <%-- //--%>
    <div class="form-inline">
        <div class="form-inline">
            <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblApellidos" runat="server" Text="Apellidos"></asp:Label>
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblPadecimientos" runat="server" Text="Padecimientos"></asp:Label>
            <asp:TextBox ID="txtPadecimientos" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <%--    <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>--%>
        </div>
        <br />
         
    </div>
    <div class="form-inline col-sm-offset-5">
        <asp:Button ID="btnRegresar" CssClass="btn btn-primary" OnClick="btnRegresar_Click" runat="server" Text="Regresar" />
        <asp:Button ID="btnInsertar" OnClick="btnInsertar_Click" CssClass="btn btn-success" runat="server" Text="Insertar" />
        <asp:Button ID="btnLimpiar" runat="server" CssClass="btn btn-danger" OnClick="btnLimpiar_Click" Text="Limpiar" />
    </div>
</asp:Content>
