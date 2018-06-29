//Loren Wetzel
//Program 1 - Power Viewer
//1/22/18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Appliance
    {
        public string AppType { get; set; }
        public double Watts { get; set; }

        public Appliance()
        {

        }

        public Appliance(string appType, double watts)
        {
            this.AppType = appType;
            this.Watts = watts;
        }

        public override string ToString()
        {
            return AppType + " " + Watts;
        }


    }
}
