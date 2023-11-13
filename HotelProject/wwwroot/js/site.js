// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    var currentPath = window.location.pathname;

    var currentPage = currentPath.substring(1);

    var endpoint = currentPage.split('/')[0].toLowerCase();

    if(endpoint)
        document.body.classList.add(endpoint + '-background');
    else
        document.body.classList.add('home-background');
});