# Docker - Guia Profundo (Sem Resumo)

## O que e Docker?
Docker empacota aplicacao + dependencias em uma imagem. A imagem roda em um container isolado.

## Conceitos que voce precisa dominar
- **Imagem**: receita (imutavel) para criar containers.
- **Container**: instancia executando a imagem.
- **Dockerfile**: instrucoes para montar a imagem.
- **Registry**: local onde imagens ficam (Docker Hub, ACR).
- **Volume**: persistir dados fora do container.
- **Network**: comunicacao entre containers.

------------------------------------------------------------

## Passo a passo mental (o fluxo real)
1. Voce escreve um Dockerfile.
2. O Docker build cria uma imagem.
3. Voce cria um container a partir da imagem.
4. O container executa o processo principal.

------------------------------------------------------------

## Comandos essenciais (explicados)

### 1) Build
```bash
docker build -t minha-api:1.0 .
```
- `-t` define nome:tag.

### 2) Run
```bash
docker run -p 8080:80 minha-api:1.0
```
- `-p` expõe porta.

### 3) Listar
```bash
docker ps        # containers rodando
Docker ps -a     # todos
```

### 4) Parar e remover
```bash
docker stop <id>
docker rm <id>
```

------------------------------------------------------------

## Dockerfile (como pensar)
1. Escolher imagem base (ex: mcr.microsoft.com/dotnet/aspnet:9.0)
2. Copiar arquivos.
3. Restaurar dependencias.
4. Build.
5. Expor porta.
6. Definir comando final (ENTRYPOINT).

------------------------------------------------------------

## Multi-stage build (por que usar)
- Deixa a imagem final menor.
- Separa build de runtime.

------------------------------------------------------------

## Volumes
Usados para dados persistentes.

Exemplo:
```bash
docker run -v c:/dados:/app/data minha-api:1.0
```

------------------------------------------------------------

## Docker Compose (quando usar)
Quando voce precisa rodar varios servicos juntos.
Ex: API + banco + redis.

------------------------------------------------------------

## Arquivos neste diretorio
- Dockerfile.dotnet (API .NET)
- Dockerfile.node (API Node)
- Dockerfile.python (API Python)
- docker-compose.todoapi.yml

------------------------------------------------------------

## Desafios
1. Criar imagem para TodoApi.
2. Rodar com docker-compose.
3. Adicionar volume para logs.
