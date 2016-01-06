using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalMystery.Startup))]
namespace MedicalMystery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
