<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ES.UI.Index" %>

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
                    </div>
                </div>
            </div>

            <ul class="nav">
                <li class="active">
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
                <a class="navbar-brand" href="#Dashboard">Dashboard
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
    <div class="row">
        <div class="col-lg-3 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-5">
                            <div class="icon-big icon-primary text-center">
                                <i class="fa fa-th-large"></i>
                            </div>
                        </div>
                        <div class="col-xs-7">
                            <div class="numbers">
                                <p>Paneles</p>
                                <asp:Label ID="PanelCount" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card-footer">
                    <hr />
                    <div class="stats">
                        <i class="fa fa-refresh fa-spin"></i>Actualizado
                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-3 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-5">
                            <div class="icon-big icon-success text-center">
                                <i class="fa fa-plus"></i>
                            </div>
                        </div>
                        <div class="col-xs-7">
                            <div class="numbers">
                                <p>Disponible</p>
                                0
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card-footer">
                    <hr />
                    <div class="stats">
                        <i class="fa fa-refresh fa-spin"></i>Actualizado
                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-3 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-5">
                            <div class="icon-big icon-danger text-center">
                                <i class="fa fa-plus"></i>
                            </div>
                        </div>
                        <div class="col-xs-7">
                            <div class="numbers">
                                <p>Disponible</p>
                                0
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card-footer">
                    <hr />
                    <div class="stats">
                        <i class="fa fa-refresh fa-spin"></i>Actualizado
                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-3 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-5">
                            <div class="icon-big icon-info text-center">
                                <i class="fa fa-plus"></i>
                            </div>
                        </div>
                        <div class="col-xs-7">
                            <div class="numbers">
                                <p>Disponble</p>
                                0
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card-footer">
                    <hr />
                    <div class="stats">
                        <i class="fa fa-refresh fa-spin"></i>Actualizado
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-4 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-7">
                            <div class="numbers pull-left">
                                $34,657
                            </div>
                        </div>
                        <div class="col-xs-5">
                            <div class="pull-right">
                                <span class="label label-success">+18%
                                </span>
                            </div>
                        </div>
                    </div>
                    <h6 class="big-title">total earnings <span class="text-muted">in last</span> ten <span class="text-muted">quarters</span></h6>
                    <div id="chartTotalEarnings"></div>
                </div>
                <div class="card-footer">
                    <hr>
                    <div class="footer-title">Financial Statistics</div>
                    <div class="pull-right">
                        <button class="btn btn-info btn-fill btn-icon btn-sm">
                            <i class="ti-plus"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-4 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-7">
                            <div class="numbers pull-left">
                                169
                            </div>
                        </div>
                        <div class="col-xs-5">
                            <div class="pull-right">
                                <span class="label label-danger">-14%
                                </span>
                            </div>
                        </div>
                    </div>
                    <h6 class="big-title">total subscriptions <span class="text-muted">in last</span> 7 days</h6>
                    <div id="chartTotalSubscriptions"></div>
                </div>
                <div class="card-footer">
                    <hr>
                    <div class="footer-title">View all members</div>
                    <div class="pull-right">
                        <button class="btn btn-default btn-fill btn-icon btn-sm">
                            <i class="ti-angle-right"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-4 col-sm-6">
            <div class="card">
                <div class="card-content">
                    <div class="row">
                        <div class="col-xs-7">
                            <div class="numbers pull-left">
                                8,960
                            </div>
                        </div>
                        <div class="col-xs-5">
                            <div class="pull-right">
                                <span class="label label-warning">~51%
                                </span>
                            </div>
                        </div>
                    </div>
                    <h6 class="big-title">total downloads <span class="text-muted">in last</span> 6 years</h6>
                    <div id="chartTotalDownloads"></div>
                </div>
                <div class="card-footer">
                    <hr>
                    <div class="footer-title">View more details</div>
                    <div class="pull-right">
                        <button class="btn btn-success btn-fill btn-icon btn-sm">
                            <i class="ti-info"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-3 col-sm-6">
            <div class="card card-circle-chart" data-background-color="blue">
                <div class="card-header text-center">
                    <h5 class="card-title">Dashboard</h5>
                    <p class="description">Monthly sales target</p>
                </div>
                <div class="card-content">
                    <div id="chartDashboard" class="chart-circle" data-percent="70">70%</div>
                </div>
            </div>
        </div>
        <div class="col-lg-3 col-sm-6">
            <div class="card card-circle-chart" data-background-color="green">
                <div class="card-header text-center">
                    <h5 class="card-title">Orders</h5>
                    <p class="description">Completed</p>
                </div>
                <div class="card-content">
                    <div id="chartOrders" class="chart-circle" data-percent="34">34%</div>
                </div>
            </div>
        </div>
        <div class="col-lg-3 col-sm-6">
            <div class="card card-circle-chart" data-background-color="orange">
                <div class="card-header text-center">
                    <h5 class="card-title">New Visitors</h5>
                    <p class="description">Out of total number</p>
                </div>
                <div class="card-content">
                    <div id="chartNewVisitors" class="chart-circle" data-percent="62">62%</div>
                </div>
            </div>
        </div>
        <div class="col-lg-3 col-sm-6">
            <div class="card card-circle-chart" data-background-color="brown">
                <div class="card-header text-center">
                    <h5 class="card-title">Subscriptions</h5>
                    <p class="description">Monthly newsletter</p>
                </div>
                <div class="card-content">
                    <div id="chartSubscriptions" class="chart-circle" data-percent="10">10%</div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div id="container" style="min-width: 310px; height: 400px; margin: 0 auto"></div>
    </div>
</asp:Content>

<asp:Content ID="JS" ContentPlaceHolderID="JS" runat="server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/data.js"></script>
    <script src="https://code.highcharts.com/modules/drilldown.js"></script>
    <script>
        // Create the chart
        Highcharts.chart('container', {
            chart: {
                type: 'column'
            },
            title: {
                text: 'Browser market shares. January, 2015 to May, 2015'
            },
            subtitle: {
                text: 'Click the columns to view versions. Source: <a href="http://netmarketshare.com">netmarketshare.com</a>.'
            },
            xAxis: {
                type: 'category'
            },
            yAxis: {
                title: {
                    text: 'Total percent market share'
                }

            },
            legend: {
                enabled: false
            },
            plotOptions: {
                series: {
                    borderWidth: 0,
                    dataLabels: {
                        enabled: true,
                        format: '{point.y:.1f}%'
                    }
                }
            },

            tooltip: {
                headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
                pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y:.2f}%</b> of total<br/>'
            },

            series: [{
                name: 'Brands',
                colorByPoint: true,
                data: [{
                    name: 'Microsoft Internet Explorer',
                    y: 56.33,
                    drilldown: 'Microsoft Internet Explorer'
                }, {
                    name: 'Chrome',
                    y: 24.03,
                    drilldown: 'Chrome'
                }, {
                    name: 'Firefox',
                    y: 10.38,
                    drilldown: 'Firefox'
                }, {
                    name: 'Safari',
                    y: 4.77,
                    drilldown: 'Safari'
                }, {
                    name: 'Opera',
                    y: 0.91,
                    drilldown: 'Opera'
                }, {
                    name: 'Proprietary or Undetectable',
                    y: 0.2,
                    drilldown: null
                }]
            }],
            drilldown: {
                series: [{
                    name: 'Microsoft Internet Explorer',
                    id: 'Microsoft Internet Explorer',
                    data: [
                        [
                            'v11.0',
                            24.13
                        ],
                        [
                            'v8.0',
                            17.2
                        ],
                        [
                            'v9.0',
                            8.11
                        ],
                        [
                            'v10.0',
                            5.33
                        ],
                        [
                            'v6.0',
                            1.06
                        ],
                        [
                            'v7.0',
                            0.5
                        ]
                    ]
                }, {
                    name: 'Chrome',
                    id: 'Chrome',
                    data: [
                        [
                            'v40.0',
                            5
                        ],
                        [
                            'v41.0',
                            4.32
                        ],
                        [
                            'v42.0',
                            3.68
                        ],
                        [
                            'v39.0',
                            2.96
                        ],
                        [
                            'v36.0',
                            2.53
                        ],
                        [
                            'v43.0',
                            1.45
                        ],
                        [
                            'v31.0',
                            1.24
                        ],
                        [
                            'v35.0',
                            0.85
                        ],
                        [
                            'v38.0',
                            0.6
                        ],
                        [
                            'v32.0',
                            0.55
                        ],
                        [
                            'v37.0',
                            0.38
                        ],
                        [
                            'v33.0',
                            0.19
                        ],
                        [
                            'v34.0',
                            0.14
                        ],
                        [
                            'v30.0',
                            0.14
                        ]
                    ]
                }, {
                    name: 'Firefox',
                    id: 'Firefox',
                    data: [
                        [
                            'v35',
                            2.76
                        ],
                        [
                            'v36',
                            2.32
                        ],
                        [
                            'v37',
                            2.31
                        ],
                        [
                            'v34',
                            1.27
                        ],
                        [
                            'v38',
                            1.02
                        ],
                        [
                            'v31',
                            0.33
                        ],
                        [
                            'v33',
                            0.22
                        ],
                        [
                            'v32',
                            0.15
                        ]
                    ]
                }, {
                    name: 'Safari',
                    id: 'Safari',
                    data: [
                        [
                            'v8.0',
                            2.56
                        ],
                        [
                            'v7.1',
                            0.77
                        ],
                        [
                            'v5.1',
                            0.42
                        ],
                        [
                            'v5.0',
                            0.3
                        ],
                        [
                            'v6.1',
                            0.29
                        ],
                        [
                            'v7.0',
                            0.26
                        ],
                        [
                            'v6.2',
                            0.17
                        ]
                    ]
                }, {
                    name: 'Opera',
                    id: 'Opera',
                    data: [
                        [
                            'v12.x',
                            0.34
                        ],
                        [
                            'v28',
                            0.24
                        ],
                        [
                            'v27',
                            0.17
                        ],
                        [
                            'v29',
                            0.16
                        ]
                    ]
                }]
            }
        });
    </script>
</asp:Content>
