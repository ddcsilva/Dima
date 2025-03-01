using Dima.Core.Enums;

namespace Dima.Core.Models;

public class Transaction
{
    public long Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public DateTime? DataRecebimento { get; set; }
    public ETipoTransacao Tipo { get; set; } = ETipoTransacao.Despesa;
    public decimal Valor { get; set; }

    public long CategoriaId { get; set; }
    public Categoria Categoria { get; set; } = null!;
    public string UsuarioId { get; set; } = string.Empty;
}