using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EnvioEncomenda.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Você precisa entrar com o {0}")]
        public string Nome { get; set; }

        [JsonIgnore]
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}