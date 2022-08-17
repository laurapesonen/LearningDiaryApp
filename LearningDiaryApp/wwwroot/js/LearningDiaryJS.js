
//Jeren funktio
/*var poisto = document.getElementById("delete");
poisto.addEventListener('submit', (event) => {
    event.preventDefault();
    var choice = confirm("Delete");
    if (choice)
    {
        poisto.submit();
    }
});*/


function myFunction() {
    var x = confirm("Are you sure you want to delete?");
    if (x)
        return true;
    else
        return false;
}
