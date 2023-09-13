using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class School : Institutional
    {
     

        int SchoolId { get; set; }
        public int NumClassrooms { get; set; }

        public ObjectType Type { get; set; } = ObjectType.School;
        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}
