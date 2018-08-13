using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    public class MatriculaViewModel
    {
        public IEnumerable<Turma> turmasParaMatricula { get; set; }
        public Aluno alunosParaMatricular { get; set; }
    }
}
