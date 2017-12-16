function Llenar() {
    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/GetSecciones",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var res = response.d;
            for (var i = 0; i < res.length ; i++) {
                $('#ddlSecciones').append('<option value="' + res[i].ID_SECCION + '">' + res[i].ID_SECCION + '</option>');
            }
        },
        error: function (response) {
            swal({
                position: 'center',
                type: 'error',
                title: 'Oops...',
                text: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: true,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });    

    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/GetNiveles",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var res = response.d;
            for (var i = 0; i < res.length ; i++) {
                $('#ddlNiveles').append('<option value="' + res[i].ID_NIVEL + '">' + res[i].NOMBRE.substring(0, 1).toUpperCase() + res[i].NOMBRE.substring(1, (res[i].NOMBRE.length)).toLowerCase() + '</option>');
            }
        },
        error: function (response) {
            swal({
                position: 'center',
                type: 'error',
                title: 'Oops...',
                text: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: true,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });

    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/GetParentesco",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var res = response.d;
            for (var i = 0; i < res.length ; i++) {
                $('#ddlParentesco').append('<option value="' + res[i].ID_PARENTESCO + '">' + res[i].NOMBRE.substring(0, 1).toUpperCase() + res[i].NOMBRE.substring(1, (res[i].NOMBRE.length)).toLowerCase() + '</option>');
            }
        },
        error: function (response) {
            swal({
                position: 'center',
                type: 'error',
                title: 'Oops...',
                text: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: true,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });
}

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
                url: "AdmEstudiantes.aspx/GetInfo",
                data: "{'Id' : '" + row.Id + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("V_txtCedula").value = res[0].ID_ESTUDIANTE;
                    document.getElementById("V_txtNombre").value = res[0].NOMBRE
                    document.getElementById("V_txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("V_txtTelefono").value = res[0].TELEFONO
                    document.getElementById("V_txtEmail").value = res[0].EMAIL
                    document.getElementById("V_txtAnoGraduacion").value = res[0].ANO_GRADUACION
                    document.getElementById("V_txtPadecimientos").value = res[0].PADECIMIENTOS
                    document.getElementById("V_txtDireccion").value = res[0].DIRECCION
                    document.getElementById("V_txtSeccion").value = res[0].ID_SECCION

                    $.ajax({
                        type: "POST",
                        url: "AdmEstudiantes.aspx/GetNiveles",
                        data: "{}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            var res_ = response.d;
                            for (var i = 0; i < res_.length ; i++) {
                                if (res_[i].ID_NIVEL == res[0].ID_NIVEL) {
                                    document.getElementById("V_txtGrado").value = res_[i].NOMBRE.substring(0, 1).toUpperCase() + res_[i].NOMBRE.substring(1, (res_[i].NOMBRE.length)).toLowerCase()
                                }
                            }
                        },
                        error: function (response) {
                            swal({
                                position: 'center',
                                type: 'error',
                                title: 'Oops...',
                                text: 'Algo salio mal, si el problema persiste contacte al administrador',
                                showConfirmButton: true,
                                allowOutsideClick: false,
                                allowEscapeKey: false,
                                allowEnterKey: false
                            })
                        }
                    });

                    if (res[0].ABANDONO == true) {
                        document.getElementById("V_txtAbandono").value = "Si"
                    }
                    else {
                        document.getElementById("V_txtAbandono").value = "No"
                    }

                    if (res[0].GRADUADO == true) {
                        document.getElementById("V_txtGraduado").value = "Si"
                    }
                    else {
                        document.getElementById("V_txtGraduado").value = "No"
                    }

                    $("#Details").modal("show");
                }
            });
        },
        'click .edit': function (e, value, row, index) {
            info = JSON.stringify(row);

            $.ajax({
                type: "POST",
                url: "AdmEstudiantes.aspx/GetNiveles",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d;
                    for (var i = 0; i < res.length ; i++) {
                        $('#ddlGrado').append('<option value="' + res[i].ID_NIVEL + '">' + res[i].NOMBRE.substring(0, 1).toUpperCase() + res[i].NOMBRE.substring(1, (res[i].NOMBRE.length)).toLowerCase() + '</option>');
                    }
                },
                error: function (response) {
                    swal({
                        position: 'center',
                        type: 'error',
                        title: 'Oops...',
                        text: 'Algo salio mal, si el problema persiste contacte al administrador',
                        showConfirmButton: true,
                        allowOutsideClick: false,
                        allowEscapeKey: false,
                        allowEnterKey: false
                    })
                }
            });

            $.ajax({
                type: "POST",
                url: "AdmEstudiantes.aspx/GetSecciones",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d;
                    for (var i = 0; i < res.length ; i++) {
                        $('#ddlSeccion').append('<option value="' + res[i].ID_SECCION + '">' + res[i].ID_SECCION + '</option>');
                    }
                },
                error: function (response) {
                    swal({
                        position: 'center',
                        type: 'error',
                        title: 'Oops...',
                        text: 'Algo salio mal, si el problema persiste contacte al administrador',
                        showConfirmButton: true,
                        allowOutsideClick: false,
                        allowEscapeKey: false,
                        allowEnterKey: false
                    })
                }
            });

            $.ajax({
                type: "POST",
                url: "AdmEstudiantes.aspx/GetInfo",
                data: "{'Id' : '" + row.Id + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("U_txtCedula").value = res[0].ID_ESTUDIANTE;
                    document.getElementById("U_txtNombre").value = res[0].NOMBRE
                    document.getElementById("U_txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("U_txtTelefono").value = res[0].TELEFONO
                    document.getElementById("U_txtEmail").value = res[0].EMAIL

                    $('#ddlGrado').val(res[0].ID_NIVEL);
                    $('#ddlSeccion').val(res[0].ID_SECCION);

                    if (res[0].ABANDONO == false) {
                        $('#ddlAbandono').val(1);
                    } else {
                        $('#ddlAbandono').val(2);
                    }

                    document.getElementById("U_txtAnoGraduacion").value = res[0].ANO_GRADUACION

                    if (res[0].GRADUADO == false) {
                        $('#ddlGraduado').val(1);
                    } else {
                        $('#ddlGraduado').val(2);
                    }

                    document.getElementById("U_txtDireccion").value = res[0].DIRECCION
                    document.getElementById("U_txtPadecimientos").value = res[0].PADECIMIENTOS

                    $("#Edit").modal("show");
                }
            });
        },
        'click .remove': function (e, value, row, index) {
            swal({
                title: '¿Esta seguro?',
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
                        url: "AdmEstudiantes.aspx/Eliminar",
                        data: "{'Id' : '" + row.Id + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            swal('Eliminado!', 'El estudiante ' + row.Nombre + ' ha sido eliminado', 'success')
                            $table.bootstrapTable('remove', {
                                field: 'Id',
                                values: [row.Id]
                            });
                        },
                        error: function (response) {
                            swal('Oops...', 'Algo salio mal, si el problema persiste contacte al administrador', 'error')
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

function Ingresar() {
    var E_Cedula = document.getElementById("C_txtIdCedula").value;
    var E_Nombre = document.getElementById("C_txtNombre").value;
    var E_Apellidos = document.getElementById("C_txtApellidos").value;
    var E_Telefono = document.getElementById("C_txtTelefono").value;
    var E_Email = document.getElementById("C_txtEmail").value;
    var E_Direccion = document.getElementById("C_txtDireccion").value;
    var E_Padecimientos = document.getElementById("C_txtPadecimientos").value;
    var E_Nivel = document.getElementById("ddlNiveles").value;
    var E_Seccion = document.getElementById("ddlSecciones").value;

    var EN_Cedula = document.getElementById("C_txtIdCedulaEnc").value;
    var EN_Nombre = document.getElementById("C_txtNombreEnc").value;
    var EN_Apellidos = document.getElementById("C_txtApellidosEnc").value;
    var EN_Email = document.getElementById("C_txtEmailEnc").value;
    var EN_TelefonoRes = document.getElementById("C_txtTelefonoRes").value;
    var EN_TelefonoTra = document.getElementById("C_txtTelefonoTra").value;
    var EN_TelefonoMov = document.getElementById("C_txtTelefonoMov").value;
    var EN_Direccion = document.getElementById("C_txtDireccionEnc").value;
    var EN_Parentesco = document.getElementById("ddlParentesco").value;
    var EN_Lugar = document.getElementById("C_txtLugar").value;
    var EN_Ocupacion = document.getElementById("C_txtOcupacion").value;

    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/Ingresar",
        data: "{'E_Cedula' : '" + E_Cedula + "','E_Nombre' : '" + E_Nombre + "','E_Apellidos' : '" + E_Apellidos + "','E_Telefono' : '" + E_Telefono + "','E_Email' : '" + E_Email + "','E_Direccion' : '" + E_Direccion + "','E_Padecimientos' : '" + E_Padecimientos + "','E_Nivel' : '" + E_Nivel + "','E_Seccion' : '" + E_Seccion + "','EN_Cedula' : '" + EN_Cedula + "','EN_Nombre' : '" + EN_Nombre + "','EN_Apellidos' : '" + EN_Apellidos + "','EN_Email' : '" + EN_Email + "','EN_TelefonoRes' : '" + EN_TelefonoRes + "','EN_TelefonoTra' : '" + EN_TelefonoTra + "','EN_TelefonoMov' : '" + EN_TelefonoMov + "','EN_Direccion' : '" + EN_Direccion + "','EN_Parentesco' : '" + EN_Parentesco + "','EN_Lugar' : '" + EN_Lugar + "','EN_Ocupacion' : '" + EN_Ocupacion + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            swal({
                position: 'center',
                type: 'success',
                title: 'Registrado',
                text: 'El estudiante ' + E_Nombre + ' ' + E_Apellidos + ' ha sido registrado!',
                showConfirmButton: false,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        },
        error: function (response) {
            swal({
                position: 'center',
                type: 'error',
                title: 'Oops...',
                text: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: false,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });

    setTimeout(function () { window.location.reload(); }, 2000);
}

function Actualizar() {
    var U_Cedula = document.getElementById("U_txtCedula").value;
    var U_Nombre = document.getElementById("U_txtNombre").value;
    var U_Apellidos = document.getElementById("U_txtApellidos").value;
    var U_Telefono = document.getElementById("U_txtTelefono").value;
    var U_Email = document.getElementById("U_txtEmail").value;
    var U_Grado = document.getElementById("ddlGrado").value;
    var U_Seccion = document.getElementById("ddlSeccion").value;
    var U_Abandono = document.getElementById("ddlAbandono").value;
    var U_Graduado = document.getElementById("ddlGraduado").value;
    var U_AnoGraduacion = document.getElementById("U_txtAnoGraduacion").value;
    var U_Direccion = document.getElementById("U_txtDireccion").value;
    var U_Padecimientos = document.getElementById("U_txtPadecimientos").value;
    
    $.ajax({
        type: "POST",
        url: "AdmEstudiantes.aspx/Actualizar",
        data: "{'U_Cedula' : '" + U_Cedula + "','U_Nombre' : '" + U_Nombre + "','U_Apellidos' : '" + U_Apellidos + "','U_Telefono' : '" + U_Telefono + "','U_Email' : '" + U_Email + "','U_Grado' : '" + U_Grado + "','U_Seccion' : '" + U_Seccion + "','U_Abandono' : '" + U_Abandono + "','U_Graduado' : '" + U_Graduado + "','U_AnoGraduacion' : '" + U_AnoGraduacion + "','U_Direccion' : '" + U_Direccion + "','U_Padecimientos' : '" + U_Padecimientos + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            swal({
                position: 'center',
                type: 'success',
                title: 'Actualizado',
                text: 'El estudiante ' + U_Nombre + ' ' + U_Apellidos + ' ha sido actualizado!',
                showConfirmButton: false,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        },
        error: function (response) {
            swal({
                position: 'center',
                type: 'error',
                title: 'Oops...',
                text: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: false,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });

    setTimeout(function () { window.location.reload(); }, 2000);
}
