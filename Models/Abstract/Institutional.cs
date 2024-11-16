namespace FluxEstates.Models.Abstract
{
    public abstract class Institutional : Estate
    {
        // fields
        public string InstitutionName { get; set; }

        public int Capacity { get; set; }

        // methods
        public override double CaculateNumberOfRooms()
        {
            return Capacity;
        }
    }
}