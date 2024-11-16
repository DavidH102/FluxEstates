using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class Apartment : Residential
    {
        public int ApartmentId { get; set; }
        public int NumRooms { get; set; }
        public ObjectType Type { get; set; } = ObjectType.Apartment;

        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}