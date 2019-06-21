wainy.controller('splashController', ["$scope", "$interval", function ($scope) {
 
         redirect();
   
    function redirect() {
        setTimeout(function () {
          window.location.href='#!chat'  ; //will redirect to your blog page (an ex: blog.html)
        }, 2000); //will call the function after 2 secs.

    }

}]);