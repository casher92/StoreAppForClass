using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreForClass.Startup))]
namespace StoreForClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
