using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NordicTransportFinal.Startup))]
namespace NordicTransportFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
