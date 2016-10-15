using Microsoft.Owin;
using Owin;

// Owin.org

[assembly: OwinStartupAttribute(typeof(MVC5Course.Startup))]
namespace MVC5Course
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
