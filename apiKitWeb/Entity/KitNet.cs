using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiKitWeb.Entity
{
    public class KitNet
    {
        public int KitNetId { get; set; }

        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public int UsuarioId { get; set; }
    }
}
