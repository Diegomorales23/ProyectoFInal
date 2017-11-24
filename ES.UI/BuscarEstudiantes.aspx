<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="BuscarEstudiantes.aspx.cs" Inherits="ES.UI.BuscarEstudiantes" %>
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
    <h2>Lista de estudiantes</h2>
    <div class="table-responsive">
    <asp:GridView style="font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-size:10px;" ID="gvDatos" AutoGenerateColumns = False 
        CssClass="table table-hover" runat="server">
    <Columns>
        <asp:BoundField DataField = "IdAlumno" HeaderText = "Id Alumno" />
        <asp:BoundField DataField = "Cedula" HeaderText = "Cédula" />
        <asp:BoundField DataField = "Nombre" HeaderText = "Nombre" />
        <asp:BoundField DataField = "Apellidos" HeaderText = "Apellidos" />
        <asp:BoundField DataField = "Telefono" HeaderText = "Teléfono" /> 
        <asp:BoundField DataField = "Email" HeaderText = "Email" />      
        <asp:BoundField DataField = "Padecimientos" HeaderText = "Padecimientos" />  
        <asp:BoundField DataField = "Direcion" HeaderText = "Dirección" /> 
        <asp:BoundField DataField = "IdEncargado" HeaderText = "Id Encargado" />  
        <asp:BoundField DataField = "Graduado" HeaderText = "Graduado" />  
        <asp:BoundField DataField = "Abandono" HeaderText = "Abandono" /> 
        <asp:BoundField DataField = "AñoGraduacion" HeaderText = "Año de Graduación" />      
    </Columns>
    </asp:GridView>
     </div>
</asp:Content>
