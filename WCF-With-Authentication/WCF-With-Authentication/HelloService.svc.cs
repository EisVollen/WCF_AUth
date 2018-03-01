using System.ServiceModel.Activation;

namespace WCF_With_Authentication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloService.svc or HelloService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class HelloService : IHelloService
    {
        public string HelloWord()
        {
            return "Hello Word!";
        }
    }
}
