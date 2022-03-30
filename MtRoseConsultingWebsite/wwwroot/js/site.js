// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function delay(n) {
    return new Promise(function (resolve) {
        setTimeout(resolve, n * 1000);
    });
}

var breaknow = false;

// forward/Back controls
function plusSlides(n) {
    SlideShow(slidePosition += n);
}

//  images controls
function currentSlide(n) {
    SlideShow(slidePosition = n);
}

function SlideShow(n) {
    var i;
    var slides = document.getElementsByClassName("Containers");
    var circles = document.getElementsByClassName("dots");
    if (n > slides.length) { slidePosition = 1 }
    if (n < 1) { slidePosition = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < circles.length; i++) {
        circles[i].className = circles[i].className.replace(" enable", "");
    }
    slides[slidePosition - 1].style.display = "block";
    circles[slidePosition - 1].className += " enable";

    breaknow = true;
}

//var slidePosition = 1;
//SlideShow(slidePosition);

var slidePosition2 = 0;
SlideShow();

async function SlideShow() {
    console.log("here");

    if (breaknow) {
        console.log(breaknow);
        return;
    }

    var i;
    var slides = document.getElementsByClassName("Containers");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slidePosition2++;
    if (slidePosition2 > slides.length) { slidePosition2 = 1 }
    slides[slidePosition2 - 1].style.display = "block";

    await delay(5);
    SlideShow();
} 