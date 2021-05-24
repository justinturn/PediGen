using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PediGen.Models
{
    class Litter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int litterID { get; set; }
        public int sireRegistration { get; set; }
        public int damRegistration { get; set; }
        public int numberBorn { get; set; }
        public int numberBornAlive { get; set; }

        public DateTime DOB { get; set; }
        public DateTime dateRegistered { get; set; }
        public virtual List<Pig> Pigs { get; set; }
    }
}
