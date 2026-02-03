# Guia: Como criar uma API do zero (C# .NET)

Este guia explica cada passo, sem pular nada.

------------------------------------------------------------

## 1) Criar o projeto

```bash
mkdir MinhaApi
cd MinhaApi

dotnet new webapi -n MinhaApi
cd MinhaApi
```

O que foi criado:
- `Program.cs`: configura o app.
- `Controllers/`: endpoints.
- `appsettings.json`: configuracao.

------------------------------------------------------------

## 2) Rodar e testar

```bash
dotnet run
```
Acesse: `http://localhost:xxxx/swagger`

------------------------------------------------------------

## 3) Criar o Model (entidade)

Crie `Models/Produto.cs`:
```csharp
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public decimal Preco { get; set; }
}
```

------------------------------------------------------------

## 4) Criar DTO
DTO protege campos internos.

Crie `Models/ProdutoDto.cs`:
```csharp
public class ProdutoDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
}
```

------------------------------------------------------------

## 5) Criar DbContext

```csharp
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Produto> Produtos => Set<Produto>();
}
```

------------------------------------------------------------

## 6) Configurar no Program.cs

```csharp
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("MinhaApi"));

builder.Services.AddControllers();
```

------------------------------------------------------------

## 7) Criar Controller

```csharp
[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _db;

    public ProdutosController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProdutoDto>>> Get()
    {
        return await _db.Produtos
            .Select(p => new ProdutoDto { Id = p.Id, Nome = p.Nome })
            .ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<ProdutoDto>> Post(ProdutoDto dto)
    {
        var produto = new Produto { Nome = dto.Nome };
        _db.Produtos.Add(produto);
        await _db.SaveChangesAsync();

        dto.Id = produto.Id;
        return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
    }
}
```

------------------------------------------------------------

## 8) Testar no Swagger
- Execute a API.
- Abra `/swagger`.
- Teste GET e POST.

------------------------------------------------------------

## 9) Validacao

```csharp
if (string.IsNullOrWhiteSpace(dto.Nome))
    return BadRequest("Nome obrigatorio");
```

------------------------------------------------------------

## 10) Padrao de erro
Crie uma resposta padrao:
```json
{ "error": "mensagem" }
```

------------------------------------------------------------

## 11) Logs
Use `ILogger`:
```csharp
_logger.LogInformation("Criando produto {Nome}", dto.Nome);
```

------------------------------------------------------------

## 12) Producao
- Trocar InMemory por SQL Server ou Postgres
- Criar migrations
- Adicionar autenticação

------------------------------------------------------------

## Desafios finais
1) Adicionar PUT e DELETE.
2) Adicionar paginação.
3) Criar testes unitarios e de integracao.
