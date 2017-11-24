<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="EditarEncargado.aspx.cs" Inherits="ES.UI.EditarEncargado" %>
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
               <div class="form-inline">
    <asp:Label ID="lblCedula"  runat="server" Text="Cédula"></asp:Label>
    <asp:TextBox ID="txtCedula" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" CssClass="btn btn-primary" Text="Buscar" />
                 </div>
       <div class="form-group" id="divMantenimiento" runat="server" visible="false">

 
    <br><br><br> 
       <div class="col-xs-6 col-sm-4 col-sm-offset-2">
           <div class="form-inline col-sm-offset-2">
        <div class="form-inline">

    <div class="form-inline">
    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

             <br /><br />
             <div class="form-inline">
    <asp:Label ID="lblApellidos"  runat="server" Text="Apellidos"></asp:Label>
    <asp:TextBox ID="txtApellidos" CssClass="form-control" runat="server"></asp:TextBox>
                 </div>
             <br /><br />
             <div class="form-inline">
    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label>
    <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                 </div>
             <br /><br />
             <div class="form-inline">
    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                 </div>
             <br /><br />
            
             <div class="form-inline">
    <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
    <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
                 </div>
             <br /><br />

             <div class="form-inline">
    <asp:Label ID="lblIdEncargado" runat="server" Text="Id Encargado"></asp:Label>
    <asp:TextBox ID="txtEncargado" CssClass="form-control" runat="server"></asp:TextBox>
             </div>
    
              </div>
       </div>
   </div>
      <div class="form-inline col-sm-offset-5">
          <br><br> <br><br><br><br><br><br> <br><br> <br><br> <br><br> <br><br><br><br><br><br> <br><br> <br><br> <br><br> <br><br> <br><br> <br><br>  <br><br>   

       <asp:Button ID="btnRegresar" Onclick="btnRegresar_Click" CssClass="btn btn-primary" runat="server" Text="Regresar" />
        <asp:Button ID="btnModifcar" onclick="btnModifcar_Click" CssClass="btn btn-warning" runat="server" Text="Editar" />    
        <asp:Button ID="btnLimpiar" Onclick="btnLimpiar_Click" CssClass="btn btn-danger" runat="server" Text="Limpiar" />
    </div>
           </div>
</asp:Content>
