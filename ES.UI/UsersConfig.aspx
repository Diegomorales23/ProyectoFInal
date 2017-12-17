<%@ Page Title="Adm Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsersConfig.aspx.cs" Inherits="ES.UI.UsersConfig" %>
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
                    <div class="collapse in" id="users">
                        <ul class="nav">
                            <li>
                                <a href="MyProfile.aspx">
                                    <span class="sidebar-mini fa fa-user custom_01"></span>
                                    <span class="sidebar-normal">Mi Perfil</span>
                                </a>
                            </li>
                            <li class="active">
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
                <li>
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
            </div>

            <div class="navbar-header">
                <button type="button" class="navbar-toggle">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar bar1"></span>
                    <span class="icon-bar bar2"></span>
                    <span class="icon-bar bar3"></span>
                </button>
                <a class="navbar-brand" href="#AdmUsuarios">Adm. Usuarios
                </a>
            </div>

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
            </div>
        </div>
    </nav>
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Administración de usuarios
                </h4>
                <p class="category">
                    Seleccione el usuario que desea administrar o bien cree un nuevo usuario
                </p>
                <br />
                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#CreateUser">Crear usuario</button>
            </div>
            <div class="card-content">
                <table id="bootstrap-table" class="table">
                    <thead>
                        <th class="text-center" data-field="Usuario">Usuario</th>
                        <th class="text-center" data-field="Nombre">Nombre</th>
                        <th class="text-center" data-field="Rol">Rol</th>
                        <th class="text-center" data-field="Email">Email</th>
                        <th class="text-center" data-field="Telefono">Teléfono</th>
                        <th data-field="actions" class="td-actions text-center" data-events="operateEvents" data-formatter="operateFormatter">Acciones</th>
                    </thead>
                    <tbody>
                        <% MostrarUsuarios(); %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <!-- Modal CrearUsuario -->
    <div class="modal fade in" id="CreateUser" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Crear Usuario</h4>
                </div>
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control" title="Digite el nombre del usuario" id="C_txtNombre" required="required" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control" title="Digite los apellidos del usuario" id="C_txtApellidos" required="required" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control" title="Digite el email del usuario" id="C_txtEmail" required="required" type="email" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control" title="Digite el número de cédula del usuario" id="C_txtCedula" required="required" type="number" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Rol</label>
                                    <select id="C_ddlRol" class="form-control" title="Seleccione el rol del usuario" data-size="2" required="required">
                                        <option selected disabled hidden>Seleccione un rol</option>
                                        <option value="Administrador">Administrador</option>
                                        <option value="Usuario">Usuario</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Teléfono</label>
                                    <input class="form-control" title="Digite el número de teléfono del usuario" id="C_txtTelefono" required="required" type="number" />
                                </div>
                            </div>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btn-info btn-fill btn-wd" onclick="CrearUsuario()">Crear Usuario</button>
                </div>
            </div>
        </div>
    </div>
    <!--/ Modal CrearUsuario -->

    <!-- Modal VerUsuario -->
    <div class="modal fade in" id="VerUsuario" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Detalles del usuario</h4>
                </div>
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <div class="form-group">
                                    <div class="author">
               <img src="http://allfreedesigns.com/wp-content/uploads/2014/08/tech-backgrounds-2.jpg" />
                                     </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control" id="D_txtNombre" readonly="readonly" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control" id="D_txtApellidos" readonly="readonly" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control" id="D_txtEmail" readonly="readonly" type="email" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control" id="D_txtCedula" readonly="readonly" type="number" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Rol</label>
                                    <input class="form-control" id="D_txtRol" readonly="readonly" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Teléfono</label>
                                    <input class="form-control" id="D_txtTelefono" readonly="readonly" type="number" />
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>
    <!--/ Modal VerUsuario -->

    <!-- Modal EditarUsuario -->
    <div class="modal fade in" id="EditarUsuario" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Editar Usuario</h4>
                </div>
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <div class="form-group">
                                    <div class="author">
                                        <img src="http://allfreedesigns.com/wp-content/uploads/2014/08/tech-backgrounds-2.jpg" />            
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control" title="Digite el nombre del usuario" id="E_txtNombre" required="required" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control" title="Digite los apellidos del usuario" id="E_txtApellidos" required="required" type="text" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control" title="Digite el email del usuario" id="E_txtEmail" required="required" type="email" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control" title="Digite el número de cédula del usuario" id="E_txtCedula" required="required" type="number" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Rol</label>
                                    <select id="E_ddlRole" class="form-control" title="Seleccione el rol del usuario" data-size="2" required="required">
                                        <option selected disabled hidden>Seleccione un rol</option>
                                        <option value="Administrador">Administrador</option>
                                        <option value="Usuario">Usuario</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Número de Teléfono</label>
                                    <input class="form-control" title="Digite el número de teléfono del usuario" id="E_txtTelefono" required="required" type="number" />
                                </div>
                            </div>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btn-info btn-fill btn-wd" onclick="EditarUsuario()">Actualizar</button>
                </div>
            </div>
        </div>
    </div>
    <!--/ Modal EditarUsuario -->
</asp:Content>

<asp:Content ID="JS" ContentPlaceHolderID="JS" runat="server">
    <script src="Scripts/UsersConfig.js"></script>
</asp:Content>
