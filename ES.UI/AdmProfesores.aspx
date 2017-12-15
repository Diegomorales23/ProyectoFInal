<%@ Page Title="Adm. Profesores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmProfesores.aspx.cs" Inherits="ES.UI.AdmProfesores" %>

<asp:Content ID="Menu" ContentPlaceHolderID="Menu" runat="server">
    <div class="sidebar" data-background-color="brown" data-active-color="danger">
        <div class="logo">
            <a href="Index.aspx" class="simple-text logo-normal">
                <img class="img-responsive logo-normal" src="images/logo.png" style="height: 100px; margin-left: auto; margin-right: auto;" />
            </a>
        </div><!-- end logo -->

        <div class="sidebar-wrapper">
            <div class="user">
                <div class="info">
                    <div class="photo">
                        <img src="images/profile.png" />
                    </div><!-- end photo -->

                    <a data-toggle="collapse" href="#users" class="collapsed">
                        <span>Perfil
                            <b class="caret"></b>
                        </span>
                    </a>
                    <div class="clearfix"></div>
                    <div class="collapse" id="users">
                        <ul class="nav">
                            <li>
                                <a href="MyProfile.aspx">
                                    <span class="sidebar-mini fa fa-user custom_01"></span>
                                    <span class="sidebar-normal">Mi Perfil</span>
                                </a>
                            </li>
                            <li>
                                <a href="UsersConfig.aspx">
                                    <span class="sidebar-mini fa fa-group custom_01"></span>
                                    <span class="sidebar-normal">Adm. Usuarios</span>
                                </a>
                            </li>
                        </ul>
                    </div><!-- end collapse -->
                </div><!-- end info -->
            </div><!-- end user -->
    
            <ul class="nav">
                <li>
                    <a href="Index.aspx">
                        <i class="fa fa-line-chart"></i>
                        <p>DASHBOARD</p>
                    </a>
                </li>
                <li>
                    <a href="AdmEstudiantes.aspx">
                        <i class="fa fa-sliders"></i>
                        <p>Adm Estudiantes</p>
                    </a>
                </li>
                <li class="active">
                    <a href="AdmProfesores.aspx">
                        <i class="fa fa-sliders"></i>
                        <p>Adm Profesores</p>
                    </a>
                </li>
                <li>
                    <a href="Herramientas.aspx">
                        <i class="fa fa-wrench"></i>
                        <p>Herramientas</p>
                    </a>
                </li>
            </ul>
        </div><!-- end sidebar-wrapper -->
    </div><!-- end sidebar --> 
</asp:Content>

<asp:Content ID="Head" ContentPlaceHolderID="Head" runat="server">
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-minimize">
                <button id="minimizeSidebar" class="btn btn-fill btn-icon"><i class="fa fa-bars"></i></button>
            </div><!-- end navbar-minimize -->

            <div class="navbar-header">
                <button type="button" class="navbar-toggle">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar bar1"></span>
                    <span class="icon-bar bar2"></span>
                    <span class="icon-bar bar3"></span>
                </button>
                <a class="navbar-brand" href="#">Administración de Profesores</a>
            </div><!-- end navbar-header -->

            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown">
                        <a href="#notifications" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="fa fa-sign-out fa fa-2x"></i>
                            <p class="hidden-md hidden-lg"><b class="caret"></b></p>
                        </a>
                        <ul class="dropdown-menu">
                            <li><a href="Login.aspx">Cerrar Sesión</a></li>
                        </ul>
                    </li>
                </ul>
            </div><!-- end collapse navbar-collapse -->
        </div><!-- end container-fluid -->
    </nav><!-- end container-fluid -->
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Administración de Profesores</h4>
                <p class="category">
                    Seleccione el profesor que desea administrar o bien ingrese uno nuevo
                </p>
                <br />
                <button type="button" class="btn btnCreateStudent" data-toggle="modal" data-target="#Insert">Ingresar profesor</button>
            </div><!-- end card-header -->

            <div class="card-content">
                <table id="bootstrap-table" class="table">
                    <thead>
                        <th data-field="Id" class="text-center">Número de cédula</th>
                        <th data-field="Nombre" class="text-center">Nombre</th>
                        <th data-field="Seccion" class="text-center">Email</th>
                        <th data-field="Telefono" class="text-center">Teléfono</th>
                        <th data-field="actions" class="td-actions text-center" data-events="operateEvents" data-formatter="operateFormatter">Acciones</th>
                    </thead>
                    <tbody>
                        <% MostrarProfesores(); %>
                    </tbody>
                </table>
            </div><!-- end card-content -->
        </div><!-- end card -->
    </div><!-- end col-md-12 -->

    <div class="modal fade in" id="Insert" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Ingresar profesor</h4>
                </div><!-- end modal-header -->
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control required" title="Número de Cédula" title="Introduzca el número de cédula del profesor" id="I_txtCedula" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control required" title="Introduzca el nombre del profesor" id="I_txtNombre" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control required" title="Introduzca los apellidos del profesor" id="I_txtApellidos" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Número de teléfono</label>
                                    <input class="form-control required" title="Introduzca el número de teléfono del profesor" id="I_txtTelefono" type="number" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control required" title="Introduzca el email del profesor" id="I_txtEmail" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Padecimientos</label>
                                    <textarea class="form-control border-input" title="Padecimientos..." id="I_txtPadecimientos" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <textarea class="form-control border-input" title="Dirección..." id="I_txtDireccion" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="clearfix"></div>
                    </div><!-- end card-content -->
                </div><!-- end modal-body -->
                <div class="modal-footer">
                    <button type="button" class="btn btnCancel_customColor" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btnOK_customColor" onclick="IngresarProfesor()">Ingresar</button>
                </div><!-- end modal-footer -->
            </div><!-- end modal-content -->
        </div><!-- end modal-dialog modal_custom -->
    </div><!-- end modal fade in -->

    <div class="modal fade in" id="Details" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Información del profesor</h4>
                </div><!-- end modal-header -->
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control required" readonly="readonly" id="D_txtCedula" type="number" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control required" readonly="readonly" id="D_txtNombre" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control required" readonly="readonly" id="D_txtApellidos" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Número de teléfono</label>
                                    <input class="form-control required" readonly="readonly" id="D_txtTelefono" type="number" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control required" readonly="readonly" id="D_txtEmail" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Padecimientos</label>
                                    <textarea class="form-control border-input" readonly="readonly" id="D_txtPadecimientos" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <textarea class="form-control border-input" readonly="readonly" id="D_txtDireccion" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="clearfix"></div>
                    </div><!-- end card-content -->
                </div><!-- end modal-body -->
                <div class="modal-footer">
                    <button type="button" class="btn btnCancel_customColor" data-dismiss="modal">Cerrar</button>
                </div><!-- end modal-footer -->
            </div><!-- end modal-content -->
        </div><!-- end modal-dialog modal_custom -->
    </div><!-- end modal fade in -->

    <div class="modal fade in" id="Update" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Actualizar datos del profesor</h4>
                </div><!-- end modal-header -->
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control required" id="U_txtCedula" readonly="readonly" type="number" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control required" id="U_txtNombre" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control required" id="U_txtApellidos" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Número de teléfono</label>
                                    <input class="form-control required" id="U_txtTelefono" type="number" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control required" id="U_txtEmail" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Padecimientos</label>
                                    <textarea class="form-control border-input" id="U_txtPadecimientos" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <textarea class="form-control border-input" id="U_txtDireccion" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="clearfix"></div>
                    </div><!-- end card-content -->
                </div><!-- end modal-body -->
                <div class="modal-footer">                    
                    <button type="button" class="btn btnCancel_customColor" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btnOK_customColor" onclick="ActualizarProfesor()">Actualizar</button>
                </div><!-- end modal-footer -->
            </div><!-- end modal-content -->
        </div><!-- end modal-dialog modal_custom -->
    </div><!-- end modal fade in -->
</asp:Content>

<asp:Content ID="JS" ContentPlaceHolderID="JS" runat="server">
    <script src="Scripts/AdmProfesores.js"></script>
</asp:Content>
