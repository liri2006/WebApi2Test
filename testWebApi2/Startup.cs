using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testWebApi2.Startup))]
namespace testWebApi2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
