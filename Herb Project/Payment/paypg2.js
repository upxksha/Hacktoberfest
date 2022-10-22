function validtext()
{
    if(document.payform.noc.value.length<1)
    {
        window.alert("Please enter the name on card");
        return false;
    }
    if(document.payform.cnum.value.length<1)
    {
        window.alert("Please enter the card number");
        return false;
    }
    if(document.payform.exmon.value.length<1)
    {
        window.alert("Please enter the expiring month");
        return false;
    }
    if(document.payform.exyer.value.length<1)
    {
        window.alert("Please enter the expiring year");
        return false;
    }
    if(document.payform.cvv.value.length<1)
    {
        window.alert("Please enter the cvv");
        return false;
    }
}