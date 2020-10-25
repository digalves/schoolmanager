using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using System.Threading.Tasks;

namespace SchoolManager.Business.Services
{
    public class EscolaService : IEscolaService
    {

        private readonly IEscolaRepository _escolaRepository;

        public EscolaService(IEscolaRepository escolaRepository)
        {
            _escolaRepository = escolaRepository;
        }

        public async Task<Escola> Adicionar(Escola escola)
        {
            await _escolaRepository.Adicionar(escola);
            return escola;
        }

    }
}
