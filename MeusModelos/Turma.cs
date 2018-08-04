using System.ComponentModel.DataAnnotations;


namespace MeusModelos
{
    public class Turma
    {
        public int TurmaID { get; set; }
        public string Serie { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public string Turno { get; set; }
    }
}
