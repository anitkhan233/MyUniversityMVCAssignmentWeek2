using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyUniversityMVCAssignmentWeek2.Startup))]
namespace MyUniversityMVCAssignmentWeek2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
