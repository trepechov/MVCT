ko.bindingHandlers.modal = {
    init: function (element, valueAccessor) {
        var value = valueAccessor();
        $(element).addClass('modal').addClass('fade').modal({ show: ko.unwrap(value) });;
    },
    update: function (element, valueAccessor) {
        var value = valueAccessor();
        ko.unwrap(value) ? $(element).modal('show') : $(element).modal('hide');
    }
};