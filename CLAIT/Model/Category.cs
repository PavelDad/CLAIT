using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    [Table("Categories")]
    public class Category : ISlaveTable, IComparable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Equipment> Equipments { get; set; }
        public Category()
        {
            Equipments = new List<Equipment>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Category)
            {
                return this.Name.CompareTo(((Category)obj).Name);
            }
            return 0;
        }
    }
}
