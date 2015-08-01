using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentalConsulting.Startup))]
namespace DentalConsulting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
