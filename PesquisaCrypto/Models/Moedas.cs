using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Models
{
    public class Moedas
    {        
        public int MoedasId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório.")]
        [MaxLength(180, ErrorMessage ="Digite menos caracteres.")]
        [Remote("MoedaExisteAsync", "Moedas")]
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        [NotMapped]
        public bool CheckBoxMarcado { get; set; }
    }
}
