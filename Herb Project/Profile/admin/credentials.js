function ValidPassword()
{
    if(document.admin_password.current_pword.value.length<1 && document.admin_password.new_pword.value.length<1 && document.admin_password.confirm_pword.value.length<1)
    {
        window.alert("No input data");
        return false;
    }
    else if(document.admin_password.current_pword.value.length<1)
    {
        window.alert("Please Enter Your Current Admin Account Password");
        return false;
    }
    else if((document.admin_password.new_pword.value.length<1 && document.admin_password.confirm_pword.value.length<1) || (document.admin_password.new_pword.value.length<1))
    {
        window.alert("Please Enter Your New Admin Account Password");
        return false;
    }
    else if(document.admin_password.confirm_pword.value.length<1)
    {
        window.alert("Please Confirm Your New Admin Account Password");
        return false;
    }
    else if(document.admin_password.new_pword.value.length<7)
    {
        window.alert("Password Should have at least 6 digits");
        return false;
    }
    else if((document.admin_password.new_pword.value)!=(document.admin_password.confirm_pword.value))
    {
        window.alert("Passwords are not matching");
        return false;
    }


}
function ValidPin()
{
    if(document.admin_pin.current_pin.value.length<1 && document.admin_pin.new_pin.value.length<1 && document.admin_pin.confirm_pin.value.length<1)
    {
        window.alert("No input data");
        return false;
    }
    else if(document.admin_pin.current_pin.value.length<1)
    {
        window.alert("Please Enter Your Current Admin Pin");
        return false;
    }
    else if((document.admin_pin.new_pin.value.length<1 && document.admin_pin.confirm_pin.value.length<1) || (document.admin_pin.new_pin.value.length<1))
    {
        window.alert("Please Enter Your New Admin Pin");
        return false;
    }
    else if(document.admin_pin.new_pin.value.length<5)
    {
        window.alert("Admin Pin Should have at least 5 digits");
        return false;
    }
    else if(document.admin_pin.confirm_pin.value.length<1)
    {
        window.alert("Please Confirm Your New Admin Pin");
        return false;
    }
    else if((document.admin_pin.new_pin.value)!=(document.admin_pin.confirm_pin.value))
    {
        window.alert("Pins are not matching");
        return false;
    }
    else if(isNaN(document.admin_pin.current_pin.value)||isNaN(document.admin_pin.new_pin.value)||isNaN(document.admin_pin.confirm_pin.value))
    {
        window.alert("Admin Pin Should be Numerics");
        return false;
    }

}

