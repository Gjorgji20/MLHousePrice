using MLHousePrice.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.Interfaces
{
    public interface ICredit
    {
        float CreditMLModel(float Cena);
    }
}
