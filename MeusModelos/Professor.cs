﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    public class Professor
    {
        public int ProfessorID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public bool Situacao { get; set; }
        public int Matricula { get; set; }
        public string Senha { get; set; }


    }
}
