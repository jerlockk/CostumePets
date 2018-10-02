// SLIDESHOW

var items = $('.slideshow-items');
var itemCount = $('.slideshow-item').length / 4;
var pos = 0;

function setTransform() {
  items[0].style.transform = 'translate3d(' + (-pos * items[0].offsetWidth) + 'px,0,0)';
}

function prev() {
  pos = Math.max(pos - 1, 0);
  setTransform();
}

function next() {
  pos = Math.min(pos + 1, itemCount - 1);
  setTransform();
}

window.addEventListener('resize', setTransform);

// SCROLL TO TOP

function goToUp() {
  $('html').animate({scrollTop: 0}, 700);
}