// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const button = document.querySelector(".btn-outline-info");
    const inputField = document.querySelector("#userInput");

    button.addEventListener("click", function () {
        // Comprobar si el campo está vacío
        const inputValue = inputField.value.trim();  // Usamos `trim()` para quitar espacios al inicio y final
        if (inputValue === "") {
            alert("El campo no puede estar vacío.");
        } else {
            alert(`Mi nombre es Josue Mullo, mi hobbie es salir a caminar y el valor del campo de texto es: ${inputValue}`);
        }
    });
});
