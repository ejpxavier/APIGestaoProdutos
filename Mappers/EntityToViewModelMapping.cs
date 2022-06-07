using APIGestaoProdutos.DTOs;
using APIGestaoProdutos.Entities;
using AutoMapper;

namespace APIGestaoProdutos.Mappers
{
     public class EntityToViewModelMapping : Profile
     {
          public EntityToViewModelMapping(string profileName) : base(profileName)
          {
               CreateMap<Produto, ProdutoDto>();

               CreateMap<Fornecedor, FornecedorDto>();
          }
     }
}
