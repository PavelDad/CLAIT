using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    [Table("Employees")]
    public class Employee : IComparable, INameble
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public int? PositionId { get; set; }
        public virtual Position Position { get; set; }

        public virtual List<EquipmentCabinet> EquipmentCabinets { get; set; }
        public Employee()
        {
            EquipmentCabinets = new List<EquipmentCabinet>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Employee)
            {
                return this.Name.CompareTo(((Employee)obj).Name);
            }
            return 0;
        }
    }
}
