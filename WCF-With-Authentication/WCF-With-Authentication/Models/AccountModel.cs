using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_With_Authentication.Models
{
    public class AccountModel
    {
        private List<Account> listAccount = new List<Account>();

        public AccountModel()
        {
            listAccount.Add(new Account{UserName = "acc1", Password = "123"});
            listAccount.Add(new Account{UserName = "acc2", Password = "123"});
            listAccount.Add(new Account{UserName = "acc3", Password = "123"});
        }

        public bool Login(string userName, string password)
        {
            return listAccount.Any(acc => acc.UserName.Equals(userName) && acc.Password.Equals(password));
        }
    }
}