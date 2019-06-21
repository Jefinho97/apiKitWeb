using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiKitWeb.Entity
{
    public class Imagem
    {
        public int ImagemId { get; set; }

        public string ImagemBase64 { get; set; }

        public string KitNetId { get; set; }
    }
}
