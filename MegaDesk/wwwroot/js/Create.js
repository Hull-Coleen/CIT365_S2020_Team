
// 
var select = document.querySelector('select');
var html = document.querySelector('materialView');

// create even listener
select.addEventListener('change', backgrounds);

function backgrounds() {
    var choice = select.value;

    if (choice === "Veneer") {
        html.style.backgroundImage = "url('images/venner.jpg')";
    }
    else if (choice === "Oak") {
        html.style.backgroundImage = "url('images/oak.jpg')";
    }
    else if (choice === "Laminate") {
        html.style.backgroundImage = "url('images/laminate.jpg')";
    }
    else if (choice === "Pine") {
        html.style.backgroundImage = "url('images/pinejpg.jpg')";
    }
    else if (choice === "Rosewood") {
        html.style.backgroundImage = "url('images/Rosewood.jpg')";
    }
}