using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Selecao.API.Dto;
using Selecao.API.Model;
using System;
using System.Threading.Tasks;

namespace Selecao.API.Controllers
{

    [Route("api/[Api1]")]
    [ApiController]
    public class Api1Controller : ControllerBase
    {
        private readonly IMapper _mapper;

        public Api1Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("/taxaJuros")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
          nameof(DefaultApiConventions.Get))]
        public ActionResult<decimal> GetTaxaJuros()
        {
            try
            {
                var taxaJuros = new TaxaJuros();
                var taxaJurosDto = _mapper.Map<TaxaJurosDto>(taxaJuros);
                return StatusCode(StatusCodes.Status200OK, taxaJurosDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentat obter os dados");
            }
        }

        [HttpGet("/showmethecode")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
       nameof(DefaultApiConventions.Get))]
        public ActionResult<string> Getshowmethecode()
        {
            try
            {
                var taxaJuros = new TaxaJuros();
                var taxaJurosDto = _mapper.Map<TaxaJurosDto>(taxaJuros);
                return StatusCode(StatusCodes.Status200OK, "https://github.com/lucasdevdotnet/Selecao.git");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentat obter os dados");
            }
        }
    }
}
