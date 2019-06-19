wainy.controller('wainyController', ["$scope", function ($scope) {

    var dl = window.WebChat.createDirectLine({ secret: 'iw7ShoDKqAc.ZT0EYu2xXz8pACqVJ2k7jS8awsrZp9wx4v54YgwO0t4' });
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


/*function test1() {

    dl.postActivity(activity).subscribe(function (id) {
        if (console) {
            console.log('"trigger requestWelcomeDialog" sent');
        }
    });
}*/