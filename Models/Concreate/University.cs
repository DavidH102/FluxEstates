using FluxEstates.Models.Abstract;
using FluxEstates.Models.Distinct;

namespace FluxEstates.Models.Concreate
{
    public class University : Institutional
    {
        private int UniversityId { get; set; }
        public string[] Faculties { get; set; }

        public ObjectType Type { get; set; } = ObjectType.University;

        public override void SomeMethod()
        {
            // implementation goes here
        }
    }
}