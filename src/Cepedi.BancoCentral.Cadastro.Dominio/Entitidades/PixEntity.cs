namespace Cepedi.BancoCentral.Cadastro.Dominio.Entidades;

public class PixEntity
{
    public int IdPix { get; set; }
    public string ChavePix { get; set; } = default!;
    public string TipoPix { get; set; } = default!;
    public int IdPessoa { get; set; }
}
