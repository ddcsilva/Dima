var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(y => y.FullName);
});

builder.Services.AddTransient<Handler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost(
    "/v1/transacoes", (Request request, Handler handler) => handler.Handle(request))
.WithName("Transações: Criar")
.WithSummary("Cria uma nova transação")
.Produces<Response>();

app.Run();

public class Request
{
    public string Titulo { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public int Tipo { get; set; }
    public decimal Valor { get; set; }
    public long CategoriaId { get; set; }
    public string UsuarioId { get; set; } = string.Empty;
}

public class Response
{
    public long Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
}

public class Handler
{
    public Response Handle(Request request)
    {
        return new Response
        {
            Id = 4,
            Titulo = request.Titulo,
        };
    }
}