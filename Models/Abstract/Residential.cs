namespace FluxEstates.Models.Abstract
{
    public abstract class Residential : Estate
    {
        // fields
        public int NumBedrooms { get; set; }

        public int NumBathrooms { get; set; }

        public override double CaculateNumberOfRooms()
        {
            return NumBedrooms + NumBathrooms;
        }
    }
}