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

namespace PediGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var context = new Models.PedigreeContext();

            Breeder newBreeder = new Breeder();

            newBreeder.addressCity = "VELMA";
            newBreeder.addressState = "OKLAHOMA";
            newBreeder.addressStreet = "PO BOX 591";
            newBreeder.addressZip = "73491";
            newBreeder.breederID = 67986;
            newBreeder.herdmark = "RSR";
            newBreeder.name = "RAYMOND AND SHERYL RICE";
            context.Breeders.Add(newBreeder);
            context.SaveChanges();
        }
    }

}
