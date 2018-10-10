// SLIDESHOW PRODUCTS

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

// SLIDESHOW POSTS

var itemsP = $('.slideshow-items-post');
var itemCountP = $('.slideshow-item-post').length / 4;
var posP = 0;

function setTransformPost() {
  itemsP[0].style.transform = 'translate3d(' + (-posP * itemsP[0].offsetWidth) + 'px,0,0)';
}

function prevP() {
  posP = Math.max(posP - 1, 0);
  setTransformPost();
}

function nextP() {
  posP = Math.min(posP + 1, itemCountP - 1);
  setTransformPost();
}

window.addEventListener('resize', setTransformPost);

// SCROLL TO TOP

function goToUp() {
  $('html').animate({scrollTop: 0}, 700);
}

// ADD TO CART
$(document).ready(function(){
  $('.btn-to-cart').click(function () {
    var index = $('.btn-to-cart').index(this);
    var title = $('.title-prod')[index].innerHTML;
    var price = $('.price-prod')[index].innerHTML;
    var li = document.createElement('li');
    li.classList.add('list-group-item', 'text-center');
    li.innerHTML = '<p class="text-uppercase title-bold">'+title+'</p>'+' <small>'+price+'</small>';
    $('#list-prods').append(li);
  });

  function truncateText(content, maxLength) {
    if (content.length > maxLength) {
      content = content.substr(0,maxLength) + '...';
    }
    return content;
  }
//You can then call the function with something like what i have below.
  var selector = document.querySelectorAll('.p-truncate');
  for (let i = 0; i <= selector.length-1; i++) {
    selector[i].innerHTML = truncateText(selector[i].innerHTML, 200);
  }

  var selector2 = document.querySelectorAll('.p-prod-truncate');
  for (let i = 0; i <= selector2.length-1; i++) {
    selector2[i].innerHTML = truncateText(selector2[i].innerHTML, 50);
  }

  $('[data-toggle="tooltip"]').tooltip();
});


