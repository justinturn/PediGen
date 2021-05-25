using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PediGen.Models;
using System.Data.Entity.Migrations;
using PediGen.Controllers;

namespace PediGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //DB is in sql server object explorer (localdb)\MSSQLLocalDB
            InitializeComponent();


            AddDummyBreeders();


            
            MainController controller = new MainController();
            using (var context = new Models.PedigreeContext())
            {
                var litters = controller.CreateLitter(4, 4, 1, new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 6, 7, 8 }, 9, System.DateTime.Now, 48205005, 48729006, "NEGATIVE");
                context.Litters.AddOrUpdate(litters);

                context.SaveChanges();
            }


        }
        private void AddDummyBreeders()
        {
            var context = new Models.PedigreeContext();
            var breedess = context.Breeders.ToList();

            Breeder newBreeder = new Breeder();
            newBreeder.addressCity = "VELMA";
            newBreeder.addressState = "OKLAHOMA";
            newBreeder.addressStreet = "PO BOX 591";
            newBreeder.addressZip = "73491";
            //newBreeder.breederID = 67986;
            newBreeder.ownerNumber= 67986;
            newBreeder.herdmark = "RSR";
            newBreeder.name = "RAYMOND AND SHERYL RICE";
            context.Breeders.AddOrUpdate(newBreeder);


            Breeder newBreeder2 = new Breeder();
            newBreeder2.addressCity = "DOVER";
            newBreeder2.addressState = "ARKANSAS";
            newBreeder2.addressStreet = "";
            newBreeder2.addressZip = "72837";
            //newBreeder2.breederID = 62702;
            newBreeder2.ownerNumber= 62702;
            newBreeder2.herdmark = "RJM";
            newBreeder2.name = "JERRY MASTERS";
            context.Breeders.AddOrUpdate(newBreeder2);

            Breeder newBreeder3 = new Breeder();
            newBreeder3.addressCity = "GREENCASTLE";
            newBreeder3.addressState = "INDIANA";
            newBreeder3.addressStreet = "";
            newBreeder3.addressZip = "177";
            newBreeder3.ownerNumber = 1770;
           // newBreeder3.breederID = 1770;
            newBreeder3.herdmark = "KTB";
            newBreeder3.name = "KENT BRATTAIN & FAMILY";
            context.Breeders.AddOrUpdate(newBreeder3);

            context.SaveChanges();
        }

        private void AddPigs(ref Breeder breederObj, string notch, Boolean maleBool, string Reg, string stress)
        {
            breederObj.Pigs.Add(new Pig { EarNotch = notch, isMale = maleBool, RegistrationNumber = Reg, stressStatus = stress });
            
        }
    }

}
