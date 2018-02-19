window.onscroll = function () { myFunction() };

function myFunction() {
  console.log('testing');
  if (document.body.scrollTop > 30 || document.documentElement.scrollTop > 50) {
    document.getElementById("mainNav").className = "navbar-fixed-top";
  } else {
    document.getElementById("mainNav").className = "";
  }
}