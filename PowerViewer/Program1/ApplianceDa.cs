//Loren Wetzel
//Program 1 - Power Viewer
//1/22/18

using System;
using System.Collections.Generic;
using System.IO;

namespace Program1
{
    public static class ApplianceDA
    {
        //this will need to be changed to wherever you store the Watts.cvs file. I had it on my thumb drive.
        private const string dir = @"H:\C#\PowerViewer\Program1\";
        private const string path = dir + "Watts.csv";

        public static List<Appliance> GetAppliances()
        {

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));

            // create the list
            List<Appliance> appliances = new List<Appliance>();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                Appliance appliance = new Appliance();
                appliance.AppType = columns[0];
                appliance.Watts = Convert.ToDouble(columns[1]);
                appliances.Add(appliance);

            }

            // close the input stream for the text file
            textIn.Close();

            return appliances;
        }
    }
}
