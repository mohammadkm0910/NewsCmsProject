const searchNav = document.querySelector('.navbar-search');
const searchInput = searchNav.querySelector('input[type="text"]');
const closeSearchNav = searchNav.querySelector('.close');
const registerHeader = document.getElementsByClassName("header-register")[0];
const textRegisterHeader = registerHeader.getElementsByTagName("div")[0].getElementsByTagName("h5")[0];

$('.nav-icon').on('click', function () {
    this.classList.toggle("open");
    let navContent = $("#nav-content");
    navContent.slideToggle('fast');
});
$("#open-navbar-search").click(function () {
    if (searchNav.classList.contains("fade-out")) {
        searchNav.classList.remove("fade-out");
    }
    searchNav.classList.add("open");
});
searchInput.onkeydown = function (e) {
    if (e.code === 'Enter') {
        window.location.href = searchNav.action + '?q=' + searchInput.value;
        return false;
    }
    return true;
};
closeSearchNav.onclick = function () {
    searchNav.classList.add("fade-out");
    setTimeout(function (){
        searchNav.classList.remove("open");
        searchNav.classList.remove("fade-out");
    }, 500);
    return false;
};
let i = 0;
const contentTextRegisterHeader = textRegisterHeader.innerText.toString();
let holderText = [contentTextRegisterHeader];
const lenTextRegisterHeader = contentTextRegisterHeader.length;
textRegisterHeader.innerHTML = "";
$(function (){
    typeWriter();
});
function typeWriter() {
    if (i < lenTextRegisterHeader) {
        textRegisterHeader.innerHTML += holderText[0].charAt(i);
        i++;
        setTimeout(typeWriter, 50);
    }
}
const navbarShortcutDrawer = document.getElementsByClassName("navbar-shortcut-drawer")[0];
navbarShortcutDrawer.addEventListener("click",function () {
    let nextElement = $(this.nextElementSibling);
    nextElement.toggle('fast');
});
window.onscroll = function () { createNavbarSticky() };
const navbar = document.getElementsByClassName("navbar")[0];
const btnFirstScroll = document.getElementsByClassName("btn-first-scroll")[0];
const navbarOffset = navbar.offsetTop;
function createNavbarSticky() {
    if (window.pageYOffset >= navbarOffset) {
        navbar.classList.add("sticky");
        btnFirstScroll.classList.add("show");
    } else {
        navbar.classList.remove("sticky");
        btnFirstScroll.classList.remove("show");
    }
}
btnFirstScroll.onclick = function () {
    $('html').animate({
        scrollTop: 0
    }, 700);
}
alertify.defaults.transition = "zoom";
alertify.defaults.theme.ok = "btn";
function gmailDialog() {
    alertify.alert().setting({
        'title':'جیمیل من',
        'label': 'بله',
        'message': 'جمیل من mohammmadkm0910@gmail.com هست',
    }).show();
}
function outlookDialog() {
    alertify.alert().setting({
        'title':'اتولوک من',
        'label': 'بله',
        'message': 'اتولوک من rayanfarsi098@outlook.com هست'
    }).show();
}
function telegramDialog() {
    alertify.alert().setting({
        'title':'شماره تلگرام من',
        'label': 'بله',
        'message': 'شماره تلگرام من 09102180601 هست'
    }).show();
}
const passwordShow = document.getElementsByClassName("password-show");
for (let k = 0; k < passwordShow.length ; k++) {
    passwordShow[k].addEventListener("click", function (){
       let nextElement = this.nextElementSibling;
       if (!this.classList.contains("fa-eye-slash")) {
           nextElement.setAttribute("type", "text");
           this.classList.add("fa-eye-slash");
       } else {
           nextElement.setAttribute("type", "password");
           this.classList.remove("fa-eye-slash");
       }
    });
}