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
            url: controlurl,
            type: "Post",
            contentType: "application/json",
            data: { bookID: id, username: username },
            success: function (result) {
                if (result) {
                    console.log("success");
                }
                else { alert("Error. Try Again Later."); }
            },
            fail: function () { }
        })
    }
    else
    {
        alert("Please enter you name");
    }
};
var Search = function (controlurl) {
    $.ajax({
        url: controlurl,
        type: "Post",
    contentType: "application/json",
    success: function (result) {
        
    },
    fail: function () { }
});

}
