using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PediGen.Models
{
    class Pig
    {
        public int PigID { get; set; }
        public string PigName { get; set; }
        public string EarNotch { get; set; }
        public Boolean isMale { get; set; }
        public string RegistrationNumber { get; set; }
        public string stressStatus { get; set; }
        public virtual Litter Litter { get; set; }
    }
}
