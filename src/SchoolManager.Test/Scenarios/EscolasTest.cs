using FluentAssertions;
using SchoolManager.Business.Models;
using SchoolManager.Test.Fixtures;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SchoolManager.Test.Scenarios
{
    public class EscolasTest
    {
        private readonly TestContext _testContext;
        public EscolasTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Values_GetAll_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/escolas");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Values_GetByAll_ReturnsNotFoundResponse()
        {
            var response = await _testContext.Client.GetAsync("/ap/escolas");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Add_Escola_ValuesReturnsOkResponse()
        {

            Escola escola = new Escola
            {
                Id = Guid.NewGuid(),
                Bairro = "Centro",
                Nome = "Maria do Carmo",
                Prefixo = "E.E.E.F",
                Rua = "Projetada",
                Numero = 10,
                Turmas = null
            };

            var response = await _testContext.Client.PostAsync("/api/escolas", _testContext.GetContent(escola));
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Add_Escola_ValuesReturnsReturnsBadRequestResponse()
        {

            Escola escola = new Escola
            {
                Id = Guid.NewGuid(),
                Bairro = null,
                Nome = null,
                Prefixo = "E.E.E.F",
                Rua = "Projetada",
                Numero = 10,
                Turmas = null
            };

            var response = await _testContext.Client.PostAsync("/api/escolas", _testContext.GetContent(escola));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
