using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    [Table("Cabinets")]
    public class Cabinet : ISlaveTable, IComparable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<EquipmentCabinet> EquipmentCabinets { get; set; }
        public Cabinet()
        {
            EquipmentCabinets = new List<EquipmentCabinet>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Cabinet)
            {
                return this.Name.CompareTo(((Cabinet)obj).Name);
            }
            return 0;
        }
    }
}
