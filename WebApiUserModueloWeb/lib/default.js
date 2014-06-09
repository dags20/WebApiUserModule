(function () {
    "use strict";

    window.addEventListener("load", function load(event) {
        window.removeEventListener("load", load, false);
        init();
    }, false);

    function init() {
        document.getElementById("link").addEventListener("click", showAlert, false);
    }

    function showAlert() {
        alert("Welcome to Pure HTML!");
    }
}());