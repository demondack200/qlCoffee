using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlyCoffeeService
{
    public class UserService
    {
        public List<USER> getAllUser()
        {
            qlycaffeeEntities db = new qlycaffeeEntities();
            db.Configuration.LazyLoadingEnabled = false;
            List<USER> listOfUser = db.USERs.ToList();

            return listOfUser;
        }

    }
}
