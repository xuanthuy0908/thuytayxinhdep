using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trankimxuanthuy_lab_456.Startup))]
namespace trankimxuanthuy_lab_456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
