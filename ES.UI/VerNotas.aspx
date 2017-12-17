<%@ Page Title="Notas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerNotas.aspx.cs" Inherits="ES.UI.VerNotas" %>

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
                <li>
                    <a href="AdmProfesores.aspx">
                        <i class="fa fa-sliders"></i>
                        <p>Adm Profesores</p>
                    </a>
                </li>
                <li>
                    <a href="AdmCursos.aspx">
                        <i class="fa fa-sliders"></i>
                        <p>Adm Cursos</p>
                    </a>
                </li>
                <li class="active">
                    <a href="VerNotas.aspx">
                        <i class="fa fa-sliders"></i>
                        <p>Notas</p>
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
                <a class="navbar-brand" href="#">Administración de Estudiantes</a>
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
    
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Administración de Notas</h4>
                <p class="category">
                    Seleccione el estudiante que desea ver sus notas o bien modifique las mismas
                </p>
                <br />
            </div><!-- end card-header -->

            <div class="card-content">
                <table id="bootstrap-table" class="table">
                    <thead>
                        <th data-field="Id" class="text-center">#</th>
                        <th data-field="Nombre" class="text-center">Nombre</th>
                        <th data-field="Seccion" class="text-center" data-sorteable="true">Sección</th>
                        <th data-field="PRE1" class="text-center">I P</th>
                        <th data-field="PRE2" class="text-center">II P</th>
                        <th data-field="PRE3" class="text-center">III P</th>
                        <th data-field="PREF" class="text-center">Promedio</th>
                        <th data-field="actions" class="td-actions text-center" data-events="operateEvents" data-formatter="operateFormatter">Acciones</th>
                    </thead>
                    <tbody>
                        <% MostrarNotas(); %>
                    </tbody>
                </table>
            </div><!-- end card-content -->
        </div><!-- end card -->
    </div><!-- end col-md-12 -->

    <div class="modal fade in" id="Edit" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Editar notas</h4>
                </div><!-- end modal-header -->
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control required" readonly="readonly" id="txtNombre" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control required" readonly="readonly" id="txtApellidos" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Sección</label>
                                    <input class="form-control required" readonly="readonly" id="txtSeccion" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Materia</label>
                                    <input class="form-control required" readonly="readonly" id="txtMateria" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Primer Periodo</label>
                                    <input class="form-control required" id="txtIP" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Segundo Periodo</label>
                                    <input class="form-control required" id="txtIIP" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Tercer Periodo</label>
                                    <input class="form-control required" id="txtIIIP" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-4 -->
                        </div><!-- end row -->
                        <div class="clearfix"></div>
                    </div><!-- end card-content -->
                </div><!-- end modal-body -->
                <div class="modal-footer">
                    <button type="button" class="btn btnCancel_customColor" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btn-submit" onclick="Actualizar()">Actualizar</button>
                </div><!-- end modal-footer -->
            </div><!-- end modal-content -->
        </div><!-- end modal-dialog modal_custom -->
    </div><!-- end modal fade in -->
</asp:Content>

<asp:Content ID="JS" ContentPlaceHolderID="JS" runat="server">
    <script src="Scripts/Notas.js"></script>
</asp:Content>
