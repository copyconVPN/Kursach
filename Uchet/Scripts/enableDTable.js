$(document).ready(function () {
    var table = $('table.display').DataTable(
        {
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Russian.json"
        }, "scrollX": true,
        "deferRender": true,
        stateSave: true   
    });

    // Event listener to the two range filtering inputs to redraw on input
    $('#List').change(function () {
        table.draw();
    });
});


