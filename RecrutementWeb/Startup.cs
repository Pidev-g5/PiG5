using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecrutementWeb.Startup))]
namespace RecrutementWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
