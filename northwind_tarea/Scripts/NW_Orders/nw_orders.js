$('#orderDetails').click(function(e) {
    var order_id = this.getAttribute("OrderID");
    var modalOD = $(".orderDetailsModal");
    var modalOrdenCompra = $(".modal-body");

    $.ajax({
        type: "GET",
        url: "/Orders/OrdersDetailsPV",
        data: { id: order_id },
        error: function() {
            alert("No funciono :'(");
        },
        success: function (result) {
            modalOD.modal();
            modalOrdenCompra.html(result);
        }
    });
});

