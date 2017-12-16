var $table = $('#bootstrap-table');

function operateFormatter(value, row, index) {
    return [
        '<div class="table-icons">',
            '<a rel="tooltip" title="Eliminar" class="btn btn-simple btn-danger btn-icon table-action remove" href="javascript:void(0)">',
                '<i class="fa fa-close"></i>',
            '</a>',
        '</div>',
    ].join('');
}

$().ready(function () {
    window.operateEvents = {
        'click .remove': function (e, value, row, index) {
            swal({
                title: '¿Esta seguro?',
                text: "El curso sera eliminado",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#21354c',
                confirmButtonText: "Si, eliminar curso",
                cancelButtonText: "Cancelar",
            }).then((result) => {
                if (result.value = true) {
                    $.ajax({
                        type: "POST",
                        url: "AdmCursos.aspx/Eliminar",
                        data: "{'Id' : '" + row.Id + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (response) {
                            swal('Eliminado!', 'El curso ha sido eliminado', 'success')
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
