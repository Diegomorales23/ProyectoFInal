<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="CrearMaterias.aspx.cs" Inherits="ES.UI.CrearMaterias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="alert alert-success" visible="false"  id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
             <strong id="textoMensaje" runat="server"></strong>
        </div> 
     <div class="alert alert-danger" visible="false"  id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
             <strong id="textomensajeError" runat="server"></strong>
        </div>  
    <div class="alert alert-info" visible="false"  id="mensajeInfo" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
             <strong id="textomensajeInfo" runat="server"></strong>
        </div>      
       <div class="col-xs-6 col-sm-4 col-sm-offset-2">
           <div class="form-inline col-sm-offset-2">
        <div class="form-inline">
    <div class="form-inline">
    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
   </div>
      <div class="form-inline col-sm-offset-5">
          <br>
       <asp:Button ID="btnRegresar" Onclick="btnRegresar_Click" CssClass="btn btn-primary" runat="server" Text="Regresar" />
        <asp:Button ID="btnCrear" OnClick="btnCrear_Click" CssClass="btn btn-success" runat="server" Text="Crear" />    
        <asp:Button ID="btnLimpiar" Onclick="btnLimpiar_Click" CssClass="btn btn-danger" runat="server" Text="Limpiar" />
    </div>

</asp:Content>
