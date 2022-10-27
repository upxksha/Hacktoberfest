// variables
var slides = document.querySelectorAll('.slide');
var rbtn = document.querySelectorAll('.rad-btn');
var leftArrow = document.querySelector('.left');
var rightArrow = document.querySelector('.right');
var slidesInt; // var slidesInt; store ongoing timer
var intTime = 5000;

//------------iterate all radio navigation buttns
rbtn.forEach(function(item, index){
    //click event for buttons
    item.addEventListener('click', function(){
        manButtonNav(index);
    });
});

//click events foe arows
// right arrow
rightArrow.addEventListener('click', function(e){
    e.preventDefault();
    nextSlide();
    clrInterval();
});
// left arrow
leftArrow.addEventListener('click', function(e){
    e.preventDefault();
    prevSlide();
    clrInterval();

});

//function for radio navigation
function manButtonNav(index){
    for(i=0 ; i<5 ; i++){
        //set slidew and radio navigation button
        if(i !== index){
            slides[i].classList.remove('curr');
            rbtn[i].classList.remove('active');
        }else{
            slides[i].classList.add('curr');
            rbtn[i].classList.add('active');
        }
    }
    clrInterval();

}

//---sunction for the next slide
function nextSlide(){
    var curr = document.querySelector('.curr');
    var active = document.querySelector('.active');
    // unset current slide and radio button
    curr.classList.remove('curr');
    active.classList.remove('active');
    //set next slide and radio button
    if(curr.nextElementSibling){
        curr.nextElementSibling.classList.add('curr');
        active.nextElementSibling.classList.add('active');
    }else{
        slides[0].classList.add('curr');
        rbtn[0].classList.add('active');
    }
}
//---sunction for the previous slide
function prevSlide(){
    var curr = document.querySelector('.curr');
    var active = document.querySelector('.active');
    // unset current slide and radio button
    curr.classList.remove('curr');
    active.classList.remove('active');
    //set next slide and radio button
    if(curr.previousElementSibling){
        curr.previousElementSibling.classList.add('curr');
        active.previousElementSibling.classList.add('active');
    }else{
        slides[4].classList.add('curr');
        rbtn[4].classList.add('active');
    }
}

//function of clear interval
function clrInterval(){
    clearInterval(slidesInt);
    slidesInt = setInterval(nextSlide, intTime);


}


// automatic slide navigation
slidesInt = setInterval(nextSlide, intTime);

