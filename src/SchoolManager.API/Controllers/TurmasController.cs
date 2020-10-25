using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SchoolManager.API.ViewModels;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;

namespace SchoolManager.API.Controllers
{
    [Route("api/turmas")]
    public class TurmasController : MainController
    {
        private readonly ITurmaService _turmaService;
        private readonly ITurmaRepository _turmaRepository;
        private readonly IMapper _mapper;

        public TurmasController(INotificador notificador, IMapper mapper, ITurmaService turmaService, ITurmaRepository turmaRepository) : base(notificador)
        {
            _mapper = mapper;
            _turmaService = turmaService;
            _turmaRepository = turmaRepository;
        }

        [HttpPost]
        public async Task<ActionResult<TurmaResponseViewModel>> Add(TurmaViewModel turmaViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var response = await _turmaService.Adicionar(_mapper.Map<Turma>(turmaViewModel));

            return CustomResponse(_mapper.Map<TurmaResponseViewModel>(response));
        }

        [HttpGet("{escolaId:guid}")]
        public async Task<IEnumerable<TurmaResponseViewModel>> ListarTodasPorEscola(Guid escolaId)
        {
            return _mapper.Map<IEnumerable<TurmaResponseViewModel>>(await _turmaRepository.ObterTurmasEscola(escolaId));
        }
    }
}
