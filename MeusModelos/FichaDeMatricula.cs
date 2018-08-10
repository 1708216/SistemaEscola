using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    class FichaDeMatricula
    {
        public int FichaDeMatriculaID { get; set; }

        public int AlunoID { get; set; }
        public virtual Aluno _Aluno { get; set; }

        public int TurmaID { get; set; }
        public virtual Turma _Turma { get; set; }

    }
}
