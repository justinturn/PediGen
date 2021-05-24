using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PediGen.Models
{
    class Breeder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int breederID { get; set; }
        public string herdmark { get; set; }
        public string name { get; set; }
        public string addressStreet { get; set; }
        public string addressCity { get; set; }
        public string addressState { get; set; }
        public string addressZip { get; set; }

        public virtual List<Litter> Litters { get; set; }
        public virtual List<Pig> Pigs { get; set; }
    }
}
