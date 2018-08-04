using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace  MeusModelos
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    

    }
}
