using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ferramentas.Startup))]
namespace Ferramentas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
