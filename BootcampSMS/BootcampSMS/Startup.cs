using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootcampSMS.Startup))]
namespace BootcampSMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
