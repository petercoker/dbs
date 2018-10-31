//Start JavaScript Menu Bar toggle Function   

$("nav div").click(function () {
    $("ul").slideToggle();
    $("ul ul").css("display", "none");
});

$("ul li").click(function () {
    $("ul ul").slideUp();
    $(this).find('ul').slideToggle();
});

$(window).resize(function () {
    if ($(window).width() > 768) {
        $("ul").removeAttr('style');
    }
});

//End JavaScript Menu Bar toggle Function


//Start of Slide Show of Types of Payments

var image1 = new Image();
image1.src = "images/visa.jpg";
var image2 = new Image();
image2.src = "images/paypal.jpg";

//End of Slide Show of Types of Payments
