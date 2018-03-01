using System.ServiceModel;

namespace WCF_With_Authentication
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string HelloWord();
    }
}
