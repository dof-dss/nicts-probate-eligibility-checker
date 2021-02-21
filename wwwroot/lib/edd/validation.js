if ($('form').length > 0) {
    var submitted_1 = false;
    $("form").bind("invalid-form.validate", function () {
        submitted_1 = true;
    });
    $('form').removeData("validator")
        .removeData("unobtrusiveValidation");
    $.validator.setDefaults({
        errorClass: 'govuk-error-message',
        ignore: 'input[type=hidden]:not(.monthtimehidden)',
        highlight: function (element, errorClass, validClass) {
            var el = $(element);
            var fg = el.closest(".govuk-form-group");
            fg.addClass("govuk-form-group--error");
            el.addClass("govuk-input--error");
        },
        unhighlight: function (element, errorClass, validClass) {
            var el = $(element);
            var fg = el.closest(".govuk-form-group");
            fg.removeClass("govuk-form-group--error");
            el.removeClass("govuk-input--error");
        },
        showErrors: function (errorMap, errorList) {
            if (submitted_1) {
                var summary_1 = '';
                var errorHint_1 = '';
                if (errorList.length > 0) {
                    $('.govuk-error-summary').show();
                }
                else {
                    $('.govuk-error-summary').hide();
                }
                $.each(errorList, function () { errorHint_1 += this.message; });
                $.each(errorList, function () { summary_1 += "<li><a href='#" + this.element.id + "'>" + this.message + "</a></li>\n"; });
                $('.govuk-error-summary__list').html(summary_1);
                $('.govuk-error-message').append(errorHint_1);
                submitted_1 = false;
            }
            this.defaultShowErrors();
        },
        invalidHandler: function (event, validator) {
            submitted_1 = true;
        }
    });
    $.validator.unobtrusive.parse("form");
}
