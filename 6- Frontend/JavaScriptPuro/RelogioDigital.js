// ======================================================
// RELOGIO DIGITAL
// ======================================================
// PASSO A PASSO
// 1) Selecionar elemento onde o tempo aparece.
// 2) Criar funcao que pega hora atual.
// 3) Atualizar a cada 1 segundo.
//
// HTML sugerido:
// <div id="clock"></div>

const clock = document.getElementById("clock");

function format(n) {
  return n.toString().padStart(2, "0");
}

function updateClock() {
  const now = new Date();
  const h = format(now.getHours());
  const m = format(now.getMinutes());
  const s = format(now.getSeconds());
  clock.textContent = `${h}:${m}:${s}`;
}

setInterval(updateClock, 1000);
updateClock();

// DESAFIO
// 1) Mostrar data completa.
// 2) Trocar formato 12h/24h.
