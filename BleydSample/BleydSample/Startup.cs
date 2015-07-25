using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BleydSample.Startup))]
namespace BleydSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
