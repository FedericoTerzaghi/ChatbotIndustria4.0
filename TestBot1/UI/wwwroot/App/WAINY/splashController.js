wainy.controller('splashController', ["$scope", "$interval", function ($scope) {

   
    function animation ($interval) {
        var self = this;

        self.activated = true;
        self.determinateValue = 30;

        // Iterate every 100ms, non-stop and increment
        // the Determinate loader.
        $interval(function () {

            self.determinateValue += 1;
            if (self.determinateValue > 100) {
                self.determinateValue = 30;
            }

        }, 100);
    }
         redirect();
   
    //function redirect() {
    //    setTimeout(function () {
    //      window.location.href='#!chat'  ; //will redirect to your blog page (an ex: blog.html)
    //    }, 2000); //will call the function after 2 secs.

    //}

}]);