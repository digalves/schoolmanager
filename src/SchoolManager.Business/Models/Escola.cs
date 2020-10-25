using System.Collections.Generic;

namespace SchoolManager.Business.Models
{
    public class Escola : Entity
    {
        public string Prefixo { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        /* EF Relations */
        public IEnumerable<Turma> Turmas { get; set; }
    }
}
