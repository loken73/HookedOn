// Write your JavaScript code.
$(document).ready(function () {

    var docWidth = $(document).width();
    var bodyHeight = $(document).height();

    if (docWidth > 1426) {
        $(".hamburger").hide();
    }

    $("body").css("font-family", "Roboto");

    $("#admin-body").css({ padding: "70px 0 140px 20px" });

    //$(".body-wrapper").css("height", "100%");

    var bodyHeight = $(document).height();

    $(".thumbnail").hover(function () {
        $(".item-options").animate()
    });

    $("#hamburger").css({
       "margin-right": "0"
    });


    $(".navbar-collapse.navbar-right.collapse.in").css({
        "max-height": "100vh",
        "height": "100vh"
    });

    $(".account-dropdown").css({
       "top": "45px"
    });

    $("footer .row").css({
        "margin": "0"
    });

    $(".overlay-container").mouseenter(function () {
        $(this).find(".details-overlay").animate({"opacity": 0.6});
        $(this).find(".button-wrapper a").animate({"opacity": 1});
    });

    $(".overlay-container").mouseleave(function () {
        $(this).find(".details-overlay").animate({"opacity": 0});
        $(this).find(".button-wrapper a").animate({"opacity": 0}) 
    });


    $("#main-store .card-row").css("margin", "50px -15px");

    $("#main-store.store-section").css("padding", "70px 0");

    $(".account-dropdown").css({
        "top": "45px",
        "padding-right": "5px"
    });

    $(".account-dropdown a").css({
        "color": "black",
        "text-align": "center"
    });

    $("#about-description").css({
        "padding-right": "50px",
        "font-size": "18px"
    });


    $(document).resize(function () {

        if (docWidth <= 1426) {
            $(".hamburger").show();
            $(".new-arrivals .thumbnail").first().css("margin-bottom", "0");
        }
        else {
            $(".hamburger").hide();
        }

    });

    $(".hamburger").click(function () {
        var sideNav = $("#sidebar-wrapper").css("width");

        $(this).stop().toggleClass("cancel");

        if (sideNav == "0px") {
            $("#sidebar-wrapper").stop().animate({
                width: '250px',
            }, 500);

            $("div.bodyshade").fadeIn();

        } else {
            $("#sidebar-wrapper").stop().animate({
                width: '0px'
            }, 500);

            $("div.bodyshade").fadeOut();
        }

        $("line").css("background-color", "#c5e2ff");

    });


    if (docWidth < 1426) {
        $(".new-arrivals .thumbnail").first().css("margin-bottom", "0");
    }

    if (docWidth < 1200) {
        var row = $("#body-footer .mission-statement").after("<div class='row'></div>");

        row.append($(".store-links"));
        row.append($(".connect-social"));
    }
});