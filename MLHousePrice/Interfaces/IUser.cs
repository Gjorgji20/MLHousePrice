using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.Interfaces
{
    public interface IUser
    {
        DataSet GetUser(string Account, string Pass);
        void    SaveUser(string Name, string Surname, string Education,int Age, bool WorkingStatus, string Account, string Password);
    }
}
