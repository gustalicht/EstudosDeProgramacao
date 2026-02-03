// ======================================================
// API NODE SIMPLES (sem framework)
// ======================================================
// PASSO A PASSO
// 1) Criar servidor HTTP.
// 2) Ler metodo e URL.
// 3) Responder com JSON.

const http = require("http");

let todos = [
  { id: 1, title: "Estudar Node" },
  { id: 2, title: "Criar API" }
];

const server = http.createServer((req, res) => {
  const { method, url } = req;

  if (method === "GET" && url === "/health") {
    res.writeHead(200, { "Content-Type": "application/json" });
    return res.end(JSON.stringify({ ok: true }));
  }

  if (method === "GET" && url === "/todos") {
    res.writeHead(200, { "Content-Type": "application/json" });
    return res.end(JSON.stringify(todos));
  }

  if (method === "POST" && url === "/todos") {
    let body = "";
    req.on("data", chunk => (body += chunk));
    req.on("end", () => {
      const data = JSON.parse(body || "{}");
      const novo = { id: Date.now(), title: data.title };
      todos.push(novo);
      res.writeHead(201, { "Content-Type": "application/json" });
      res.end(JSON.stringify(novo));
    });
    return;
  }

  res.writeHead(404, { "Content-Type": "application/json" });
  res.end(JSON.stringify({ error: "Not found" }));
});

server.listen(3000, () => {
  console.log("Servidor rodando em http://localhost:3000");
});

// DESAFIO
// 1) Implementar DELETE /todos/:id.
// 2) Validar body vazio.
