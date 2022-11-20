using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.BLL
{
    public class PredictionPrice
    {
        [ColumnName("Score")]
        public float Price { get; set; }
    }
}
