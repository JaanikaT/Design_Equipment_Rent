using System.ComponentModel.DataAnnotations.Schema;

namespace DesignEquipment.Models
{
    public class Comments
    {
        public int Id { get; set; }

        public int Score { get; set; }
        [ForeignKey("Rent")]
        public int RentId { get; set; }

        public DateTime Date { get; set; }

        public virtual Rent? Rent { get; set; }

    }
}
