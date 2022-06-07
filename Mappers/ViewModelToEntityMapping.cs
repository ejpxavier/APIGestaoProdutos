using APIGestaoProdutos.DTOs;
using APIGestaoProdutos.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGestaoProdutos.Mappers
{
     public class ViewModelToEntityMapping : Profile
     {

          public ViewModelToEntityMapping(string profileName) : base(profileName)
          {
               CreateMap<ProdutoDto, Produto>();

               CreateMap<FornecedorDto, Fornecedor>();
          }
     }
}
