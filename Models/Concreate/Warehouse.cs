using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class Warehouse : Commercial
    {
        public int WarehouseId { get; set; }
        public int Capacity { get; set; }

        public ObjectType Type { get; set; } = ObjectType.Warehouse;

        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}