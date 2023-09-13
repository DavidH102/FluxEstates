using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class Villa : Residential
    {

        int VillaId { get; set; }
        public string PoolType { get; set; }

        public ObjectType Type { get; set; } = ObjectType.Villa;
        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}
