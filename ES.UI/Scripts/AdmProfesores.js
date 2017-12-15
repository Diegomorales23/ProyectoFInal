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
                url: "AdmProfesores.aspx/GetInfo",
                data: "{'Id' : '" + row.Id + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("D_txtCedula").value = res[0].ID_PROFESOR;
                    document.getElementById("D_txtNombre").value = res[0].NOMBRE
                    document.getElementById("D_txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("D_txtTelefono").value = res[0].TELEFONO
                    document.getElementById("D_txtEmail").value = res[0].EMAIL
                    document.getElementById("D_txtPadecimientos").value = res[0].PADECIMIENTOS
                    document.getElementById("D_txtDireccion").value = res[0].DIRECCION

                    $("#Details").modal("show");
                }
            });
        },
        'click .edit': function (e, value, row, index) {
            info = JSON.stringify(row);

            $.ajax({
                type: "POST",
                url: "AdmProfesores.aspx/GetInfo",
                data: "{'Id' : '" + row.Id + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("U_txtCedula").value = res[0].ID_PROFESOR;
                    document.getElementById("U_txtNombre").value = res[0].NOMBRE
                    document.getElementById("U_txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("U_txtTelefono").value = res[0].TELEFONO
                    document.getElementById("U_txtEmail").value = res[0].EMAIL
                    document.getElementById("U_txtPadecimientos").value = res[0].PADECIMIENTOS
                    document.getElementById("U_txtDireccion").value = res[0].DIRECCION

                    $("#Update").modal("show");
                }
            });
        },
        'click .remove': function (e, value, row, index) {
            swal({
                title: '¿Esta seguro?',
                text: "El profesor " + row.Nombre + " sera eliminado",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#21354c',
                confirmButtonText: "Si, eliminar profesor",
                cancelButtonText: "Cancelar",
            }).then((result) => {
                if (result.value = true) {
                    $.ajax({
                        type: "POST",
                        url: "AdmProfesores.aspx/Eliminar",
                        data: "{'Id' : '" + row.Id + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            swal('Eliminado!', 'El profesor ' + row.Nombre + ' ha sido eliminado', 'success')
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

function IngresarProfesor() {
    var P_Cedula = document.getElementById("I_txtCedula").value;
    var P_Nombre = document.getElementById("I_txtNombre").value;
    var P_Apellidos = document.getElementById("I_txtApellidos").value;
    var P_Telefono = document.getElementById("I_txtTelefono").value;
    var P_Email = document.getElementById("I_txtEmail").value;
    var P_Padecimientos = document.getElementById("I_txtPadecimientos").value;
    var P_Direccion = document.getElementById("I_txtDireccion").value;

    $.ajax({
        type: "POST",
        url: "AdmProfesores.aspx/Insertar",
        data: "{'P_Cedula' : '" + P_Cedula + "','P_Nombre' : '" + P_Nombre + "','P_Apellidos' : '" + P_Apellidos + "','P_Telefono' : '" + P_Telefono + "','P_Email' : '" + P_Email + "','P_Padecimientos' : '" + P_Padecimientos + "','P_Direccion' : '" + P_Direccion + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            swal({
                position: 'center',
                type: 'success',
                title: 'El profesor ' + P_Nombre + ' ' + P_Apellidos + ' ha sido registrado!',
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
                title: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: false,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });

    setTimeout(function () { window.location.reload(); }, 2000);
}

function ActualizarProfesor() {
    var P_Cedula = document.getElementById("U_txtCedula").value;
    var P_Nombre = document.getElementById("U_txtNombre").value;
    var P_Apellidos = document.getElementById("U_txtApellidos").value;
    var P_Telefono = document.getElementById("U_txtTelefono").value;
    var P_Email = document.getElementById("U_txtEmail").value;
    var P_Padecimientos = document.getElementById("U_txtPadecimientos").value;
    var P_Direccion = document.getElementById("U_txtDireccion").value;

    $.ajax({
        type: "POST",
        url: "AdmProfesores.aspx/Actualizar",
        data: "{'P_Cedula' : '" + P_Cedula + "','P_Nombre' : '" + P_Nombre + "','P_Apellidos' : '" + P_Apellidos + "','P_Telefono' : '" + P_Telefono + "','P_Email' : '" + P_Email + "','P_Padecimientos' : '" + P_Padecimientos + "','P_Direccion' : '" + P_Direccion + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            swal({position: 'center',
                type: 'success',
                title: 'Los datos del profesor(a) ' + P_Nombre + ' ' + P_Apellidos + ' han sido actualizados!',
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
                title: 'Algo salio mal, si el problema persiste contacte al administrador',
                showConfirmButton: false,
                allowOutsideClick: false,
                allowEscapeKey: false,
                allowEnterKey: false
            })
        }
    });

    setTimeout(function () { window.location.reload(); }, 2000);
}