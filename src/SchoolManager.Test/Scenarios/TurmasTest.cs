using FluentAssertions;
using SchoolManager.Business.Models;
using SchoolManager.Test.Fixtures;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace SchoolManager.Test.Scenarios
{
    public class TurmasTest
    {
        private readonly TestContext _testContext;

        public TurmasTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Values_GetByAll_ReturnsNotFoundResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/turmas/1");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task Add_Turma_ValuesReturnsBadRequestResponse()
        {

            Turma turma = new Turma
            {
                Curso = null,
                Serie = "3º",
                Turno = null,
                Vagas = 40,
                EscolaId = Guid.NewGuid()
            };

            var response = await _testContext.Client.PostAsync("/api/turmas", _testContext.GetContent(turma));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

    }
}
