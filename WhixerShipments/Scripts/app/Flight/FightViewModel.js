$.ajax({
    url: http://localhost/WhixerShipments/WhixerShipmentsApi/Flight/Ping,
    type: "GET",
    dataType: "json",
    success: function (data) {
        console.log("Llego este valor: " + data);
    }
});