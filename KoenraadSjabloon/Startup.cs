using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KoenraadSjabloon.Startup))]
namespace KoenraadSjabloon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
