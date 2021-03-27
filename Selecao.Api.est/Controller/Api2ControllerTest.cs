using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selecao.API.Controllers;

namespace Selecao.Api.Test.Controller
{
    [TestClass]
    public class Api2ControllerTest
    {
        private Mock<IMapper>_mockMapper = new Mock<IMapper>();

        [TestMethod]
        public void GetalculaJuros200Ok()
        {
            int mes = 5;
            decimal valorInicial = 100;
            //Act 
            ActionResult<decimal> _actioResult = new Api2Controller(_mockMapper.Object).Getcalculajuros(valorInicial,mes);
            var result = _actioResult.Result as ObjectResult;

            //Assert
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
        }
    }
}
