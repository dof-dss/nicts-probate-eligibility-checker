$(document).ready(function () {
    // Show error_summary if there any validation errors, this is so the summary shows for both front and back end validation.
    if ($(".error-items").length) {
        $(".govuk-error-summary").show();
    }
});

function adjustFooterHeight() {
    let docHeight = $(window).height();
    let footerHeight = $('.nidirect_footer').height();
    let footerTop = $('.nidirect_footer').position().top + footerHeight;

    if (footerTop < docHeight) {
        $('.nidirect_footer').css('margin-top', -20 + (docHeight - footerTop) + 'px');
    }
}

adjustFooterHeight();