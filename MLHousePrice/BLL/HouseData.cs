using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.BLL
{
    public class HouseData
    {
        [LoadColumn(0)]

        public float Size { get; set; }


        [LoadColumn(1)]
        public float Price { get; set; }

        [LoadColumn(2)]
        public float YearBuilt { get; set; }

        [LoadColumn(3)]

        public string RoofStyle { get; set; }


    }
}
