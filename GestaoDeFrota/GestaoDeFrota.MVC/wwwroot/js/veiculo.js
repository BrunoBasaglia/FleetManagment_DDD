$('#Fabricante').on('change', function () {
    var DropFabricantes = $(this).val();
    var DropModelos = $('#Modelo');
    DropModelos.empty();
    $.ajax({
        type: "POST",
        url: "/Veiculos/Modelos/",
        data: { id: $(this).val() },
        dataType: "json",
        success: function (result) {
            if (DropFabricantes != 'Selecione') {
                DropModelos.removeAttr("disabled");
                DropModelos.append($('<option />', {
                    value: 0,
                    text: "Selecione"
                }));
                $.each(result, function (index, modelo) {
                    DropModelos.append($('<option />', {
                        value: modelo.id,
                        text: modelo.nome
                    }));
                });
            } else {
                DropModelos.append($('<option />', {
                    value: 0,
                    text: "Selecione"
                }));
            }
        }
    });
});


//$("#Placa").inputmask({ mask: ['AAA-9999', 'AAA9A99'] }, { removeMaskOnSubmit: true });



$("#Placa").inputmask('AAA-9999', { removeMaskOnSubmit: true });










