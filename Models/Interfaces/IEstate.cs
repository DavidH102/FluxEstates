using FluxEstates.Models.Distinct;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxEstates.Models.Interfaces
{
    public interface IEstate
    {
        int Id { get; set; }
        string Street { get; set; }
        int ZipCode { get; set; }
        string City { get; set; }
        CountryEnum Country { get; set; }
    }

   

}
