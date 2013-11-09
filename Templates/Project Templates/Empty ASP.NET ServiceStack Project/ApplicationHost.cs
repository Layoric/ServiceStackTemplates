using Funq;
using ServiceStack.WebHost.Endpoints;

namespace $safeprojectname$
{
    public class ApplicationHost : AppHostBase
    {
        public ApplicationHost() //Tell ServiceStack the name and where to find your web services
            : base("Empty ASP.NET ServiceStack Project", typeof(ApplicationHost).Assembly)
        {
            //Configure User Defined REST Paths via 'Routes' or Attribute request DTOs
            
        }

        public override void Configure(Container container)
        {
            //Configure IoC
        }
    }
}