using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prototipo2.Startup))]
namespace Prototipo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
