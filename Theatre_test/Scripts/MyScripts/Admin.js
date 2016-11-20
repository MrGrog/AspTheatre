function setspectacle(Spectacle_name, Exposition_sp, Date_sp) {

    SendSpectacle(Spectacle_name, Exposition_sp, Date_sp);
}

function SendSpectacle(Spectacle_name, Exposition_sp, Date_sp) 
    {

    var dataValue = { "Spectacle_name": Spectacle_name, "Exposition_sp": Exposition_sp, "Date_sp": Date_sp };

    $.ajax({
        type: "POST",
        url: "Admin.aspx/AddSpectacleJS",
        data: dataValue,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
        },
        complete: function (jqXHR, status) {
            alert( "\n\nResponse: " + jqXHR.responseText);
        }
    });

}