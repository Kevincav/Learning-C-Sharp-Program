using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeList.Startup))]
namespace EmployeeList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
