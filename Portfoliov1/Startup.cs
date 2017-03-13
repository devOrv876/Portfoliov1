using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portfoliov1.Startup))]
namespace Portfoliov1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
