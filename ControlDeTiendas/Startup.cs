using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlDeTiendas.Startup))]
namespace ControlDeTiendas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
