using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiKitWeb.Entity
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Senha { get; set; }
    }
}
