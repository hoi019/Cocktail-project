



const plus = document.querySelector('.fa-plus');
const minus = document.querySelector('.fa-minus');
const inputElement = document.querySelector('.quantity');
var count = 1; // Initialize count to 1 since the input has an initial value of 1

plus.addEventListener('click', () => {
  if (count > 0) {
    count = count + 1;
    inputElement.value = count; // Update the input value
  }
})

minus.addEventListener('click', () => {
  if (count > 1) {
    count = count - 1;
    inputElement.value = count; // Update the input value
  }
})