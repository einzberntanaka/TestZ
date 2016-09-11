using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestZ.Startup))]
namespace TestZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
