namespace Cepedi.BancoCentral.Cadastro.Shareable.Responses;

public record ObtemBancoResponse(int idBanco, string nomeFantasia, string nomeReal, string cnpj, DateTime dataCriacao);
