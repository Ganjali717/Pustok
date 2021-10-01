$(document).ready(function () {
    $(document).on("click", ".btn-item-delete", function (e) {
        e.preventDefault();

        var url = $(this).attr("href");

        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {

            if (result.isConfirmed)
            {
                fetch(url)
                    .then(response => response.json())
                    .then(data => {
                        console.log(data)
                        if (data.status == 200) {
                            window.location.reload(true)
                        }
                        else {
                            console.log(data.status)
                            Swal.fire(
                                'Error!',
                                'Your file has not been deleted!',
                                'error'
                            )
                        }
                    })

            }
        })


    })



    $(document).on("click", ".remove-img-box", function (e) {
        e.preventDefault();
        $(this).parent().remove()
    })


   /* $('#demo').pagination({
        dataSource: [DataView.fetch(url)
            .then(response => response.text())
            .then(data => 
                $(".table").html(data))
        ],
        pageSize: 5,
        pageRange: null,
        showPageNumbers: true,
        formatResult: function (data) {
            for (var i = 0, len = data.length; i < len; i++) {
                data[i].a;
            }
        },
        callback: function (data, pagination) {
            // template method of yourself
            var html = template(data);
            dataContainer.html(html);
        }
    })*/

})
