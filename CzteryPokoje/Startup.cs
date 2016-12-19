using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CzteryPokoje.Startup))]
namespace CzteryPokoje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
