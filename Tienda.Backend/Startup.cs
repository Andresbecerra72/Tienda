using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tienda.Backend.Startup))]
namespace Tienda.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
