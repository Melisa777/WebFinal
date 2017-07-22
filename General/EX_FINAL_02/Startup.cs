using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EX_FINAL_02.Startup))]
namespace EX_FINAL_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
