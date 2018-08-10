using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    class MatriculaViaTurmaViewModel
    {
        public Turma turma { get; set; }
        public List<Aluno> alunosParaMatricular { get; set; }
    }
}
