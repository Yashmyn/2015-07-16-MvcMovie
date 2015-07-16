using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2015_07_16_MvcMovie.Startup))]
namespace _2015_07_16_MvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
