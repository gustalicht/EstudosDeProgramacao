// ======================================================
// CRUD EM ARQUIVO JSON
// ======================================================
// PASSO A PASSO
// 1) Ler arquivo JSON (ou criar se nao existir).
// 2) Manipular array de objetos.
// 3) Salvar de volta.

const fs = require("fs/promises");
const path = require("path");

const arquivo = path.join(__dirname, "dados.json");

async function lerDados() {
  try {
    const texto = await fs.readFile(arquivo, "utf-8");
    return JSON.parse(texto);
  } catch {
    return [];
  }
}

async function salvarDados(dados) {
  await fs.writeFile(arquivo, JSON.stringify(dados, null, 2));
}

async function adicionar(nome) {
  const dados = await lerDados();
  dados.push({ id: Date.now(), nome });
  await salvarDados(dados);
  console.log("Item adicionado");
}

async function listar() {
  const dados = await lerDados();
  console.log(dados);
}

async function remover(id) {
  const dados = await lerDados();
  const filtrado = dados.filter(d => d.id !== id);
  await salvarDados(filtrado);
  console.log("Item removido");
}

// CLI simples
// node CrudDeArquivoJSON.js add "teste"
// node CrudDeArquivoJSON.js list
// node CrudDeArquivoJSON.js remove 123

(async () => {
  const cmd = process.argv[2];
  const arg = process.argv[3];

  if (cmd === "add") return adicionar(arg);
  if (cmd === "list") return listar();
  if (cmd === "remove") return remover(Number(arg));

  console.log("Comandos: add | list | remove");
})();

// DESAFIO
// 1) Criar comando update.
// 2) Validar nome vazio.
