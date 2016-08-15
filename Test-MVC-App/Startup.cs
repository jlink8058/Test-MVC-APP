using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_MVC_App.Startup))]
namespace Test_MVC_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
