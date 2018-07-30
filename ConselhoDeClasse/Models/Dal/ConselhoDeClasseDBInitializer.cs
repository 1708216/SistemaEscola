using System.Data.Entity;
using MeusModelos;

namespace ConselhoDeClasse.Models.Dal
{
    public class ConselhoDeClasseDBInitializer : DropCreateDatabaseIfModelChanges<MeuContexto>
    {

        protected override void Seed(MeuContexto meuContexto)
        {
            Usuario usuario = (new Usuario()
            {
                Nome="GRAZIELA",
              
            });
            meuContexto.Usuarios.Add(usuario);
            meuContexto.SaveChanges();
        }

    }
}