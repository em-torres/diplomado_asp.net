$('#orderDetails').click(function(e) {
    var order_id = this.getAttribute("OrderID");
    var divListadoOrdenCompra = $("#listadoOrdenCompra");

    if (divListadoOrdenCompra.children().length > 0) {
        divListadoOrdenCompra.toggle();
    } else {
        $.ajax({
            type: "GET",
            url: "/Orders/OrdersDetailsPV",
            data: { id: order_id },
            error: function() {
                alert("No funciono :'(");
            },
            success: function(result) {
                divListadoOrdenCompra.append(result);
            }
        });
    }
});

