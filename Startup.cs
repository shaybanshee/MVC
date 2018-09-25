using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicApp2.Startup))]
namespace MusicApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
