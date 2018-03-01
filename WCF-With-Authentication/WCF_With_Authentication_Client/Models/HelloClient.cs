using System;
using System.ServiceModel.Security;
using WCF_With_Authentication_Client.ServiceReferenceClient;

namespace WCF_With_Authentication_Client.Models
{
    public class HelloClient
    {
        public string HelloWord()
        {
            try
            {
                HelloServiceClient shc = new HelloServiceClient();
                shc.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode =
                    X509CertificateValidationMode.None;
                shc.ClientCredentials.UserName.UserName="acc1";
                shc.ClientCredentials.UserName.Password="123";
                return shc.HelloWord();
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}