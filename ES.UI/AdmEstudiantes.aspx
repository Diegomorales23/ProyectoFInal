<%@ Page Title="Adm. Estudiantes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmEstudiantes.aspx.cs" Inherits="ES.UI.AdmEstudiantes" %>

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
                <li class="active">
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

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Administración de Estudiantes
                </h4>
                <p class="category">
                    Seleccione el estudiante que desea administrar o bien ingrese uno nuevo
                </p>
                <br />
                <button type="button" class="btn btnCreateStudent" data-toggle="modal" data-target="#Insert" onclick="Llenar()">Ingresar estudiante</button>
            </div><!-- end card-header -->

            <div class="card-content">
                <table id="bootstrap-table" class="table">
                    <thead>
                        <th data-field="Id" class="text-center">Número de cédula</th>
                        <th data-field="Nombre" class="text-center">Nombre</th>
                        <th data-field="Seccion" class="text-center" data-sortable="true">Sección</th>
                        <th data-field="Telefono" class="text-center">Teléfono</th>
                        <th data-field="actions" class="td-actions text-center" data-events="operateEvents" data-formatter="operateFormatter">Acciones</th>
                    </thead>
                    <tbody>
                        <% MostrarEstudiantes(); %>
                    </tbody>
                </table>
            </div><!-- end card-content -->
        </div><!-- end card -->
    </div><!-- end col-md-12 -->

    <div class="modal fade in" id="Insert" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div>
                    <div class="form-wizard form-header-stylist form-body-material">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h3>Ingresar Estudiante</h3>
                        <p>Rellene los espacios en blanco para ingresar un nuevo estudiante en el sistema</p>

                        <div class="form-wizard-steps form-wizard-tolal-steps-4">
                            <div class="form-wizard-progress">
                                <div class="form-wizard-progress-line" data-now-value="12.25" data-number-of-steps="4" style="width: 12.25%;">
                                </div><!-- end form-wizard-progress-line -->
                            </div><!-- end form-wizard-progress -->
                            <div class="form-wizard-step active">
                                <div class="form-wizard-step-icon">
                                    <i class="fa fa-info" aria-hidden="true"></i>
                                </div><!-- end form-wizard-steps-icon -->
                                <p class="custom-margin">Estudiante (1/2)</p>
                            </div><!-- end form-wizard active -->
                            <div class="form-wizard-step">
                                <div class="form-wizard-step-icon">
                                    <i class="fa fa-info" aria-hidden="true"></i>
                                </div><!-- end form-wizard-steps-icon -->
                                <p class="custom-margin">Estudiante (2/2)</p>
                            </div><!-- end form-wizard-step -->
                            <div class="form-wizard-step">
                                <div class="form-wizard-step-icon">
                                    <i class="fa fa-info" aria-hidden="true"></i>
                                </div><!-- end form-wizard-steps-icon -->
                                <p class="custom-margin">Encargado (1/2)</p>
                            </div><!-- end form-wizard-step -->
                            <div class="form-wizard-step">
                                <div class="form-wizard-step-icon">
                                    <i class="fa fa-info" aria-hidden="true"></i>
                                </div><!-- end form-wizard-step-icon -->
                                <p class="custom-margin">Encargado (2/2)</p>
                            </div><!-- end form-wizard-step -->
                        </div><!-- end form-wizard-steps form-wizard-tolal-steps-4 -->

                        <fieldset>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="25.6" aria-valuemin="0" aria-valuemax="100" style="width: 25.6%"></div>
                            </div><!-- end progress -->

                            <h4>Información del Estudiante (1/2): <span>Paso 1 - 4</span></h4>
                            <div class="form-group col-xs-4">
                                <input class="form-control required" title="Introduzca el número de cédula del estudiante" placeholder="Número de Cédula" id="C_txtIdCedula" type="number" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-4">
                                <input class="form-control required" title="Introduzca el nombre del estudiante" placeholder="Nombre" id="C_txtNombre" type="text" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-4">
                                <input class="form-control required" title="Introduzca los apellidos del estudiante" placeholder="Apellidos" id="C_txtApellidos" type="text" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-6">
                                <input class="form-control required" title="Introduzca el número de teléfono del estudiante" placeholder="Teléfono" id="C_txtTelefono" type="number" />
                            </div><!-- end form-group col-xs-6 -->
                            <div class="form-group col-xs-6">
                                <input class="form-control" title="Introduzca el correo electronico del estudiante" placeholder="Email" id="C_txtEmail" type="email" />
                            </div><!-- end form-group col-xs-6 -->
                            <div class="form-group col-xs-12">
                                <textarea required="required" class="form-control border-input required" placeholder="Dirección" title="Digite la dirección del estudiante" id="C_txtDireccion"></textarea>
                            </div><!-- end form-group col-xs-12 -->
                            <br />
                            <div class="form-wizard-buttons">
                                <button type="button" class="btn btn-next">Siguiente</button>
                            </div><!-- end form-wizard-buttons -->
                        </fieldset>

                        <fieldset>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="50.6" aria-valuemin="0" aria-valuemax="100" style="width: 50.6%">
                                </div>
                            </div><!-- end progress -->

                            <h4>Información del Estudiante (2/2): <span>Paso 2 - 4</span></h4>

                            <div class="form-group col-xs-12">
                                <textarea class="form-control border-input" placeholder="Padecimientos" title="Digite los padecimientos del estudiante" id="C_txtPadecimientos"></textarea>
                            </div><!-- end form-group col-xs-12 -->
                            <div class="form-group col-xs-6">
                                <select id="ddlNiveles" class="form-control required" title="Niveles" data-size="4" required="required">
                                    <option hidden>Niveles</option>
                                </select>
                            </div><!-- end form-group col-xs-6 -->
                            <div class="form-group col-xs-6">
                                <select id="ddlSecciones" class="form-control required" title="Sección" data-size="5" required="required">
                                    <option hidden>Sección</option>
                                </select>
                            </div><!-- end form-group col-xs-6 -->
                            <br />
                            <div class="form-wizard-buttons">
                                <button type="button" class="btn btn-previous">Atras</button>
                                <button type="button" class="btn btn-next">Siguiente</button>
                            </div><!-- end form-wizard-buttons -->
                        </fieldset>

                        <fieldset>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="75.6" aria-valuemin="0" aria-valuemax="100" style="width: 75.6%"></div>
                            </div><!-- end progress -->

                            <h4>Información del Encargado (1/2): <span>Paso 3 - 4</span></h4>

                            <div class="form-group col-xs-4">
                                <input class="form-control required" title="Introduzca el número de cédula del encargado" placeholder="Número de Cédula" id="C_txtIdCedulaEnc" type="number" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-4">
                                <input class="form-control required" title="Introduzca el nombre del encargado" placeholder="Nombre" id="C_txtNombreEnc" type="text" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-4">
                                <input class="form-control required" title="Introduzca los apellidos del encargado" placeholder="Apellidos" id="C_txtApellidosEnc" type="text" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-3">
                                <input class="form-control" title="Introduzca el email del encargado" placeholder="Email" id="C_txtEmailEnc" type="text" />
                            </div><!-- end form-group col-xs-3 -->
                            <div class="form-group col-xs-3">
                                <input class="form-control" title="Introduzca el número de teléfono de residencia del encargado" placeholder="Teléfono Residencia" id="C_txtTelefonoRes" type="number" />
                            </div><!-- end form-group col-xs-3 -->
                            <div class="form-group col-xs-3">
                                <input class="form-control" title="Introduzca el número de teléfono del trabajo del encargado" placeholder="Teléfono Trabajo" id="C_txtTelefonoTra" type="number" />
                            </div><!-- end form-group col-xs-3 -->
                            <div class="form-group col-xs-3">
                                <input class="form-control" title="Introduzca el número de teléfono móvil del encargado" placeholder="Teléfono Móvil" id="C_txtTelefonoMov" type="number" />
                            </div><!-- end form-group col-xs-3 -->
                            <br />
                            <div class="form-wizard-buttons">
                                <button type="button" class="btn btn-previous">Atras</button>
                                <button type="button" class="btn btn-next">Siguiente</button>
                            </div><!-- end form-wizard-buttons -->
                        </fieldset>

                        <fieldset>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped active" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100" style="width: 100%"></div>
                            </div><!-- end progress -->

                            <h4>Información del Encargado (2/2): <span>Paso 4 - 4</span></h4>
                     
                            <div class="form-group col-xs-12">
                                <textarea class="form-control border-input" placeholder="Dirección" title="Digite la dirección del encargado" id="C_txtDireccionEnc"></textarea>
                            </div><!-- end form-group col-xs-12 -->                     
                            <div class="form-group col-xs-4">
                                <select id="ddlParentesco" class="form-control required" required="required" title="Parentesco" data-size="5">
                                    <option hidden>Parentesco</option>
                                </select>
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-4">
                                <input class="form-control" title="Introduzca el lugar de trabajo del encargado" placeholder="Lugar de trabajo" id="C_txtLugar" type="text" />
                            </div><!-- end form-group col-xs-4 -->
                            <div class="form-group col-xs-4">
                                <input class="form-control" title="Introduzca la ocupación que desempeña el encargado" placeholder="Ocupación" id="C_txtOcupacion" type="text" />
                            </div><!-- end form-group col-xs-4 -->
                            <br />
                            <div class="form-wizard-buttons">
                                <button type="button" class="btn btn-previous">Atras</button>
                                <button type="button" class="btn btn-submit" onclick="Ingresar()">Ingresar estudiante</button>
                            </div><!-- end form-wizard-buttons-->
                        </fieldset>
                    </div><!-- end form-wizard form-header-stylist form-body-material -->
                </div><!-- end div -->
            </div><!-- end modal-content -->
        </div><!-- end modal-dialog modal_custom -->
    </div><!-- end modal fade in -->
    
    <div class="modal fade in" id="Edit" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Editar estudiante</h4>
                </div><!-- end modal-header -->
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control" title="Número de Cédula" readonly="readonly" id="U_txtCedula" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control required" title="Introduzca el nombre del estudiante" id="U_txtNombre" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control required" title="Introduzca los apellidos del estudiante" id="U_txtApellidos" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Número de teléfono</label>
                                    <input class="form-control required" title="Introduzca el número de teléfono del estudiante" id="U_txtTelefono" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control required" title="Introduzca el email del estudiante" id="U_txtEmail" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Grado</label>
                                    <select id="ddlGrado" class="form-control required" data-size="2"></select>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Sección</label>
                                    <select id="ddlSeccion" class="form-control required" data-size="2"></select>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Abandono</label>
                                    <select id="ddlAbandono" class="form-control required" data-size="2">
                                        <option value="1">No</option>
                                        <option value="2">Si</option>
                                    </select>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Graduado</label>
                                    <select id="ddlGraduado" class="form-control required" data-size="2">
                                        <option value="1">No</option>
                                        <option value="2">Si</option>
                                    </select>
                               </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Año de Graduación</label>
                                    <input class="form-control required" title="Introduzca el año de graduación" id="U_txtAnoGraduacion" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <textarea class="form-control border-input" title="Dirección..." id="U_txtDireccion" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Padecimientos</label>
                                    <textarea class="form-control border-input" title="Padecimientos..." id="U_txtPadecimientos" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="clearfix"></div>
                    </div><!-- end card-content -->
                </div><!-- end modal-body -->
                <div class="modal-footer">
                    <button type="button" class="btn btnCancel_customColor" data-dismiss="modal">Cerrar</button>
                    <button type="button" class="btn btnOK_customColor" onclick="Actualizar()">Actualizar</button>
                </div><!-- end modal-footer -->
            </div><!-- end modal-content -->
        </div><!-- end modal-dialog modal_custom -->
    </div><!-- end modal fade in -->

    <div class="modal fade in" id="Details" role="dialog">
        <div class="modal-dialog modal_custom">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Información del estudiante</h4>
                </div><!-- end modal-header -->
                <div class="modal-body">
                    <div class="card-content">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Número de Cédula</label>
                                    <input class="form-control" title="Número de Cédula" readonly="readonly" id="V_txtCedula" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtNombre" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtApellidos" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Número de teléfono</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtTelefono" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Email</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtEmail" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Grado</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtGrado" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Sección</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtSeccion" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Abandono</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtAbandono" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-3 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Graduado</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtGraduado" type="text" />                                
                               </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Año de Graduación</label>
                                    <input class="form-control required" readonly="readonly" id="V_txtAnoGraduacion" type="text" />
                                </div><!-- end form-group -->
                            </div><!-- end col-md-6 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <textarea class="form-control border-input" readonly="readonly" id="V_txtDireccion" rows="3"></textarea>
                                </div><!-- end form-group -->
                            </div><!-- end col-md-12 -->
                        </div><!-- end row -->
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label>Padecimientos</label>
                                    <textarea class="form-control border-input" readonly="readonly" id="V_txtPadecimientos" rows="3"></textarea>
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
</asp:Content>

<asp:Content ID="JS" ContentPlaceHolderID="JS" runat="server">
    <script src="Scripts/AdmEstudiantes.js"></script>
</asp:Content>

