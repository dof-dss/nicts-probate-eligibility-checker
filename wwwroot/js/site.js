// code for keeping footer at a nice height.
function adjustFooterHeight() {
    var docHeight = $(window).height();
    var footerHeight = $('.nidirect_footer').height();
    var footerTop = $('.nidirect_footer').position().top + footerHeight;

    if (footerTop < docHeight) {
        $('.nidirect_footer').css('margin-top', -20 + (docHeight - footerTop) + 'px');
    }
}

adjustFooterHeight();