// ======================================================
// TO-DO LIST
// ======================================================
// PASSO A PASSO
// 1) Capturar input e botao.
// 2) Criar item de lista.
// 3) Adicionar no DOM.
//
// HTML sugerido:
// <input id="task-input" />
// <button id="add-btn">Adicionar</button>
// <ul id="task-list"></ul>

const input = document.getElementById("task-input");
const addBtn = document.getElementById("add-btn");
const list = document.getElementById("task-list");

function addTask() {
  const text = input.value.trim();
  if (!text) return;

  const li = document.createElement("li");
  li.textContent = text;

  // remove ao clicar
  li.addEventListener("click", () => li.remove());

  list.appendChild(li);
  input.value = "";
}

addBtn.addEventListener("click", addTask);
input.addEventListener("keydown", (e) => {
  if (e.key === "Enter") addTask();
});

// DESAFIO
// 1) Salvar no localStorage.
// 2) Adicionar botao de remover.
