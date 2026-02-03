// ======================================================
// VALIDACAO DE FORMULARIO
// ======================================================
// PASSO A PASSO
// 1) Interceptar submit.
// 2) Validar campos.
// 3) Mostrar mensagens.
//
// HTML sugerido:
// <form id="contact-form">
//   <input id="name" />
//   <input id="email" />
//   <button>Enviar</button>
// </form>
// <div id="msg"></div>

const form = document.getElementById("contact-form");
const msg = document.getElementById("msg");

form.addEventListener("submit", (e) => {
  e.preventDefault();

  const name = document.getElementById("name").value.trim();
  const email = document.getElementById("email").value.trim();

  if (!name || !email) {
    msg.textContent = "Preencha todos os campos";
    return;
  }

  if (!email.includes("@")) {
    msg.textContent = "Email invalido";
    return;
  }

  msg.textContent = "Formulario enviado!";
});

// DESAFIO
// 1) Validar tamanho minimo do nome.
// 2) Limpar formulario depois do envio.
