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

    $(document).on("click", ".add-book-btn", function (e) {
        e.preventDefault(); 
        var id = $(this).attr("data-id");

        fetch('https://localhost:44322/book/addbasket/' + id)
            .then(response => response.text())
            
            .then(data => {
                
                $('.cart-block').html(data);
            });
    });

    $(document).on("click", ".add-book-btn2", function (e) {
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

    $(document).on("click", ".btn-outlined--primary", function (e) {
        e.preventDefault()
        var id = $(this).attr("data-id");
        fetch('https://localhost:44322/book/addbasket/' + id)
            .then(response => response.text())
            .then(data => {
                $('.cart-block').html(data);
            })
    })

   /* $(document).on("click", ".get-by-genre", function (e) {
        e.preventDefault()

        var id = $(this).attr("data-id");
        fetch('https://localhost:44322/book/filtergenre/' + id)
            .then(response => response.text())
            .then(data => {
                $('.shop-product-wrap').html(data);
            })
        
    })*/

    $(document).on("click", ".book-detail-btn", function (e) {
       var id = $(this).attr("data-id");
       fetch('https://localhost:44322/book/detail/' + id)
           .then(response => response.text())
           .then(data => {
               let modal = document.getElementById("modal-dialog");
               console.log(modal);
               $('#modal-dialog').html(data);
         })
    })

})




