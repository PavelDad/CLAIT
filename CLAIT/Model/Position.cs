using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    [Table("Positions")]
    public class Position : ISlaveTable, IComparable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
        public Position()
        {
            Employees = new List<Employee>();
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is Position)
            {
                return this.Name.CompareTo(((Position)obj).Name);
            }
            return 0;
        }
    }
}
