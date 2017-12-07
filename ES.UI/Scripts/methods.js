



function CrearUsuario() {
    var Nombre = document.getElementById("C_txtNombre").value;
    var Apellidos = document.getElementById("C_txtApellidos").value;
    var Cedula = document.getElementById("C_txtCedula").value;
    var Rol = $("#ddl_Rol option:selected").text();
    var Email = document.getElementById("C_txtEmail").value;
    var Telefono = document.getElementById("C_txtTelefono").value;

    // Foto
    var fileInput = document.getElementById("C_Foto");
    var files = fileInput.files;
    var accept = {
        binary: ["image/png", "image/jpeg"],
        text: ["text/plain", "text/css", "application/xml", "text/html"]
    };

    var file;
    for (var i = 0; i < files.length; i++) {
        file = files[i];

        // if file type could be detected
        if (file !== null) {
            if (accept.binary.indexOf(file.type) > -1) {
                // file is a binary, which we accept
                var data = file.getAsBinary();
            } else if (accept.text.indexOf(file.type) > -1) {
                // file is of type text, which we accept
                var data = file.getAsText();
                // modify data with string methods
            }
        }
    }

    alert("la verga pariente :v");

    
    /*   $.ajax({
           type: "POST",
           url: "SearchPanel.aspx/CreatePanel",
           data: "{'IdPanel' : '" + IdPanel + "','Model' : '" + Model + "','Description' : '" + Description + "','Bus' : '" + Bus + "','Main' : '" + Main + "','Area' : '" + Area + "','From' : '" + From + "','Voltage' : '" + Voltage + "','Phases' : '" + Phases + "','Threads' : '" + Threads + "','Frequency' : '" + Frequency + "','Comments' : '" + Comments + "'}",
           contentType: "application/json; charset=utf-8",
           dataType: "json",
           success: function (response) {
               if (response.d == false) {
                   swal({
                       position: 'center',
                       type: 'success',
                       title: 'El panel ' + IdPanel + ' se ha creado correctamente!',
                       showConfirmButton: false,
                       timer: 5000
                   })
   
                   setTimeout(function () { window.location.reload(); }, 5000);
               }
               else if (response.d == true) {
                   swal('Error', 'El panel ' + IdPanel + ' ya se encuentra en el sistema!', 'error')
               }
           }
       });*/
}