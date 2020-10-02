function start(){
    var div_screen = document.getElementById("start-animation");
    var cards = document.getElementById("caixas");
    var bnt_press = document.getElementById("press-start");
    var registros = document.getElementById("registros");
    
    bnt_press.style.backgroundColor="rgb(216, 213, 209)";
    bnt_press.style.animation="none";

    div_screen.style.backgroundColor="#000000";
    
    setTimeout(function(){
    div_screen.style.backgroundImage="url(./img/screen.gif)";
    }, 2500);
    setTimeout(function(){cards.style.display="flex";},18000);
    setTimeout(function(){
        registros.style.display="block";
        registros.style.visibility="hidden";
        },18000);
}

function registros(){
    document.getElementById("caixas").style.visibility="hidden";
    document.getElementById("registros").style.visibility="visible";
}
function games(){
    document.getElementById("caixas").style.visibility="visible";
    document.getElementById("registros").style.visibility="hidden";
}
function eventos(){
    var bnt_press = document.getElementById("press-start");
    var bnt1 = document.getElementById("bnt-1");
    var bnt2 = document.getElementById("bnt-2");
    bnt_press.addEventListener("click",start);
    bnt1.addEventListener("click",registros);
    bnt2.addEventListener("click",games);
}

window.addEventListener("load",eventos);