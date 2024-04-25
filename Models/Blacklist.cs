using System.ComponentModel.DataAnnotations.Schema;

namespace DesignEquipment.Models
{
    public class Blacklist
    {
        public int Id { get; set; }

        public int Points { get; set; }

        [ForeignKey("Rent")]
        public int RentId { get; set; }

        public virtual Rent Rent { get; set; }
    }
}
