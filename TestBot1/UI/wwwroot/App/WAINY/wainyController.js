wainy.controller('wainyController', ["$scope", function ($scope) {

    var dl = window.WebChat.createDirectLine({ secret: 'iw7ShoDKqAc.PKY37Kz2idm1IAxfPZ4CmE5N_NpMMbgHB7Wrbn2K9eg' });
    var botContainer = document.getElementById('webchat');
    var activity;
    const styleOptions = {
        // Color options
    };
    window.WebChat.renderWebChat({ directLine: dl, styleOptions }, botContainer);

    activity = {
        from: {
            id: 'user',
            name: 'user'
        },
        name: 'greetings',
        type: 'event',
        value: ''
    };
    dl.postActivity(activity).subscribe(function (id) {
        if (console) {
            console.log('"trigger requestWelcomeDialog" sent');
        }
    });
}]);