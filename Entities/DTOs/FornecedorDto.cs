using System;
using System.Collections.Generic;

namespace APIGestaoProdutos.DTOs
{
     public class FornecedorDto
     {
          public Guid CodigoFornecedor { get; set; }
          public string DescricaoFornecedor { get; set; }
          public string CNPJ { get; set; }
          public virtual ICollection<ProdutoDto> Produtos { get; set; } = new List<ProdutoDto>();
     }
}
