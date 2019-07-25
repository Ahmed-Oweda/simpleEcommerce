using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MatrixApp.Startup))]
namespace MatrixApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
