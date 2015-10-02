using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPdf.Startup))]
namespace MvcPdf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
