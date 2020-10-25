using AutoMapper;
using Core.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SchoolManager.API.ViewModels;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManager.API.Controllers
{
    [Route("api/escolas")]
    public class EscolasController : MainController
    {
        private readonly IEscolaService _escolaService;
        private readonly IEscolaRepository _escolaRepository;
        private readonly IMapper _mapper;

        public EscolasController(INotificador notificador, IMapper mapper, IEscolaService escolaService, IEscolaRepository escolaRepository) : base(notificador)
        {
            _mapper = mapper;
            _escolaService = escolaService;
            _escolaRepository = escolaRepository;
        }

        [HttpGet("start")]
        public ActionResult Start()
        {
            return Ok("School Manager API");
        }

        [HttpPost]
        public async Task<ActionResult<EscolaResponseViewModel>> Add(EscolaViewModel escolaViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var response = await _escolaService.Adicionar(_mapper.Map<Escola>(escolaViewModel));

            return CustomResponse(response);
        }

        [HttpGet]
        public async Task<IEnumerable<EscolaResponseViewModel>> ListarTodas()
        {
            return _mapper.Map<IEnumerable<EscolaResponseViewModel>>(await _escolaRepository.ObterEscolasTurmas());
        }

    }
}
