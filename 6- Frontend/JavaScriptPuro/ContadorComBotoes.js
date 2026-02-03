// ======================================================
// CONTADOR COM BOTOES
// ======================================================
// PASSO A PASSO
// 1) Selecionar elementos do DOM.
// 2) Criar variavel de estado (count).
// 3) Atualizar a tela ao mudar o valor.
// 4) Adicionar eventos de click.
//
// HTML sugerido:
// <div>
//   <button id="dec">-</button>
//   <span id="value">0</span>
//   <button id="inc">+</button>
// </div>

const btnDec = document.getElementById("dec");
const btnInc = document.getElementById("inc");
const valueEl = document.getElementById("value");

let count = 0;

function render() {
  valueEl.textContent = count;
}

btnDec.addEventListener("click", () => {
  count--;
  render();
});

btnInc.addEventListener("click", () => {
  count++;
  render();
});

render();

// DESAFIO
// 1) Adicionar botao reset.
// 2) Mudar cor quando negativo.
