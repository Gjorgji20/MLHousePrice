using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.BLL
{
    public class Credit
    {

        [LoadColumn(0)]

        public float Amount { get; set; }


        [LoadColumn(1)]
        public string Status { get; set; }

        [LoadColumn(2)]

        public string FamilyStatus { get; set; }


        [LoadColumn(3)]

        public float Duration { get; set; }

        [LoadColumn(4)]

        public float Interest { get; set; }
        [LoadColumn(5)]

        public float Installment { get; set; }

    }
}
