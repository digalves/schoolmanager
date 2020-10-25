using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManager.API.ViewModels
{
    public class TurmaViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Turno { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Serie { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Vagas { get; set; }

        [Required(ErrorMessage = "É necessário informar o Id da escola")]
        public Guid EscolaId { get; set; }

    }

    public class TurmaResponseViewModel
    {
        public Guid Id { get; set; }

        public string Curso { get; set; }

        public string Turno { get; set; }

        public string Serie { get; set; }

        public int Vagas { get; set; }

    }
}
