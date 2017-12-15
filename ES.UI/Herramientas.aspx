<%@ Page Title="Herramientas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Herramientas.aspx.cs" Inherits="ES.UI.Herramientas" %>

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
                <li class="active">
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
                <a class="navbar-brand" href="#">Herramientas</a>
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
<div class="calculator">
  <div class="input-prepend">
    <span class="prepend" id="currentOperator"></span>
    <input class="value" disabled="disabled" id="value" value="0" type="number" ng-model="calcScreen" />
  </div>
  <div class="keypad">
    <span data-num="1" class="btn">1</span>
    <span data-num="2" class="btn">2</span>
    <span data-num="3" class="btn">3</span>
    <span data-operator="&plus;" class="btn btn-function">&plus;</span>
    
    <span data-num="4" class="btn">4</span>
    <span data-num="5" class="btn">5</span>
    <span data-num="6" class="btn">6</span>
    <span data-operator="&minus;" class="btn btn-function">&minus;</span>
    
    <span data-num="7" class="btn">7</span>
    <span data-num="8" class="btn">8</span>
    <span data-num="9" class="btn">9</span>
    <span data-operator="&times;" class="btn btn-function">&times;</span>
    
    <span id="clear" class="btn btn-function">c</span>
    <span data-num="0" class="btn">0</span>
    <span id="neg" class="btn btn-function">-</span>
    <span data-operator="&divide;" class="btn btn-function">&divide;</span>
    
    <span data-equals="=" class="btn btn-block">=</span>
  </div>
</div>

<div class="debug">
  <div>Key: <span id="key"></span></div>
  <div>Current: <span id="current"></span></div>
  <div>Previous: <span id="previous"></span></div>
  <div>Operator: <span id="operator"></span></div>
  <div>newInput: <span id="newInput"></span></div>
</div>
</asp:Content>

<asp:Content ID="JS" ContentPlaceHolderID="JS" runat="server">
        <script src="Scripts/calculator.js"></script>
</asp:Content>
