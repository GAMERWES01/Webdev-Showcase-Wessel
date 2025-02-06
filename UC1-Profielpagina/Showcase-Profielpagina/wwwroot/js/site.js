// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class JeMoe {

    constructor() {
        this.jemoe();
    }

    jemoe() {
        let buttonAccept = document.querySelector(".a");
        if (buttonAccept) {
            buttonAccept.addEventListener("click", () => {
                buttonAccept.innerHTML = "bbb"
            });
        }
    }
}

const jemoe = new JeMoe();

