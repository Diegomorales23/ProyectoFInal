<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="BuscarMaterias.aspx.cs" Inherits="ES.UI.BuscarMaterias" %>
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
    <h2>Lista de Materias</h2>
    <div class="table-responsive">
    <asp:GridView style="font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-size:10px;" ID="gvDatos" AutoGenerateColumns = False 
        CssClass="table table-hover" runat="server">
    <Columns>
        <asp:BoundField DataField = "IdMateria" HeaderText = "Id Materia" />
        <asp:BoundField DataField = "Nombre" HeaderText = "Nombre" />
           
    </Columns>
    </asp:GridView>
     </div>
</asp:Content>