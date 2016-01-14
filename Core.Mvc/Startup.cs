using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Core.Mvc.Startup))]
namespace Core.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
