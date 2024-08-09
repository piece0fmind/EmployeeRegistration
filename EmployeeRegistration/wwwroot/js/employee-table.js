$(document).ready(function () {

    loadEmployeeData();
    loadToastrOption();
    e.preventDefault();
        
});

var loadEmployeeData = function () {
    var table = $('#employee-table').dataTable({
        "bProcessing": true,
        "sPagination": true,
        "bAutoWidth": true,
        "destroy": true,
        "serverSide": true,
        //"responsive": true,
        "scrollX": false,
        "sAjaxSource": "/Employee/GetEmployees/",
        "sDom": 'T<"clear">lfr<"custom-wrapper"t>ip',
        
        "aoColumnDefs": [
            {
                "mData": null,
                "aTargets": [0],
                "bSortable": false,
                "bSearchable": false,
                "responsivePriority": 1
            },
            {
                "mData": 'Employee ID',
                "bSearchable": true,
                "bSortable": true,
                "aTargets": [1],
                "responsivePriority": 2
            },
            {
                "mData": 'Name',
                "bSearchable": true,
                "bSortable": true,
                "aTargets": [2],
                "responsivePriority": 3
            }
            
        ],
        "createdRow": function (row, data, index) {
            $('td', row).eq(0).html(index + 1);
        },
        
        "order": [[1, 'asc']]
    }).columnFilter({
        sPlaceHolder: "head:before"
    });
  

}
var loadToastrOption = function () {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "positionClass": "toast-bottom-right",
        "onclick": null,
        "fadeIn": 300,
        "fadeOut": 1000,
        "timeOut": 7000,
        "extendedTimeOut": 1000
    }
}
