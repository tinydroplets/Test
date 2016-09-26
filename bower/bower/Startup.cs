using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bower.Startup))]
namespace bower
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
