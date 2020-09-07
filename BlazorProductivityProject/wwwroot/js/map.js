(function () {
    window.map = {
        show: function (zoom, lat, lng) {
            var app = new Mapp({
                element: '#map',
                presets: {
                    latlng: {
                        lat: lat,
                        lng: lng,
                    },
                    zoom: zoom,
                },
                apiKey: 'eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjhlODA0NTJlZDNlOTVmM2Y3NGNiOGE5OGI0NzMxMjQ1YTQ5YzQ2YTc1ZTBiYWU3NDI1ODYxYTNlMWI3MGJiZjI2Mjg0NjYxOTNlMDQwYmM1In0.eyJhdWQiOiIxMDIzMCIsImp0aSI6IjhlODA0NTJlZDNlOTVmM2Y3NGNiOGE5OGI0NzMxMjQ1YTQ5YzQ2YTc1ZTBiYWU3NDI1ODYxYTNlMWI3MGJiZjI2Mjg0NjYxOTNlMDQwYmM1IiwiaWF0IjoxNTk1NzQ4MTgzLCJuYmYiOjE1OTU3NDgxODMsImV4cCI6MTU5ODM0MDE4Mywic3ViIjoiIiwic2NvcGVzIjpbImJhc2ljIl19.llKLy3sbQasxKVPtCKazY-z2iZ-58rZn75M5PtCFYIEndIfT6RYCNdLk05YaczrElIpwERNDb-wz1NA0Ev-rSWMtxx_YdsGTgvGb5QH9eAMX_oRMjnxIndIpXPoTnAMupa20zNZK79fakqvHL3ke8Oo_IQUAGMpnkj_xJgsEdyJz6X3_zkdal44GHZ37J37GqYsiQ9OkUaW-vPcLQS2jAXWpiotbZVwRyp23KGh22jyPT77TI2Q1HefKoy4jXcDdlPpggjRQfiwR2chSZHBL4BQ7Zodi2jbRtU2U3G2Kpp3JeIMXP2VPYVV1iAjplOpRqLYQfAMRrlPv1AJpjSVHZA'
            });
            app.addLayers();
            //app.addFullscreen();
            app.addGeolocation();

            // Add in a crosshair for the map
            var crosshairIcon = {

                iconUrl: '/images/icon-marker.svg',
                //iconUrl: '/images/crosshair.png',
                iconSize: [50, 50], // size of the icon
                iconAnchor: [10, 10], // point of the icon which will correspond to marker's location
            };
            var marker = app.addMarker({
                latlng: {
                    lat: lat,
                    lng: lng,
                },
                draggable: false,
                icon: crosshairIcon,
                //popup: {
                //    title: {
                //        html: '<p style="margin-right:66px;">بانی تجارت آریانا</p>',
                //    },
                //    description: {
                //        html: '<br/><span>تهران، خیابان حبیب اللهی، بلوار شهید تیموری، جنب مترو دانشگاه شریف، پلاک 135، واحد 1</span>',
                //    },
                //    open: false,
                //},
                popup: false
            });
        }
    };
})();
