wainy.controller('wainyController', ["$scope", function ($scope) {

    var dl = window.WebChat.createDirectLine({ secret: 'iw7ShoDKqAc.yezHmWsZTT5iTIqi6q10SOZjE8UaNxjRXCk2SooTASg' });
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