$(document).ready(function () {

    $(document).on("click", ".show-product-modal", function (e) {
        e.preventDefault();

        var id = $(this).attr("data-id");

        fetch('https://localhost:44322/home/getbook/' + id)
            .then(response => response.text())
            .then(data => {
                

                $("#product-modal-detail").html(data)
            });
        // get data from controller

        //set data 

        $("#quickModal").modal("show")
    })

    $(document).on("click", ".single-btn", function (e) {
        e.preventDefault(); 
        var id = $(this).attr("data-id");

        fetch('https://localhost:44322/book/addbasket/' + id)
            .then(response => response.text())
            
            .then(data => {
                
                $('.cart-block').html(data);
            });
    });

    $(document).on("click", ".cross-btn", function (e) {
        e.preventDefault()

        var id = $(this).attr("data-id");

        fetch('https://localhost:44322/book/deletebook/' + id)
            .then(response => response.text())
            .then(data => {
                $('.cart-block').html(data);
            })  
    });

})




