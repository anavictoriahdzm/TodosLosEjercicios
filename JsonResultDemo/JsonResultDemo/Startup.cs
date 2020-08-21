using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsonResultDemo.Startup))]
namespace JsonResultDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
