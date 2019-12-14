// Basic DataTable
$(function(){
	$('#basicExample').DataTable({
		'iDisplayLength': 5,
	});
});

// Autofill DataTable
$(function(){
	$('#autoFill').DataTable({
		autoFill: true,
		'iDisplayLength': 5,
	});
});

// Fixed Header DataTable
$(function(){
	var table = $('#fixedHeader').DataTable( {
		fixedHeader: true,
		'iDisplayLength': 5,
	});
});

// Responsive Table
$(function(){
	$('#responsiveTable').DataTable({
		responsive: true,
		'iDisplayLength': 5,
	});
});

$(function(){
  $('#scrollTable').DataTable({
      "scrollY": "200px",
      "scrollX": true,
    "scrollCollapse": true,
    "paging": false,
    responsive: true,
    'iDisplayLength': 5,
  });
});


// Responsive & Paging & Autofill & Search & Scroll Table
$(document).ready(function () {
    $('#example').DataTable({
        "scrollY": 200,
        "scrollX": true
    });
});

$(document).ready(function () {
    $('#example2').DataTable({
        "scrollY": 200,
        "scrollX": true
    });
});


//$(function(){
////And for the first simple table, which doesn't have TableTools or dataTables
////select/deselect all rows according to table header checkbox
//var active_class = 'active';
//$('#scrollTable > thead > tr > th input[type=checkbox]').eq(0).on('click', function () {
//    var th_checked = this.checked;//checkbox inside "TH" table header

//    $(this).closest('table').find('tbody > tr').each(function () {
//        var row = this;
//        if (th_checked) $(row).addClass(active_class).find('input[type=checkbox]').eq(0).prop('checked', true);
//        else $(row).removeClass(active_class).find('input[type=checkbox]').eq(0).prop('checked', false);
//    });
//});

////select/deselect a row when the checkbox is checked/unchecked
//$('#scrollTable').on('click', 'td input[type=checkbox]', function () {
//    var $row = $(this).closest('tr');
//    if ($row.is('.detail-row ')) return;
//    if (this.checked) $row.addClass(active_class);
//    else $row.removeClass(active_class);
//});
//});