$(document).ready(function () {


    var map;
    function initMap() {
        map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: 32.7357, lng: 97.1081 },
            zoom: 8
        });
    }
});