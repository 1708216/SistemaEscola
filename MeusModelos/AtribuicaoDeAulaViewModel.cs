using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusModelos
{
    public class AtribuicaoDeAulaViewModel
    {
        public int TurmaID { get; set; }
        public virtual Turma _Turma { get; set; }

        public int ProfessorID { get; set; }
        public virtual Professor _Professor { get; set; }

        public int DisciplinaID { get; set; }
        public virtual List<Disciplina> ListaDisciplinas { get; set; }


    }
}
