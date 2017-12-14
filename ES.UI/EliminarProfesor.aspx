<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="EliminarProfesor.aspx.cs" Inherits="ES.UI.EliminarProfesor" %>
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
    <asp:Label ID="lblIdProfesor"  runat="server" Text="Id Profesor"></asp:Label>
    <asp:TextBox ID="txtIdProfesor" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="btnEliminar" runat="server" onClick="btnEliminar_Click" CssClass="btn btn-primary" Text="Eliminar" />
                 </div>

</asp:Content>
