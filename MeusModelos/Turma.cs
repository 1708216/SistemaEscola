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
    }
}
