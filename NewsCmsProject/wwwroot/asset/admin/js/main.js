$(function () {
    checkCookie();
    checkDarkTheme();
    alertify.defaults.theme.ok = "btn btn-success";
    alertify.defaults.theme.cancel = "btn btn-danger";
    alertify.defaults.glossary.ok = "بله";
    alertify.defaults.glossary.cancel = "نه";
});
let btnOpenSearch = document.getElementById("btn-open-search");
let navSearch = document.getElementsByClassName("nav-search")[0];
let closeSearch = navSearch.getElementsByClassName("close")[0];
let mainBody = document.getElementsByTagName("body")[0];
let btnOpenUser = document.getElementById("btn-open-user");
let btnSwitchTheme = document.getElementById("btn-switch-theme");
let btnOpenSidebar = document.getElementById("btn-open-sidebar");
let userContent = $("#user-content");

const toastOptions = {
    "closeButton": false,
    "debug": false,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-top-right",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "250",
    "hideDuration": "950",
    "timeOut": "2500",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};
toastr.options = toastOptions;
function toastSuccess(message, isTop = true, isRight = true) {
    let topPos = isTop ? 'top' : 'bottom';
    let rightPos = isRight ? 'right' : 'left';
    toastOptions['positionClass'] = 'toast-' + topPos + '-' + rightPos;
    toastr['success'](message);
}
function toastError(message, isTop = true, isRight = true) {
    let topPos = isTop ? 'top' : 'bottom';
    let rightPos = isRight ? 'right' : 'left';
    toastOptions['positionClass'] = 'toast-' + topPos + '-' + rightPos;
    toastr['error'](message);
}

btnOpenSearch.onclick = function () {
    navSearch.classList.add("open");
};
function onCloseAlertify() {
    $('.ajs-close').click();
}
function hideModalFooter(isAdd) {
    let style = document.querySelector('head style');
    let defaultStyle = ".ajs-footer { display: none; }";
    style.innerHTML = isAdd ? defaultStyle : '';
}
function onCreateGroup() {
    let url = '/Admin/Groups/Create';
    let title = $('#title').val();
    operatorGroups(url, title);
}
function onEditGroup(id) {
    let url = '/Admin/Groups/Edit/' + id;
    let title = $('#title').val();
    operatorGroups(url, title);
}
function operatorGroups(url, title) {
    $.post(url, {'title': title}).done(function (result) {
        if (!result.isSuccess) {
            toastError(result.message, false, false);
        } else {
            flushMessages(result.message);
        }
    });
}
function onEditComment(id) {
    let url = '/Admin/Edit-Comment/' + id;
    $.post(url, { 'body': $('#bodyComment').val() }).done(function (result) {
        if (!result.isSuccess) {
            alertify.error(result.message);
        } else {
            flushMessages(result.message);
        }
    });
}
function flushMessages(message) {
    localStorage.setItem('message_db', message);
    window.location.reload();
}
window.onresize = function () {
    if (navSearch.classList.contains("open")) {
        navSearch.classList.add("remove-animation");
    }
};
window.onload = function () {
    if (localStorage.getItem('message_db')) {
        toastSuccess(localStorage.getItem('message_db'), false, false);
        localStorage.removeItem('message_db');
    }
};
closeSearch.onclick = function () {
    if (navSearch.classList.contains("remove-animation")) {
        navSearch.classList.remove("remove-animation");
    }
    navSearch.classList.remove("remove-animation");
    navSearch.classList.add("close");
    setTimeout(function () {
        navSearch.classList.remove("open");
        navSearch.classList.remove("close");
    }, 250);
};
btnOpenUser.onclick = function () {
    userContent.slideToggle(250);
};
btnOpenSidebar.onclick = function () {
    mainBody.classList.toggle("sidebar-expanded");
};
btnSwitchTheme.onclick = function () {
    if (!mainBody.classList.contains("dark")) {
        mainBody.classList.add("dark");
        setCookie("dark", "1", 30);
    } else {
        mainBody.classList.remove("dark");
        setCookie("dark", "0", 30);
    }
    checkDarkTheme();
}
function setCookie(cname, cvalue, exdays) {
    let d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}
function getCookie(cname) {
    let name = cname + "=";
    let allCookie = decodeURIComponent(document.cookie).split(';');
    let cval = [];
    for(let i=0; i < allCookie.length; i++) {
        if (allCookie[i].trim().indexOf(name) === 0) {
            cval = allCookie[i].trim().split("=");
        }
    }
    return (cval.length > 0) ? cval[1] : "";
}
function checkCookie() {
    let style = getCookie("dark");
    if (style !== "") {
        if (style === "1") {
            mainBody.classList.add("dark");
        } else if (style === "0") {
            mainBody.classList.remove("dark");
        }
    }
}
function checkDarkTheme() {
    let i = btnSwitchTheme.querySelector('i');
    i.className = mainBody.classList.contains('dark') ? "sun" : "moon";
}