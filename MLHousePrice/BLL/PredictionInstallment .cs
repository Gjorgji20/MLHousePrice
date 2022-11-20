using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.BLL
{
    public class PredictionInstallment
    {
        [ColumnName("Score")]
        public float Installment { get; set; }
    }
}
