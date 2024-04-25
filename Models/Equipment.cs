using System.Numerics;

namespace DesignEquipment.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Barcode { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
    }
}
