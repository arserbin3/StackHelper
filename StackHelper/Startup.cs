using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StackHelper.Startup))]
namespace StackHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
