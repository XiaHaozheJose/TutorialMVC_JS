using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialMVC.Startup))]
namespace TutorialMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
