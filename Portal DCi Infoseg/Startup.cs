using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portal_DCi_Infoseg.Startup))]
namespace Portal_DCi_Infoseg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
