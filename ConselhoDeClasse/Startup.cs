using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConselhoDeClasse.Startup))]
namespace ConselhoDeClasse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
