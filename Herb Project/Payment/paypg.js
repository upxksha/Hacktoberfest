function validtext()
{
    if(document.payform.item.value.length<1)
    {
        window.alert("Please enter an item");
        return false;
    }
    if(document.payform.uname.value.length<1)
    {
        window.alert("Please enter your username");
        return false;
    }
    if(document.payform.amount.value.length<1)
    {
        window.alert("Please enter correct amount");
        return false;
    }
    if(document.payform.price.value.length<1)
    {
        window.alert("Please enter the price");
        return false;
    }
    if(document.payform.fname.value.length<1)
    {
        window.alert("Please enter your full name");
        return false;
    }
    if(document.payform.mail.value.length<1)
    {
        window.alert("Please enter your e-mail");
        return false;
    }
    if(document.payform.add.value.length<1)
    {
        window.alert("Please enter your address");
        return false;
    }
    if(document.payform.city.value.length<1)
    {
        window.alert("Please enter your city");
        return false;
    }
    if(document.payform.country.value.length<1)
    {
        window.alert("Please enter your country");
        return false;
    }
    if(document.payform.zip.value.length<1)
    {
        window.alert("Please enter the zip code");
        return false;
    }
}