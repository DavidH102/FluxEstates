using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate.Subclasses
{
    public class Rental : Apartment
    {
        public int RentalId { get; set; }

        public int LeaseLenthsInMonths { get; set; }

        public ObjectType Type { get; set; } = ObjectType.Rental;
    }
}