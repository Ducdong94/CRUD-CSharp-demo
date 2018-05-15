using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD_demo.Startup))]
namespace CRUD_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
