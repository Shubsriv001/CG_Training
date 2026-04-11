function getValues() {
  let a = parseFloat(document.getElementById("num1").value);
  let b = parseFloat(document.getElementById("num2").value);
  return [a, b];
}

function add() {
  let [a, b] = getValues();
  document.getElementById("result").innerText =
    `Calculated Result: ${a} + ${b} = ${a + b}`;
}

function subtract() {
  let [a, b] = getValues();
  document.getElementById("result").innerText =
    `Calculated Result: ${a} - ${b} = ${a - b}`;
}

function multiply() {
  let [a, b] = getValues();
  document.getElementById("result").innerText =
    `Calculated Result: ${a} * ${b} = ${a * b}`;
}

function divide() {
  let [a, b] = getValues();
  document.getElementById("result").innerText =
    `Calculated Result: ${a} / ${b} = ${a / b}`;
}
