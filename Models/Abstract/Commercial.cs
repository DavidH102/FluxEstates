namespace FluxEstates.Models.Abstract
{
    public abstract class Commercial : Estate
    {
        // fields
        public int CommercialId { get; set; }

        public string CompanyName { get; set; }
        public int SquareFootage { get; set; }

        // methods
        public override double CaculateNumberOfRooms()
        {
            var StandardRoomSquareFootage = 140;
            return SquareFootage / StandardRoomSquareFootage;
        }
    }
}