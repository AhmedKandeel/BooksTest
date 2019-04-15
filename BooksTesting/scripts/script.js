document.addEventListener("DOMContentLoaded", function (event) {
    //do work
    var acc = document.getElementsByClassName("accordion");
    var i;
    for (i = 0; i < acc.length; i++) {
        acc[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var panel = this.nextElementSibling;
            if (panel.style.display === "block") {
                panel.style.display = "none";
            } else {
                panel.style.display = "block";
            }
        });
    }
});
var BorrowBook = function (controlurl, id, username) {
    if (username != "") {
        $.ajax({ 
            type: "POST",
            data: { id: id, username: username },
            url: controlurl,
            async: true,
            success: function (data) {
                
               // window.location.reload();
                document.getElementById("divBorrow_" + id).style.display = "none";
                document.getElementById("divUndoBorrow_" + id).style.display = "block";
                document.getElementById("usemame_" + id).innerText = username;
            }
        })
    }
    else
    {
        alert("Please enter you name");
    }
};
var UndoBorrowBook = function (controlurl, id, username) {
    if (username != "") {
        $.ajax({ 
            type: "POST",
            data: { id: id },
            url: controlurl,
            async: true,
            success: function (data) {
                //debugger;
               // window.location.reload();
                document.getElementById("divBorrow_" + id).style.display = "block";
                document.getElementById("divUndoBorrow_" + id).style.display = "none";
                document.getElementById("usemame_" + id).innerText = "";
            }
        })
    }
    else
    {
        alert("Please enter you name");
    }
};

