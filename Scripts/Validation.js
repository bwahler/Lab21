var fnRegEx = /^[a-zA-Z]{2,}$/;
var lnRegEx = /^[a-zA-Z]{2,}$/;
var eaRegEx = /"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$"/;
var pnRegEx = /(\d{ 3})-(\d{ 3 })-(\d{ 4 })/;
var pRegEx = /^[a-zA-Z]{2,}$/;


$(document).ready(
    $('#FirstName').change(function ()
    {
        var fnRegEx = /^[a-zA-Z]{2,}$/g;
        var fnValue = $('#FirstName').val();
        if (fnRegEx.test(fnValue))
        {
            $('#FirstName').css('border', 'red');
        }
    })
);

function ValidateForm()
{
    var fn = document.forms["Form"]["fname"].value;
    if (fn == /^[a - zA - Z]{ 2,} $/)
    {
        return true;
    }
    else
    {
        return ("Format is not correct"); 
    }
}