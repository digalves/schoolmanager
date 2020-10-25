using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using System;
using System.Threading.Tasks;

namespace SchoolManager.Business.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaService(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        public async Task<Turma> Adicionar(Turma turma)
        {
            await _turmaRepository.Adicionar(turma);
            return await ObterPorIdComEscola(turma.Id);
        }

        private async Task<Turma> ObterPorIdComEscola(Guid id)
        {
            return await _turmaRepository.ObterTurmaEscola(id);
        }

    }
}
