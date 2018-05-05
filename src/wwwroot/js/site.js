﻿// Write your JavaScript code.
// Get the modal
var modal = document.getElementById("myModal");

// Get the edit button that opens the modal
var editBtn = document.getElementById("editBtn");

// Get the delete button.
var deleteBtn = document.getElementById("deleteBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal 
function ShowOrderLines() {
  //$("#lines").val(orderlines);
  modal.style.display = "block";
}

deleteBtn.onclick = function() {
  // TODO
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
  modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
  if (event.target === modal) {
    modal.style.display = "none";
  }
}