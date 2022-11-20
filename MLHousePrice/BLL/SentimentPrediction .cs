using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace MLHousePrice.BLL
{
    public class SentimentPrediction 
    {

        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

    }
}
