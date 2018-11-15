var lnRegEx = /^[a-zA-Z]{2,}$/;
var eaRegEx = /^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$/;
var pnRegEx = /(\d{ 3})-(\d{ 3 })-(\d{ 4 })/;
var pRegEx = /^[a-zA-Z]{2,}$/;


var firstnameRegex = /^[a-zA-Z]{2,}$/;
function FirstName()
{
    var firstName = document.getElementById('firstName');
    if (!firstnameRegex.test(firstName.value))
    {
        firstName.style.color = 'red';
        firstName.innerHTML = 'Not acceptable';

    }
    else
    {
        firstName.innerHTML = 'Acceptable';
    }
}

function ValidateForm()
{
    var fn = document.forms["Form"]["fname"].value;
    if (fn == /^[a-zA-Z]{2,}$/)
    {
        return true;
    }
    else
    {
        return ("Format is not correct"); 
    }
}
function ValidateForm()
{
    var ln = document.forms["Form"]["lname"].value;
    if (ln == /^[a - zA - Z]{ 2,}$/)
    {
        return true;
    }
    else
    {
        return ("Format is not correct");
    }
}
function ValidateForm()
{
    var ea = document.forms["Form"]["emailaddress"].value;
    if (ea == /^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$/)
    {
        return true;
    }
    else
    {
        return ("Format is not correct");
    }
}
function ValidateForm()
{
    var pn = document.forms["Form"]["phonenumber"].value;
    if (pn == /(\d{ 3})-(\d{ 3 })-(\d{ 4 })/)
    {
        return true;
    }
    else
    {
        return ("Format is not correct");
    }
}
function ValidateForm()
{
    var p = document.forms["Form"]["Password"].value;
    if (p == /^[a-zA-Z]{2,}$/)
    {
        return true;
    }
    else
    {
        return ("Format is not correct");
    }
}