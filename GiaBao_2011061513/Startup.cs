using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiaBao_2011061513.Startup))]
namespace GiaBao_2011061513
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
