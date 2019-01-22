using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnvioEncomenda.Startup))]
namespace EnvioEncomenda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
