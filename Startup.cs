using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarBox3.Startup))]
namespace StarBox3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
