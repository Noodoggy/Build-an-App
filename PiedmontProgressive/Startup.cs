using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiedmontProgressive.Startup))]
namespace PiedmontProgressive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
