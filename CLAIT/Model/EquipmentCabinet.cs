using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    [Table("EquipmentsCabinets")]
    public class EquipmentCabinet
    {
        public int Id { get; set; }
        public string EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public int? CabinetId { get; set; }
        public virtual Cabinet Cabinet { get; set; }
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public DateTime InstallationDate { get; set; }
    }
}
