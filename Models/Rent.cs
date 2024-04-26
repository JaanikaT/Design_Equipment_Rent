namespace DesignEquipment.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public string? Reason { get; set; }

        public bool Expired { get; set; }

        public int EquipmentId { get; set; }

        public virtual Equipment? Equipment { get; set; }

        public int PersonId { get; set; }

        public virtual Person? Person { get; set; }
    }
}
