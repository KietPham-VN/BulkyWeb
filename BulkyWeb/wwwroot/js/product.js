$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/product/getall",
        },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'isbn', "width": "15%" },
            { data: 'listPrice', "width": "15%" },
            { data: 'author', "width": "15%" },
            { data: 'category.name', "width": "10%" }

        ]
    });
}