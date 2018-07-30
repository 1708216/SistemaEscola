using System.Data.Entity;
using MeusModelos;


namespace ConselhoDeClasse.Models.Dal
{
    public class MeuContexto:DbContext
    {
        public MeuContexto() : base ("strConn")
        {
            Database.SetInitializer(new ConselhoDeClasseDBInitializer());
        }
    
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }

    }
}