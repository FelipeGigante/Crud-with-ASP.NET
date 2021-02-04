using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description = "Código")]
        public int id { get; set; }

        [Display(Description = "Cliente")]
        public string Cliente { get; set; }

        [Display(Description = "Número do Container")]
        public string NumeroContainer { get; set; }

        [Display(Description = "Tipo")]
        public string Tipo { get; set; }

        [Display(Description = "Status")]
        public int Status { get; set; }

        [Display(Description = "Categoria")]
        public string Categoria { get; set; }

        [Display(Description = "Movimento")]
        public string Movimento { get; set; }

        [Display(Description = "Quantidade de Movimentos")]
        public int QtdMovimentos { get; set; }

        [Display(Description = "Início")]
        public DateTime Inicio { get; set; }

        [Display(Description = "Final")]
        public DateTime Fim { get; set; }

    }
}
