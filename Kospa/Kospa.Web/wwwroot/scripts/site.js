ko.bindingHandlers.dateTime = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var value = valueAccessor();
        var date = moment(value);
        var strDate = date.format('DD/MM/YYYY HH:mm:ss');
        element.innerText = strDate;
    }
};
ko.bindingHandlers.dateTimeWithLabel = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var value = valueAccessor();
        var date = moment(value);
        var strDate = date.format('DD/MM/YYYY HH:mm:ss');
        element.innerText = allBindingsAccessor().dateTimeWithLabel.split(':')[0] + ": " + strDate;
    }
};
var app = $.sammy(function () {
    this.get('/#Meetings', function () {
        vm.currentPanel("tablePanel");
        vm.load();
    });
    this.get('/#Participants', function () {
        var data = "";
        console.log("participants");
    });
    this.get('/#Meeting/View/:id', function () {
        vm.currentPanel("detailPanel");
        vm.loadMeetingDetail(this.params.id);
    });
    this.notFound = function (v, p) { }
});
$(document).ready(function () {
    $("#drawerNew").click(function () {
        $(".fxs-drawer-drawertaskbar.fxs-drawertaskbar").addClass("fxs-drawer-inactive");
        $("#drawer").addClass("fxs-drawer-open fxs-drawer-showmenu");
        $(".fxs-drawer-inner").css("height", "530px");
    });
    $(".fxs-drawermenu-closebutton.fx-button").click(function () {
        $(".fxs-drawer-inner").css("height", "60px");
        setTimeout(function () {
            $("#drawer").removeClass("fxs-drawer-open fxs-drawer-showmenu");
            $(".fxs-drawer-drawertaskbar.fxs-drawertaskbar").removeClass("fxs-drawer-inactive");
        }, 300);
    });

    var notificationTrayOpened = false;
    $(".fxs-drawertray-button.fx-button").click(function () {
        if (!notificationTrayOpened) {
            $("#notificationTray").css({ "display": "block", "top": "-110px" });
            notificationTrayOpened = true;
        }
        else {
            $("#notificationTray").css({ "display": "none", "top": "-110px" });
            notificationTrayOpened = false;
        }
    });
    var avatarMenuOpened = false;
    $(".fxs-avatarbar").click(function () {
        var menu = $(".fxs-avatarbar-menu.fxs-contextmenu");
        if (!avatarMenuOpened) {
            menu.css("display", "block");
            avatarMenuOpened = true;
        }
        else {
            menu.css("display", "none");
            avatarMenuOpened = false;
        }

        menu.toggleClass("fxs-contextmenu-shown");
        menu.toggleClass("fxs-contextmenu-hidden");
    });
    $(document).on("click", "tr[selectable='true']", function (e) {
        $(this).siblings().attr("aria-selected", "false").removeClass("fx-grid-selected");
        $(this).attr("aria-selected", "true").addClass("fx-grid-selected");
        var url = $(this).find('td:first a').attr("href");
        if (url && url.startsWith("/#")) {
            window.location = url;
        }
    });
    app.run();
});

function showLoader() {
    $("#fxshell-tabspinner").show();
}
function hideLoader() {
    $("#fxshell-tabspinner").hide();
}
function sleep(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds) {
            break;
        }
    }
}