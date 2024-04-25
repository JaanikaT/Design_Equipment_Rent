using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DesignEquipment.Models
{
    public class Comments
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public string? Name { get; set; }

        [NotNull]
        public string? Comment { get; set; }

        [ForeignKey("Equipment")]
        public int EquipmentId { get; set; }

        public virtual Equipment? Equipment { get; set; }
    }
}
