using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Work.Startup))]
namespace MVC5Work
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
