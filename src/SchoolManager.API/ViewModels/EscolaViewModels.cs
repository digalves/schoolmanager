using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManager.API.ViewModels
{
    public class EscolaViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Prefixo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Numero { get; set; }
    }

    public class EscolaResponseViewModel
    {
        public Guid Id { get; set; }

        public string Prefixo { get; set; }

        public string Nome { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public IEnumerable<TurmaResponseViewModel> Turmas { get; set; }

    }

}
