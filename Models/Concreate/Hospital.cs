using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class Hospital : Institutional
    {
        private int HospitalId { get; set; }
        public int NumBeds { get; set; }

        public ObjectType Type { get; set; } = ObjectType.Hospital;

        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}