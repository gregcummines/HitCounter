using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HitCounter.Startup))]
namespace HitCounter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
