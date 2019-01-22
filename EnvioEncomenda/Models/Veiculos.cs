using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnvioEncomenda.Models
{
    public class Veiculos
    {
        [Key]
        public int VeiculoId { get; set; }
        public string VeiPlaca { get; set; }
        public float VeiCapacid { get; set; }

       // public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}