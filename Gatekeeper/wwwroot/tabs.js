
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

  /*  alert(elname);*/

    document.getElementById("file-tab").classList.remove("active");
    document.getElementById("note-tab").classList.remove("active");
    document.getElementById("payment-tab").classList.remove("active");
    document.getElementById("disclosure-tab").classList.remove("active");
    document.getElementById("video-tab").classList.remove("active");
    document.getElementById("extension-tab").classList.remove("active");
    document.getElementById("other-tab").classList.remove("active");
    document.getElementById(elname).classList.toggle("active");
    document.getElementById(elname).removeAttribute('aria-current');


    
    //aria-current="page"
}


function activetab() {

     //alert(elname);

    document.getElementById("file-tab").classList.remove("disabled");
    document.getElementById("note-tab").classList.remove("disabled");
    document.getElementById("payment-tab").classList.remove("disabled");
    document.getElementById("disclosure-tab").classList.remove("disabled");
    document.getElementById("video-tab").classList.remove("disabled");
    document.getElementById("extension-tab").classList.remove("disabled");
    document.getElementById("other-tab").classList.remove("disabled");

    //aria-current="page"
}


function disabledtab() {

    // alert(elname);

   /* document.getElementById("file-tab").classList.add("disabled");*/
    document.getElementById("note-tab").classList.add("disabled");
    document.getElementById("payment-tab").classList.add("disabled");
    document.getElementById("disclosure-tab").classList.add("disabled");
    document.getElementById("video-tab").classList.add("disabled");
    document.getElementById("extension-tab").classList.add("disabled");
    document.getElementById("other-tab").classList.add("disabled");

    //aria-current="page"
}
