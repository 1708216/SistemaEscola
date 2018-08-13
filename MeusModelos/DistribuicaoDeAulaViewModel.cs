﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    public class DistribuicaoDeAulaViewModel
    {
        public int itemSelecionado { get; set; }

        public int TurmaID { get; set; }
        public virtual Turma _turma { get; set; }

        public int DisciplinaID { get; set; }
        public virtual List<Disciplina> ListaDisciplinas { get; set; }

        public int ProfessorID { get; set; }
        public virtual List<Professor> ListaProfessores { get; set; }
    }
}
