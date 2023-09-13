using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxEstates.Models.Abstract
{
    public abstract class Residential : Estate
    {
     
        // fields
        public int NumBedrooms { get; set; }
        public int NumBathrooms { get; set; }


        public override double CaculateNumberOfRooms()
        {
            return NumBedrooms + NumBathrooms;
        }

    }

}
