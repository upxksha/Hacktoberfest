function validate() {
    if (document.contactForm.fName.value=="") {
        alert("Enter Your First Name");
    }
    else if (document.contactForm.lName.value=="") {
        alert("Enter Your Last Name");
    }
    else if (document.contactForm.email.value=="") {
        alert("Enter Your Email");
    }
    else if (document.contactForm.description.value=="") {
        alert("Enter Your Description");
    }
    else{
        alert("Message sent successfully!");
    }
}