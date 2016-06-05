using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmoghSystems.Startup))]
namespace AmoghSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //
        }
    }
}
