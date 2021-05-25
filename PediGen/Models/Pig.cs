using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PediGen.Models
{
    class Pig
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PigID { get; set; }
        public string PigName { get; set; }
        public string EarNotch { get; set; }
        public Boolean isMale { get; set; }
        [Key, Column(Order = 1)]
        public string RegistrationNumber { get; set; }
        public string stressStatus { get; set; }
        public virtual Litter Litter { get; set; }
    }
}
