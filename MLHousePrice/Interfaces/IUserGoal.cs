using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLHousePrice.BLL;

namespace MLHousePrice.Interfaces
{
    public interface IUserGoal
    {
        bool UserGoalMLModel(string goal);
    }
}
