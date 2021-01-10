using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Range(1, 10, ErrorMessage ="excedeu a quantidade permitida (10 unidades)")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}
