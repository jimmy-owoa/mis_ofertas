using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MisOfertas.Startup))]
namespace MisOfertas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
