using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlyCoffeeService
{
    public class AccountService
    {
        public ACCOUNT getAccount(string username, string password)
        {
            qlycaffeeEntities db = new qlycaffeeEntities();
            ACCOUNT foundAccount = null;
            foundAccount = db.ACCOUNTs.Where(acc => acc.USERNAME == username && acc.PASSWORD == password).SingleOrDefault();

            return foundAccount;
        }
    }
}
