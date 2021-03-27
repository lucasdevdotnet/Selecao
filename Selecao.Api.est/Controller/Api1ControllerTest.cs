using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Selecao.API.Controllers;

namespace Selecao.Api.Test.Controller
{
    [TestClass]
    public class CalcularJurosModelTest
    {
        private Mock<IMapper> _mockMapper = new Mock<IMapper>();

        [TestMethod]
        public void GetTaxaJuros()
        {
            //Act 
            ActionResult<decimal> _actioResult = new Api1Controller(_mockMapper.Object).GetTaxaJuros();
            var result = _actioResult.Result as ObjectResult;

            //Assert
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
        }
    }
}
