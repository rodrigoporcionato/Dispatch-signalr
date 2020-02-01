window.onload = function () {



    //var connection = $.hubConnection("https://localhost:44337");
    
    
    //connection.qs = { 'UserId': '35' };

    //var notificationHub = connection.NotificationHub;

    //notificationHub.client.notify = function (userName, message) {
    //    console.log(userName + ' ' + message);
    //}

    //connection.start()
    //    .done(function () {
    //        console.log('connected');
    //        //connection.send("success?");
    //    })
    //    .fail(function (a) {
    //        console.log('not connected' + a);
    //    });


    jQuery.support.cors = true;    

    var user = $('#user-login').val();
    var connection = $.hubConnection("https://localhost:44337");
    connection.qs = {'userName': user};

    var hub = connection.createHubProxy('NotificationHub');

    hub.on('NewDispatch', function (userName, message) {
        console.log(userName + ' ' + message);
    });

    connection.logging = true;

    connection.start().done(function () {
        console.log('Now connected, connection ID=' + connection.id);
        console.log(connection);
    })
    .fail(function (a) {
        console.log('Could not connect' + a);
    });

}