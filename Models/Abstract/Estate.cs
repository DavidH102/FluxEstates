using FluxEstates.Models.Distinct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxEstates.Models.Distinct;
using FluxEstates.Models.Interfaces;

namespace FluxEstates.Models.Abstract
{
    public abstract class Estate : IEstate
    {
       

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public CountryEnum Country { get; set; }

        public abstract double CaculateNumberOfRooms();

    

        public abstract void SomeMethod();
    }
}
