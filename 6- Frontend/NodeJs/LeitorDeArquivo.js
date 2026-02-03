// ======================================================
// LEITOR DE ARQUIVO (Node.js)
// ======================================================
// PASSO A PASSO
// 1) Ler o caminho do arquivo via argumento.
// 2) Usar fs.promises para ler.
// 3) Mostrar o conteudo no console.

const fs = require("fs/promises");

async function lerArquivo() {
  const caminho = process.argv[2];
  if (!caminho) {
    console.log("Uso: node LeitorDeArquivo.js <caminho>");
    return;
  }

  try {
    const conteudo = await fs.readFile(caminho, "utf-8");
    console.log(conteudo);
  } catch (err) {
    console.error("Erro ao ler arquivo:", err.message);
  }
}

lerArquivo();

// DESAFIO
// 1) Contar linhas do arquivo.
// 2) Mostrar tamanho em bytes.
