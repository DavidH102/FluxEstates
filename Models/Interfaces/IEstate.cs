using FluxEstates.Models.Distinct;

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