
//window.setTimeOut(function () {
//    $(".alert").fadeTo(500,0).slideUp(500,function(){
//        $(this).remove();
//    });
//}, 3000);

$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    $('button[data-toggle="ajax-modal"]').click(function (event) {

        var url = $(this).data('url');
        var decodeUrl = decodeURIComponent(url);
        $.get(decodeUrl).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })
    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
        debugger;
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var url ="/FormBuilder/" + actionUrl;
        var sendData = form.serialize();
        $.post(url, sendData).done(function (data) {
            PlaceHolderElement.find('.modal').modal('hide');
        })
    })
}
)