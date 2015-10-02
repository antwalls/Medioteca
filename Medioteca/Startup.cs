using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medioteca.Startup))]
namespace Medioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
