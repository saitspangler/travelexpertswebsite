document.addEventListener("DOMContentLoaded", function () {
    var panels = document.querySelectorAll(".panel");

    panels.forEach(function (panel) {
        panel.addEventListener("click", function () {
            panels.forEach(function (panel) {
                panel.classList.remove("active");
            });
            panel.classList.add("active");
        });
    });
});