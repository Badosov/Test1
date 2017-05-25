using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftomateTestTask_1.Startup))]
namespace SoftomateTestTask_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
