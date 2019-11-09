//alert("Hola Mundo");

$('#orderDetails').click(function(e) {
    var order_id = this.getAttribute("OrderID");

    $.ajax({
        type: "GET",
        url: "/Orders/OrdersDetailsPV",
        data: { id: order_id },
        error: function () {
            alert("No funciono :'(");
        },
        success: function (result) {
            var divListadoOrdenCompra = $("#listadoOrdenCompra");

            if (divListadoOrdenCompra.children().length > 0) {
                divListadoOrdenCompra.toggle(function (e) {
                    $(this).html(result);
                });
            } else {
                divListadoOrdenCompra.html(result);
            }
        }
    });
});

