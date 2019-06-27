$("#login-button").click(function (event) {
	event.preventDefault();

	$('form').fadeOut(500);
	$('.wrapper').addClass('form-success');
	$('#a1').addClass('anim1');
	$('#a2').addClass('anim2');
	$('#a3').addClass('anim3');
});

$(document).ready(function () {
	$("#login-button").click(function () {
		setTimeout(function () {
			window.location.href = "Home/MainPage";
		}, 3000);
	});
});
$("#registerbutton").click(function (event) {
	event.preventDefault();

	$('form').fadeOut(500);
	$('.wrapper').addClass('form-success');
	$('#a1').addClass('anim1');
	$('#a2').addClass('anim2');
	$('#a3').addClass('anim3');

});

$(document).ready(function () {
	$("#registerbutton").click(function () {
		setTimeout(function () {
			window.location.href = "Home/Register";
		}, 3000);
	});
});
