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
                url: "UsersConfig.aspx/VerUsuario",
                data: "{'Usuario' : '" + row.Usuario + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("D_txtNombre").value = res[0];
                    document.getElementById("D_txtApellidos").value = res[1]
                    document.getElementById("D_txtEmail").value = res[2];
                    document.getElementById("D_txtCedula").value = res[3];
                    document.getElementById("D_txtRol").value = res[4];
                    document.getElementById("D_txtTelefono").value = res[5];
                    document.getElementById("D_Foto").src = res[6];

                    $("#VerUsuario").modal("show")
                }
            });
        },
        'click .edit': function (e, value, row, index) {
            info = JSON.stringify(row);

            $.ajax({
                type: "POST",
                url: "UsersConfig.aspx/VerUsuario",
                data: "{'Usuario' : '" + row.Usuario + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    document.getElementById("E_txtNombre").value = res[0];
                    document.getElementById("E_txtApellidos").value = res[1]
                    document.getElementById("E_txtEmail").value = res[2];
                    document.getElementById("E_txtCedula").value = res[3];
                    if (res[4] == "Administrador") {
                        document.getElementById("E_ddlRole").selectedIndex = 1;
                    }
                    else {
                        document.getElementById("E_ddlRole").selectedIndex = 2;
                    }
                    document.getElementById("E_txtTelefono").value = res[5];
                    document.getElementById("E_Foto").src = res[6];

                    $("#EditarUsuario").modal("show")
                }
            });
        },
        'click .remove': function (e, value, row, index) {
            swal({
                title: 'Esta seguro?',
                text: "El usuario " + row.Usuario + " sera eliminado",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#21354c',
                confirmButtonText: "Si, eliminar usuario",
                cancelButtonText: "Cancelar",
            }).then((result) => {
                if (result.value = true) {
                    $.ajax({
                        type: "POST",
                        url: "UsersConfig.aspx/EliminarUsuario",
                        data: "{'Usuario' : '" + row.Usuario + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            if (response.d == false) {
                                swal('Oops...',
                                    'No se puede eliminar el único usuario existente en el sistema',
                                    'error'
                                    )
                            }
                            else if (response.d == true) {
                                $table.bootstrapTable('remove', {
                                    field: 'Usuario',
                                    values: [row.Usuario]
                                });

                                swal(
                                  'Usuario eliminado!',
                                  'El usuario ' + row.Usuario + ' ha sido eliminado.',
                                  'success'
                                )
                            }
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

function CrearUsuario() {
    var Nombre = document.getElementById("C_txtNombre").value;
    var Apellidos = document.getElementById("C_txtApellidos").value;
    var Email = document.getElementById("C_txtEmail").value;
    var Cedula = document.getElementById("C_txtCedula").value;
    var Rol = document.getElementById("C_ddlRol").value;
    var Telefono = document.getElementById("C_txtTelefono").value;

    $.ajax({
        type: "POST",
        url: "UsersConfig.aspx/CrearUsuario",
        data: "{'Nombre' : '" + Nombre + "','Apellidos' : '" + Apellidos + "','Email' : '" + Email + "','Cedula' : '" + Cedula + "','Rol' : '" + Rol + "','Telefono' : '" + Telefono + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {

        }
    });
}


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
