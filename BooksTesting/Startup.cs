using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksTesting.Startup))]
namespace BooksTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
