using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelSample.Startup))]
namespace ModelSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
