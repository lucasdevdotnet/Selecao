using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Selecao.API.Dto;
using Selecao.API.Mapping;
using Selecao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Selecao.API.Controllers
{
    [Route("api/[api2]")]
    [ApiController]
    public class Api2Controller : ControllerBase
    {
        private readonly IMapper _mapper;

        public Api2Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("/calculajuros{valorinicia}/{meses}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
          nameof(DefaultApiConventions.Get))]
        public ActionResult<decimal> Getcalculajuros(decimal valorinicia, int meses)
        {
            try
            {
                var calcularJuros = new CalcularJuros();
                calcularJuros.CalcularTaxaJuros(valorinicia, meses);

                var calcularJurosDto = _mapper.Map<CalcularJurosDto>(calcularJuros);
                return StatusCode(StatusCodes.Status200OK, calcularJurosDto);
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentat obter os dados");
            }
        }
    }
}
