using System.ComponentModel.DataAnnotations;


namespace MeusModelos
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public string CargaHoraria { get; set; }
    }
}
