var $table = $('#bootstrap-table');

function operateFormatter(value, row, index) {
    return [
        '<div class="table-icons">',
            '<a rel="tooltip" title="Ver" class="btn btn-simple btn-info btn-icon table-action view" href="javascript:void(0)">',
                '<i class="fa fa-eye"></i>',
            '</a>',
            '<a rel="tooltip" title="Editar" class="btn btn-simple btn-warning btn-icon table-action edit" href="javascript:void(0)">',
                '<i class="fa fa-pencil"></i>',
            '</a>',
            '<a rel="tooltip" title="Eliminar" class="btn btn-simple btn-danger btn-icon table-action remove" href="javascript:void(0)">',
                '<i class="fa fa-close"></i>',
            '</a>',
        '</div>',
    ].join('');
}

$().ready(function () {
    window.operateEvents = {
        'click .view': function (e, value, row, index) {
            info = JSON.stringify(row);

            $.ajax({
                type: "POST",
                url: "AdmEstudiantes.aspx/GetInfoEstudiante",
                data: "{'IdEstudiante' : '" + row.IdCedula + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("V_txtCedula").value = res[0].ID_ESTUDIANTE;
                    document.getElementById("V_txtNombre").value = res[0].NOMBRE
                    document.getElementById("V_txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("V_txtTelefono").value = res[0].TELEFONO                                       
                    document.getElementById("V_txtEmail").value = res[0].EMAIL

                    if (res[0].GRADUADO == true) {
                        document.getElementById("V_txtGraduado").value = "Si"
                    }
                    else {
                        document.getElementById("V_txtGraduado").value = "No"
                    }

                    if (res[0].ABANDONO == true) {
                        document.getElementById("V_txtAbandono").value = "Si"
                    }
                    else {
                        document.getElementById("V_txtAbandono").value = "No"
                    }

                    document.getElementById("V_txtAnoGraduacion").value = res[0].ANO_GRADUACION;

                    if (res[0].ID_NIVEL == "1") {
                        document.getElementById("V_txtGrado").value = "Séptimo";
                    }
                    else if (res[0].ID_NIVEL == "2") {
                        document.getElementById("V_txtGrado").value = "Octavo";
                    }
                    else if (res[0].ID_NIVEL == "3") {
                        document.getElementById("V_txtGrado").value = "Noveno";
                    }
                    else if (res[0].ID_NIVEL == "4") {
                        document.getElementById("V_txtGrado").value = "Décimo";
                    }
                    else if (res[0].ID_NIVEL == "5") {
                        document.getElementById("V_txtGrado").value = "Undécimo";
                    }

                    document.getElementById("V_txtSeccion").value = res[0].ID_NIVEL;

                    if (res[0].ADELANTA == true) {
                        document.getElementById("V_txtAdelanta").value = "Si";
                    }
                    else {
                        document.getElementById("V_txtAdelanta").value = "No";
                    }

                    document.getElementById("V_txtNivelAdelanta").value = res[0].NIVEL_ADELANTA;
                    document.getElementById("V_txtPadecimientos").value = res[0].PADECIMIENTOS;
                    document.getElementById("V_txtDireccion").value = res[0].DIRECCION;

                    $("#VerEstudiante").modal("show");
                }
            });
        },
        'click .edit': function (e, value, row, index) {
            info = JSON.stringify(row);

            $.ajax({
                type: "POST",
                url: "AdmEstudiantes.aspx/GetInfoEstudiante",
                data: "{'IdEstudiante' : '" + row.IdCedula + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("U_txtCedula").value = res[0].ID_ESTUDIANTE;
                    document.getElementById("U_txtNombre").value = res[0].NOMBRE
                    document.getElementById("U_txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("U_txtTelefono").value = res[0].TELEFONO                                       
                    document.getElementById("U_txtEmail").value = res[0].EMAIL

                    if (res[0].GRADUADO == "Si") {
                        document.getElementById("ddlGraduado").selectedIndex = 1;
                    }
                    else {
                        document.getElementById("ddlGraduado").selectedIndex = 2;
                    }

                    if (res[0].ABANDONO == "Si") {
                        document.getElementById("ddlAbandono").selectedIndex = 1;
                    }
                    else {
                        document.getElementById("ddlAbandono").selectedIndex = 2;
                    }

                    document.getElementById("U_txtAnoGraduacion").value = res[0].ANO_GRADUACION;
                    
                    if (res[0].ID_NIVEL == "1") {
                        document.getElementById("ddlGrado").selectedIndex = 1;
                    }
                    else if (res[0].ID_NIVEL == "2") {
                        document.getElementById("ddlGrado").selectedIndex = 2;                    
                    }
                    else if (res[0].ID_NIVEL == "3") {
                        document.getElementById("ddlGrado").selectedIndex = 3;                    
                    }
                    else if (res[0].ID_NIVEL == "4") {
                        document.getElementById("ddlGrado").selectedIndex = 4;                    
                    }
                    else if (res[0].ID_NIVEL == "5") {
                        document.getElementById("ddlGrado").selectedIndex = 5;                    
                    }

                    document.getElementById("U_txtSeccion").value = res[0].ID_NIVEL;

                    if (res[0].ADELANTA == "true") {
                        document.getElementById("ddlAdelanta_").selectedIndex = 1;
                    }
                    else {
                        document.getElementById("ddlAdelanta_").selectedIndex = 2;
                    }

                    if (res[0].NIVEL_ADELANTA == "1") {
                        document.getElementById("ddlNivelAdelanta_").selectedIndex = 1;
                    }
                    else if (res[0].NIVEL_ADELANTA == "2") {
                        document.getElementById("ddlNivelAdelanta_").selectedIndex = 2;
                    }
                    else if (res[0].NIVEL_ADELANTA == "3") {
                        document.getElementById("ddlNivelAdelanta_").selectedIndex = 3;
                    }
                    else if (res[0].NIVEL_ADELANTA == "4") {
                        document.getElementById("ddlNivelAdelanta_").selectedIndex = 4;
                    }
                    else if (res[0].NIVEL_ADELANTA == "5") {
                        document.getElementById("ddlNivelAdelanta_").selectedIndex = 5;
                    }

                    document.getElementById("U_txtPadecimientos").value = res[0].PADECIMIENTOS;

                    document.getElementById("U_txtDireccion").value = res[0].DIRECCION;

                    $("#EditarEstudiantes").modal("show")
                }
            });
        },
        'click .remove': function (e, value, row, index) {
            swal({
                title: 'Esta seguro?',
                text: "El estudiante " + row.Nombre + " sera eliminado",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#21354c',
                confirmButtonText: "Si, eliminar estudiante",
                cancelButtonText: "Cancelar",
            }).then((result) => {
                if (result.value = true) {
                    $.ajax({
                        type: "POST",
                        url: "AdmEstudiantes.aspx/EliminarEstudiante",
                        data: "{'IdEstudiante' : '" + row.IdCedula + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            swal('Eliminado!', 'El estudiante ' + row.Nombre + ' ha sido eliminado','success')
                        }
                    });
                }
            })
        }
    };

    $table.bootstrapTable({
        toolbar: ".toolbar",
        clickToSelect: true,
        showRefresh: false,
        search: true,
        showToggle: true,
        showColumns: true,
        pagination: true,
        searchAlign: 'left',
        pageSize: 8,
        clickToSelect: false,
        pageList: [8, 10, 25, 50, 100],

        formatShowingRows: function (pageFrom, pageTo, totalRows) {
            //do nothing here, we don't want to show the text "showing x of y from..."
        },
        formatRecordsPerPage: function (pageNumber) {
            return pageNumber + " rows visible";
        },
        icons: {
            refresh: 'fa fa-refresh',
            toggle: 'fa fa-th-list',
            columns: 'fa fa-columns',
            detailOpen: 'fa fa-plus-circle',
            detailClose: 'fa fa-close'
        }
    });

    //activate the tooltips after the data table is initialized
    $('[rel="tooltip"]').tooltip();

    $(window).resize(function () {
        $table.bootstrapTable('resetView');
    });
});

function UpdateUser() {
    var FirstName = document.getElementById("E_txtFirstName").value;
    var LastName = document.getElementById("E_txtLastName").value;
    var Email = document.getElementById("E_txtEmail").value;
    var IdCard = document.getElementById("E_txtIdCard").value;
    var Role = document.getElementById("E_ddlRole").value;
    var Telephone = document.getElementById("E_txtTelephone").value;
    // Photo
    var Photo = document.getElementById('E_Photo').files;
    var FileName = Photo.name;
    //var FileStream = Photo.binArray();

    $.ajax({
        type: "POST",
        url: "UsersConfig.aspx/EditUser",
        data: "{'FirstName' : '" + FirstName + "','LastName' : '" + LastName + "','Email' : '" + Email + "','IdCard' : '" + IdCard + "','Role' : '" + Role + "','Telephone' : '" + Telephone + "','FileName' : '" + FileName + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            swal({
                position: 'center',
                type: 'success',
                title: 'La información del usuario se ha actualizado.',
                showConfirmButton: false,
                timer: 5000
            })
            setTimeout(function () { window.location.reload(); }, 5000);
        }
    });
}

function IngresarEstudiante() {
    // Estudiante
    var E_Cedula = document.getElementById("C_txtIdCedula").value;
    var E_Nombre = document.getElementById("C_txtNombre").value;
    var E_Apellidos = document.getElementById("C_txtApellidos").value;
    var E_Telefono = document.getElementById("C_txtTelefono").value;
    var E_Email = document.getElementById("C_txtEmail").value;
    var E_Direccion = document.getElementById("C_txtDireccion").value;
    
    var E_Padecimientos = document.getElementById("C_txtPadecimientos").value;
    var E_Grado = document.getElementById("ddlNivel").value;
    var E_Adelanta = document.getElementById("ddlAdelanta").value;
    var E_GradoAdelanta = document.getElementById("ddlNivelAdelanta_").value;

    // Encargado

    var EN_Cedula = document.getElementById("C_txtIdCedulaEnc").value;
    var EN_Nombre = document.getElementById("C_txtNombreEnc").value;
    var EN_Apellidos = document.getElementById("C_txtApellidosEnc").value;
    var EN_TelRes = document.getElementById("C_txtTelefonoRes").value;
    var EN_TelTra = document.getElementById("C_txtTelefonoTra").value;
    var EN_TelMov = document.getElementById("C_txtTelefonoMov").value;

    var EN_Parentesco = document.getElementById("ddlParentesco").value;
    var EN_LugarTra = document.getElementById("C_txtLugar").value;
    var EN_Ocupacion = document.getElementById("C_txtOcupacion").value;

    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/IngresarEstudiante",
        data: "{'E_Cedula' : '" + E_Cedula + "','E_Nombre' : '" + E_Nombre + "','E_Apellidos' : '" + E_Apellidos + "','E_Telefono' : '" + E_Telefono + "','E_Email' : '" + E_Email + "','E_Direccion' : '" + E_Direccion + "','E_Padecimientos' : '" + E_Padecimientos + "','E_Grado' : '" + E_Grado + "','E_Adelanta' : '" + E_Adelanta + "','E_GradoAdelanta' : '" + E_GradoAdelanta + "','EN_Cedula' : '" + EN_Cedula + "','EN_Nombre' : '" + EN_Nombre + "','EN_Apellidos' : '" + EN_Apellidos + "','EN_TelRes' : '" + EN_TelRes + "','EN_TelTra' : '" + EN_TelTra + "','EN_TelMov' : '" + EN_TelMov + "','EN_Parentesco' : '" + EN_Parentesco + "','EN_LugarTra' : '" + EN_LugarTra + "','EN_Ocupacion' : '" + EN_Ocupacion + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("hola")
        },
        error: function (response) {
            alert("nel")
        }
    });
}

function ActualizarEstudiante() {
    // Estudiante
    var Cedula = document.getElementById("U_txtCedula").value;
    var Nombre = document.getElementById("U_txtNombre").value;
    var Apellidos = document.getElementById("U_txtApellidos").value;
    var Telefono = document.getElementById("U_txtTelefono").value;
    var Email = document.getElementById("U_txtEmail").value;
    var Graduado = document.getElementById("ddlGraduado").value;
    var Abandono = document.getElementById("ddlAbandono").value;
    var AnoGraduacion = document.getElementById("U_txtAnoGraduacion").value;
    var Grado = document.getElementById("ddlGrado").value;
    var Seccion = document.getElementById("U_txtSeccion").value;
    var Adelanta = document.getElementById("ddlNivelAdelanta_").value;
    var Padecimientos = document.getElementById("U_txtPadecimientos").value;
    var Direccion = document.getElementById("U_txtDireccion").value;

    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/ActualizarEstudiante",                                                                                                                                                                                                                                                      
        data: "{'Cedula' : '" + Cedula + "','Nombre' : '" + Nombre + "','Apellidos' : '" + Apellidos + "','Telefono' : '" + Telefono + "','Email' : '" + Email + "','Graduado' : '" + Graduado + "','Abandono' : '" + Abandono + "','AnoGraduacion' : '" + AnoGraduacion + "','Grado' : '" + Grado + "','Seccion' : '" + Seccion + "','Adelanta' : '" + Adelanta + "','Padecimientos' : '" + Padecimientos + "','Direccion' : '" + Direccion + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("hola")
        },
        error: function (response) {
            alert("nel")
        }
    });
}


