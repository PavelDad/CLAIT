using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    [Table("Equipments")]
    public class Equipment : IComparable
    {
        [Key]
        public string Id { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int? ProducerId { get; set; }
        public virtual Producer Producer { get; set; }
        [Required]
        public string Model { get; set; }
        public DateTime EntranceDate { get; set; }

        public virtual List<EquipmentCabinet> EquipmentCabinets { get; set; }
        public Equipment()
        {
            EquipmentCabinets = new List<EquipmentCabinet>();
        }

        public int CompareTo(object obj)
        {
            if (obj is Equipment)
            {
                return this.Id.CompareTo(((Equipment)obj).Id);
            }
            return 0;
        }
    }
}
