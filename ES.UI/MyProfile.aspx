<%@ Page Title="Mi Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="ES.UI.MyProfile" %>

<asp:Content ID="Menu" ContentPlaceHolderID="Menu" runat="server">
    <div class="sidebar" data-background-color="brown" data-active-color="danger">
        <div class="logo">
            <a href="Index.aspx" class="simple-text logo-normal">
                <img class="img-responsive logo-normal" src="images/logo.png" style="height: 100px; margin-left: auto; margin-right: auto;" />
            </a>
        </div>

        <div class="sidebar-wrapper">
            <div class="user">
                <div class="info">
                    <div class="photo">
                        <img src="images/profile.png" />
                    </div>

                    <a data-toggle="collapse" href="#users" class="collapsed">
                        <span>Perfil
                            <b class="caret"></b>
                        </span>
                    </a>

                    <div class="clearfix"></div>

                    <div class="collapse in" id="users">
                        <ul class="nav">
                            <li class="active">
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
                    </div>
                </div>
            </div>

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
                        <p>Adm. de Estudiantes</p>
                    </a>
                </li>
                <li>
                    <a href="#">
                        <i class="fa fa-sliders"></i>
                        <p>Adm. de Profesores</p>
                    </a>
                </li>
                <li>
                    <a href="Herramientas.aspx">
                        <i class="fa fa-wrench"></i>
                        <p>Herramientas</p>
                    </a>
                </li>
            </ul>
        </div>
    </div>
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
                <a class="navbar-brand" href="#MyProfile">
                    Mi Perfil
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
    <div class="col-lg-5 col-md-5">
        <div class="card card-user">
            <div class="image">
                <img src="http://allfreedesigns.com/wp-content/uploads/2014/08/tech-backgrounds-2.jpg" />
            </div>
            <div class="card-content">
                <div class="author">
                    <img class="avatar border-white" src="<% Foto(); %>" />
                    <h4 class="card-title">
                        <asp:Label ID="username" runat="server"></asp:Label>
                        <br />
                        <a href="#email"><small>
                            <asp:Label ID="email" runat="server"></asp:Label>
                        </small></a>
                    </h4>
                </div>
                <p class="description text-center custom_19">
                    "
                    <asp:Label ID="phrase" runat="server"></asp:Label>
                    "
                </p>
            </div>
            <hr>
            <div class="text-center">
                <div class="row">
                    <div class="col-md-3 col-md-offset-1 custom_07">
                        <h5>Usuario<br />
                            <small>
                                <asp:Label ID="user" runat="server" />
                            </small>
                        </h5>
                    </div>
                    <div class="col-md-4">
                        <h5>Teléfono<br />
                            <small>
                                <asp:Label ID="tel" runat="server" />
                            </small>
                        </h5>
                    </div>
                    <div class="col-md-4">
                        <h5>Rol<br />
                            <small>
                                <asp:Label ID="role" runat="server" />
                            </small>
                        </h5>
                    </div>
                </div>
            </div>
        </div>

        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Miembros</h4>
            </div>
            <div class="card-content card_members">
                <ul class="list-unstyled team-members">
                    <% Usuarios();  %>
                </ul>
            </div>
        </div>
    </div>

    <div class="col-lg-7 col-md-7">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Editar Perfil</h4>
            </div>
            <div class="card-content">
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Nombre</label>
                            <asp:TextBox CssClass="form-control border-input" ToolTip="Digite su nombre" ID="E_FirstName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Apellidos</label>
                            <asp:TextBox CssClass="form-control border-input" ToolTip="Digite sus apellidos" ID="E_LastName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label>Email</label>
                            <asp:TextBox CssClass="form-control border-input" TextMode="Email" ToolTip="Digite su email" ID="E_Email" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <label>Rol</label>
                            <asp:TextBox CssClass="form-control border-input" ReadOnly="true" ID="E_Role" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label>Teléfono</label>
                            <asp:TextBox CssClass="form-control border-input" ToolTip="Digite su número teléfonico" ID="E_Telephone" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label>Número de Cédula</label>
                            <asp:TextBox CssClass="form-control border-input" ReadOnly="true" ToolTip="Digite su número de cédula" ID="E_IdCard" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label>Frase</label>
                            <textarea runat="server" id="E_Phrase" rows="5" class="form-control border-input" placeholder="Frase diaria..."></textarea>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <label>Foto de Perfil</label>
                        <div class="input-group image-preview">
                            <input type="text" class="form-control image-preview-filename" disabled="disabled">
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-default image-preview-clear" style="display: none;">
                                    <span class="glyphicon glyphicon-remove"></span>Limpiar
                   
                                </button>
                                <div class="btn btn-default image-preview-input">
                                    <span class="glyphicon glyphicon-folder-open"></span>
                                    <span class="image-preview-input-title">Buscar</span>
                                    <asp:FileUpload ID="E_Image" runat="server" />
                                </div>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="text-center custom_18">
                    <asp:Button CssClass="btn btn-info btn-fill btn-wd" ID="btn_UpdateProfile" OnClick="btn_UpdateProfile_Click" runat="server" Text="Actualizar" />
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
</asp:Content>
