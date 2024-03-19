
window.addEventListener("load", (event) => {
    //alert("page is fully loaded");
    //alert(location.pathname);
   
    if (location.pathname == "/accessrequests/add") {
       
        showTopmenu();
    }
    else {
        hideTopmenu();
    }
});



function showTopmenu() {
    var topmenu = document.getElementById("fileTabs");
    
   // alert("show top menu");
    document.getElementById("fileTabs").style.display = "contents";
    topmenu.style.display.replace("none","contents");
    document.getElementById("file-tab").classList.toggle("active");

    
}

function hideTopmenu() {

    if (location.pathname == "/accessrequests/add") {
        showTopmenu();
    }
    else {
        var topmenu = document.getElementById("fileTabs");
        topmenu.style.display = "none";
    }



}

function changetab(elname) {

   

   // alert(elname);

    document.getElementById("file-tab").classList.remove("active");
    document.getElementById("note-tab").classList.remove("active");
    document.getElementById("payment-tab").classList.remove("active");
    document.getElementById("disclosure-tab").classList.remove("active");
    document.getElementById("video-tab").classList.remove("active");
    document.getElementById("other-tab").classList.remove("active");
    document.getElementById(elname).classList.toggle("active");
    document.getElementById(elname).removeAttribute('aria-current');

    
    //aria-current="page"
}

