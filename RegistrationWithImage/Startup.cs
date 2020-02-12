using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegistrationWithImage.Startup))]
namespace RegistrationWithImage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
