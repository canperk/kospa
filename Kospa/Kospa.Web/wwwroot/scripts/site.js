ko.bindingHandlers.dateTime = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var value = valueAccessor();
        var date = moment(value);
        var strDate = date.format('DD/MM/YYYY HH:mm:ss');
        element.innerText = strDate;
    }
};