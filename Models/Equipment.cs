using System.Numerics;

namespace DesignEquipment.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public BigInteger? SerialNumber { get; set; }
        public BigInteger? Barcode { get; set; }
        public string? Name { get; set; }
        public int MyProperty { get; set; }
        public string? Remark { get; set; }
        public string? Category { get; set; }
    }
}
