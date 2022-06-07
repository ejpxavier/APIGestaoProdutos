using APIGestaoProdutos.Entities.DTOs;
using APIGestaoProdutos.Entities.Enuns;
using System;
using System.Collections.Generic;

namespace APIGestaoProdutos.DTOs
{
     public class ProdutoDto
     {
          public Guid CodigoProduto { get; set; }
          public string DescricaoProduto { get; set; }
          public Situacao Situacao { get; set; }
          public DateTime? DataFabricacao { get; set; }
          public DateTime? DataValidade { get; set; }
          public virtual ICollection<FornecedorProdutoDto> Fornecedores { get; set; } = new List<FornecedorProdutoDto>();
     }
}
