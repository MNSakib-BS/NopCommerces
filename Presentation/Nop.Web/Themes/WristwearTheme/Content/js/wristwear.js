﻿/*!
 * Wristwear Theme v2.8.0 (http://themes.nopaccelerate.com/themes/wristwear-nopcommerce-theme/)
 * Copyright 2024 Xcellence-IT.
 * Licensed under LICENSETYPE (http://www.nopaccelerate.com/terms/)
 */

/* Using Wristwear js for Wristwear Theme */

$(document).ready(function () {
    //Used js for Header Sticky Menu  
    //http://www.jqueryscript.net/menu/Sticky-Navigation-Bar-with-jQuery-Bootstrap.html
    $(window).bind('scroll', function() {
        var navHeight = $("div.header").height();
        var navWidth = $("div.header").width();
        ($(window).scrollTop() > navHeight) ? $('.main-menu').addClass('goToTop').width(navWidth) : $('.main-menu').removeClass('goToTop');
    });

    //Used js for Responsive Website Checker
    $('#exit').on('click', function (e) {
        $('.responsive').hide();
        $('.master-wrapper-page').css('margin-top', '0');
    });

    //Used js for Left Sliderbar Collapse(Responsive Devices)
    $('.block .title,.column .title,.product-filter .filter-title').click(function () {
        var e = window, a = 'inner';
        if (!('innerWidth' in window)) {
            a = 'client';
            e = document.documentElement || document.body;
        }
        var result = { width: e[a + 'Width'], height: e[a + 'Height'] };
        if (result.width < 992) {
            $(this).siblings('.listbox,.nav.nav-list').slideToggle('slow');
            $(this).toggleClass("arrow-up-down");
        }
    });

    //Used js for flayout cart
    $("#flyout-cart").on('mouseenter', function (event) {
        $('#flyout-cart-wrapper').addClass('active');
    });

    $("#flyout-cart").on('mouseleave', function (event) {
        $('#flyout-cart-wrapper').removeClass('active');
    });

    //Used js for Product Box and Product Thumbs Slider

    $('#product-slider').owlCarousel({
        loop: true,
        dots: false,
        nav: true,
        navText: ["prev", "next"],
        autoPlay: true,
        lazyLoad: true,
        responsive: {
            0: {
                items: 2
            },
            481: {
                items: 3
            },
            768: {
                items: 4
            }
        }
    });

    $('#home-category-slider,#sub-category-slider,#manufacturer-slider,#crosssell-products-slider,#home-bestseller-slider,#home-features-slider,#related-products-slider,#also-purchased-products-slider').owlCarousel({
        loop: true,
        dots: false,
        nav: true,
        margin:15,
        navText: ["prev", "next"],
        autoPlay: false,
        lazyLoad: true,
        responsive: {
            0: {
                items: 1
            },
            575: {
                items: 2
            },
            768: {
                items: 3
            },
            1199: {
                items: 4
            }
        }
    });

    $('#home-news-slider').owlCarousel({
        loop: true,
        dots: false,
        nav: true,
        navText: ["prev", "next"],
        autoPlay: false,
        lazyLoad: true,
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2
            }
        }
    });

    /* Used js for BackTop Page Scrolling*/
    (function ($) {
        $.fn.backTop = function (options) {
            var backBtn = this;
            var settings = $.extend({
                'position': 400,
                'speed': 500,
            }, options);

            //Settings
            var position = settings['position'];
            var speed = settings['speed'];
            
            backBtn.css({
                'right': 40,
                'bottom': 40,
                'position': 'fixed',
            });

            $(document).scroll(function () {
                var pos = $(window).scrollTop();

                if (pos >= position) {
                    backBtn.fadeIn(speed);
                } else {
                    backBtn.fadeOut(speed);
                }
            });

            backBtn.click(function () {
                $("html, body").animate({
                    scrollTop: 0
                },
                {
                    duration: 1200
                });
            });
        }
    }(jQuery));

    $('#backTop').backTop({
        'position': 200,
        'speed': 500,
    });

});

// Used for lines on hover 
window.onload = function () {
    $(".header-menu ul a").on('click', function (e) {
        var link = $(this);
    }).each(function () {
        var link = $(this);
        if (link.get(0).href === location.href) {
            link.parent('li').addClass('active');
            return false;
        }
    });
};
