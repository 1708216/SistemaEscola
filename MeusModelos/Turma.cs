using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MeusModelos
{
    public class Turma
    {
        public int TurmaID { get; set; }
        
        public string Serie { get; set; }
     
        public string Nome { get; set; }
        [Display(Name = "turno")]
        [Required(ErrorMessage = "Favor preencher o campo Título.")]
        public string Turno { get; set; }

        public int FichaDeMatriculaID { get; set; }
        public virtual List<FichaDeMatricula> _Matriculas { get; set; }

        public int FichaDeDistribuicaoID { get; set; }
        public virtual List<FichaDeDistribuicao> _DistribuicaoAula { get; set; }

    }
}
