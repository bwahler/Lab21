var fnRegEx = /^[a-zA-Z]{2,}$/;
var fnRegEx = /^[a-zA-Z]{2,}$/;
var eaRegEx = /"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$"/;
var pnRegEx = /(\d{ 3})-(\d{ 3 })-(\d{ 4 })/;
var pRegEx = /^[a-zA-Z]{2,}$/;


function Validate()
{
    if (/^[a-zA-Z]{2,}$/ || /^[a-zA-Z]{2,}$/ || /"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$"/ || /(\d{ 3})-(\d{ 3 })-(\d{ 4 })/ || /^[a-zA-Z]{2,}$/)
    {
        return true;
    }
    else
    {
        return ("There are missed requirements");
    }
}