<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="InsertarCalificaciones.aspx.cs" Inherits="ES.UI.InsertarCalificaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
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

    <%-- //--%>
    <div class="form-inline">
        <div class="form-inline">
            <asp:Label ID="lbMateria" runat="server" Text="Materia"></asp:Label>
            <asp:DropDownList ID="ddlMateria" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblAlumno" runat="server" Text="Cédula"></asp:Label>
            <asp:DropDownList ID="ddlCedula" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lbl1trimestre" runat="server" Text="I Trimestre"></asp:Label>
            <asp:TextBox ID="txtTrimestre1" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lbl2trimestre" runat="server" Text="II Trimestre"></asp:Label>
            <asp:TextBox ID="txtTrimestre2" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblTrimestre3" runat="server" Text="III Trimestre"></asp:Label>
            <asp:TextBox ID="txtTrimestre3" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblNotaFinal" runat="server" Text="Calificación Final"></asp:Label>
            <%--    <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>--%>
        </div>
        <br />
         <div class="form-inline">
            <asp:Label ID="lbl1Concocatoria" runat="server" Text="Primeera convocatoria"></asp:Label>
            <asp:TextBox ID="txtConcocatoria1" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lbl2Convocatoria" runat="server" Text="Segunda convocatoria"></asp:Label>
            <asp:TextBox ID="txtConvocatoria2" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
            <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="form-inline">
            <asp:Label ID="lblIdEncargado" runat="server" Text="Id Encargado"></asp:Label>
            <asp:TextBox ID="txtEncargado" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="form-inline col-sm-offset-5">
        <asp:Button ID="btnRegresar" CssClass="btn btn-primary" OnClick="btnRegresar_Click" runat="server" Text="Regresar" />
        <asp:Button ID="btnInsertar" OnClick="btnInsertar_Click" CssClass="btn btn-success" runat="server" Text="Insertar" />
        <asp:Button ID="btnLimpiar" runat="server" CssClass="btn btn-danger" OnClick="btnLimpieza_Click" Text="Limpiar" />
    </div>

    <%--//--%>
</asp:Content>
