using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTrinhNamTrung_2011063302.Startup))]
namespace NguyenTrinhNamTrung_2011063302
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
