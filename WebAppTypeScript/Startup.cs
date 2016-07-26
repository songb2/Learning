using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTypeScript.Startup))]
namespace WebAppTypeScript
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
