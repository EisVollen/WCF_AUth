using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using WCF_With_Authentication.Models;


namespace WCF_With_Authentication.App_Code.Authentication
{
    public class CustomValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            AccountModel am = new AccountModel();
            if (am.Login(userName, password))
            {
                return;
            }

            throw new SecurityTokenException("Account Invalid");
        }
    }
}