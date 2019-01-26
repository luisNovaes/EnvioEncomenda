using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EnvioEncomenda.Models
{
    public class Ordem
    {
        [Key]
        public int OrdemId { get; set; }

        public DateTime OrdemData { get; set; }

        public int CustomizarId { get; set; }

        public OrdemStatus OrdemStatus { get; set; }

        [JsonIgnore]
        public virtual Customizar Customizar { get; set; }
        [JsonIgnore]
        public virtual ICollection<OrdemDetalhe> OrdensDetalhes { get; set; }
    }
}