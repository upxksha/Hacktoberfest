function animatedForm(){
    const arrows= document.querySelectorAll(".fa-arrow-down");

    arrows.forEach(arrow => {
        arrow.addEventListener('click', () => {
            const input= arrow.previousElementSibling;
            const parent= arrow.parentElement;
            const nextForm= parent.nextElementSibling;
            // console.log(parent);

            //check for validation
            if(input.type === "text" && validateUser(input)){
                // console.log('every thing is ok');
                nextSlide(parent, nextForm); 
            }else if(input.type === "email" && validateUser(input)){
                nextSlide(parent, nextForm);
            }else if(input.type === "password" && validateUser(input)){
                nextSlide(parent, nextForm);
            }else{
                parent.style.animation="shake 0.3s ease";
            }

            //get rid of animation
            parent.addEventListener('animationend', () => {
                parent.style.animation='';
            })
        });
    });
}

function validateUser(user){
    if(user.value.length  <6 ){
        console.log('not enough characters');
        error("rgb(189,87,87)");
    }
    else{
        error("greenyellow");
        console.log('enough characters');
        return true;
    }
}
function validateEmail(email){
    const validation = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (validation.test(email.value)){
        error("greenyellow");
        return true;
    }else{
        error("rgb(189,87,87)");
    }
}






function nextSlide(parent, nextForm){
    parent.classList.add('innactive');
    parent.classList.remove('active');
    nextForm.classList.add('active');
}

function error (color){
    document.body.style.backgroundColor = color;
}

animatedForm();