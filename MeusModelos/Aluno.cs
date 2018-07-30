using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    public class Aluno
    {
        public int AlunoID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }
        public int CGM { get; set; }
        public string Foto { get; set; }

        public bool Situacao { get; set; }
    }
}
