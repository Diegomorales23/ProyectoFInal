var $table = $('#bootstrap-table');

function operateFormatter(value, row, index) {
    return [
        '<div class="table-icons">',
            '<a rel="tooltip" title="Editar" class="btn btn-simple btn-warning btn-icon table-action edit" href="javascript:void(0)">',
                '<i class="fa fa-pencil"></i>',
            '</a>',
        '</div>',
    ].join('');
}
var ID = "";
$().ready(function () {
    window.operateEvents = {
        'click .edit': function (e, value, row, index) {
            info = JSON.stringify(row);

            $.ajax({
                type: "POST",
                url: "VerNotas.aspx/GetInfo",
                data: "{'Id' : '" + row.Id + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var res = response.d

                    ID = res[0].ID;

                    document.getElementById("txtNombre").value = res[0].NOMBRE
                    document.getElementById("txtApellidos").value = res[0].APELLIDOS
                    document.getElementById("txtSeccion").value = res[0].SECCION
                    document.getElementById("txtIP").value = res[0].IP
                    document.getElementById("txtIIP").value = res[0].IIP
                    document.getElementById("txtIIIP").value = res[0].IIIP
                    document.getElementById("txtMateria").value = res[0].MATERIA

                    $("#Edit").modal("show");
                }
            });
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

function Actualizar() {
    var IP = document.getElementById("txtIP").value
    var IIP = document.getElementById("txtIIP").value
    var IIIP = document.getElementById("txtIIIP").value
    
    $.ajax({
        type: "POST",
        url: "VerNotas.aspx/Actualizar",
        data: "{'Id' : '" + ID + "','IP' : '" + IP + "','IIP' : '" + IIP + "','IIIP' : '" + IIIP + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            swal({
                position: 'center',
                type: 'success',
                title: 'Actualizado',
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
