using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class University : Institutional
    {

        int UniversityId { get; set; }
        public string[] Faculties { get; set; }
        
        
        public ObjectType Type { get; set; } = ObjectType.University;
        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}
