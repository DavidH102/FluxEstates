using FluxEstates.Models.Distinct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxEstates.Models.Concreate.Subclasses
{
    public class Tenement : Apartment
    {

        public int TenementId { get; set; }
        public int NumOfFloors { get; set; }
        public ObjectType Type { get; set; } = ObjectType.Tenement;



        public void SetParentId()
        {
            base.ApartmentId = TenementId;
        }
    }
}
