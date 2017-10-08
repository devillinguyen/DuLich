using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuLich.Startup))]
namespace DuLich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
