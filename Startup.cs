using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RMSAcademy.Startup))]
namespace RMSAcademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
