using FluxEstates.Models.Distinct;

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