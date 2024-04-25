namespace DesignEquipment.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public string? Reason { get; set; }

        public string? Email { get; set; }

        public bool Expired { get; set; }

        public int EquipmentId { get; set; }

        public virtual Equipment? Equipment { get; set; }
    }
}
