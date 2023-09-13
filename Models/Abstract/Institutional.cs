using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxEstates.Models.Abstract
{
    public abstract class Institutional : Estate
    {

        // fields
        public string InstitutionName { get; set; }
        public int Capacity { get; set; }

        // methods
        public override double CaculateNumberOfRooms()
        {
            return Capacity;
        }
    }
}
