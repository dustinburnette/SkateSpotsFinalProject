$('#searchForm').on('submit', function (event) {
    event.preventDefault();

    var search = {
        Term: $('#searchInput').val()
    }

    $.ajax({
        type: 'POST',
        url: '/api/searchapi',
        contentType: 'application/json',
        data: JSON.stringify(search),
        dataType: 'json'
    }).done(function (data) {

        console.log(markers);

        for (var i = 0; i < markers.length; i++) {
            markers[i].setMap(null);
        }

        markers = [];


        for (var i = 0; i < data.length; i++) {
            var position = { lat: data[i].Lat, lng: data[i].Long };
            var title = data[i].ShortDescription;
            var iwindow = data[i].Description;
            var marker = new google.maps.Marker({
                map: map,
                position: position,
                title: title,
                iwindow: iwindow,
                animation: google.maps.Animation.DROP,
                id: data[i].SkateSpotID
            });

            markers.push(marker);

            marker.addListener('click', function () {
                console.log(this);
                var largeInfowindow = new google.maps.InfoWindow();
                populateInfoWindow(this, largeInfowindow);

            });
        }
    })
});