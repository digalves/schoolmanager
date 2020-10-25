using System;

namespace SchoolManager.Business.Models
{
    public class Turma : Entity
    {
        public string Curso { get; set; }
        public string Turno { get; set; }
        public string Serie { get; set; }
        public int Vagas { get; set; }

        /* EF Relations */
        public Guid EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
