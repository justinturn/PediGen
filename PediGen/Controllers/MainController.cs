using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PediGen.Models;

namespace PediGen.Controllers
{
    class MainController
    {
        public void CreateLitter(int numMales, int numFemale, int numBornTotal, DateTime DOB, int sireReg, int damReg)
        {
            var newLitter = new Models.Litter();

            newLitter.damRegistration = damReg;
            newLitter.sireRegistration = sireReg;
            newLitter.numberBorn = numBornTotal;
            newLitter.numberBornAlive = numMales + numFemale;
        }
        private void CreateLitterID()
        {

        }

        private void CreateDummyListOfPigs()
        {
            Breeder newBreeder = new Breeder();

            newBreeder.addressCity = "VELMA";
            newBreeder.addressState = "OKLAHOMA";
            newBreeder.addressStreet = "PO BOX 591";
            newBreeder.addressZip = "73491";
            newBreeder.breederID = 67986;
            newBreeder.herdmark = "RSR";
            newBreeder.name = "RAYMOND AND SHERYL RICE";

            List<Pig> pigList = new List<Pig>();

            Pig newPig = new Pig();
            newPig.EarNotch = "1-1";
            newPig.isMale = true;
            newPig.PigID = 1;
            newPig.PigName = "RSR8 GRUS FLAT LINER";
            newPig.RegistrationNumber = "49730001";
            newPig.stressStatus = "NEGATIVE";
            pigList.Add(newPig);

            Pig newPig2 = new Pig();
            newPig2.EarNotch = "14-5";
            newPig2.isMale = true;
            newPig2.PigID = 2;
            newPig2.PigName = "CFLK7 GRUS FLAT LINER";
            newPig2.RegistrationNumber = "48205005";
            newPig2.stressStatus = "NEGATIVE";
            pigList.Add(newPig2);

            Pig newPig3 = new Pig();
            newPig3.EarNotch = "3-7";
            newPig3.isMale = true;
            newPig3.PigID = 3;
            newPig3.PigName = "STKY6 FIRST SIGHT";
            newPig3.RegistrationNumber = "47065003";
            newPig3.stressStatus = "NEGATIVE";
            pigList.Add(newPig3);

            Pig newPig4 = new Pig();
            newPig3.EarNotch = "9-5";
            newPig3.isMale = true;
            newPig3.PigID = 4;
            newPig3.PigName = "RSR2 ONE LOOK";
            newPig3.RegistrationNumber = "42601005";
            newPig3.stressStatus = "NEGATIVE";
            pigList.Add(newPig4);

            Pig newPig5 = new Pig();
            newPig3.EarNotch = "9-5";
            newPig3.isMale = true;
            newPig3.PigID = 4;
            newPig3.PigName = "RSR2 ONE LOOK";
            newPig3.RegistrationNumber = "42601005";
            newPig3.stressStatus = "NEGATIVE";
            pigList.Add(newPig4);

        }

    }
}
