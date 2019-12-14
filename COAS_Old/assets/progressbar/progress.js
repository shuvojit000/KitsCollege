
$(document).ready(function () {

    if (prog1 = $('#progress_bar')) {
        var progressbar1 = prog1;
        max = progressbar1.attr('max');
        time = (1000 / max) * 5;
        value = progressbar1.val();
        var loading = function () {
            value += 1;
            addValue = progressbar1.val(value);
            $('.progress-value').html(value + '%');
            if (value == max) {
                clearInterval(animate);
            }
        };
    }
    else if (prog2 = $('#progress_bar2')) {
        var progressbar2 = prog2;
        max = progressbar2.attr('max');
        time = (1000 / max) * 5;
        value = progressbar2.val();
        var loading = function () {
            value += 1;
            addValue = progressbar2.val(value);
            $('.progress-value').html(value + '%');
            if (value == max) {
                clearInterval(animate);
            }
        };
    }

        var animate = setInterval(function () {
            loading();
        }, time);
});