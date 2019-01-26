using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EnvioEncomenda.Models
{
    public class OrdensAPI
    {
        [Key]
        public int OrdemsId { get; set; }

        public DateTime OrdemData { get; set; }

        public Customizar customizar { get; set; }
        [JsonIgnore]
        public OrdemStatus OrdemStatus { get; set; }
        [JsonIgnore]
        public ICollection<OrdemDetalhe> Detalhes { get; set; }
    }
}