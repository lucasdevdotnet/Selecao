using AutoMapper;
using Selecao.API.Dto;
using Selecao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selecao.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaxaJuros, TaxaJurosDto>().ReverseMap();
            CreateMap<CalcularJuros, CalcularJurosDto>().ReverseMap();

        }
    }
}
