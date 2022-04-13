using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadatak
{
    internal class Room
    {
        public string Name { get; set; }
        public List<Senzor> Senzors = new List<Senzor>();

        public Room(string name)
        {
            Name = name;
        }
        public string ReportSenzorData()
        {
            string returnMe = "";
            foreach (var item in Senzors)
            {
                returnMe += "Current value for sensor "+item.Identifier+" is "+item.GetCurrentValue()+ " " +item.Unit + "\r\n";
            }
            return returnMe;
        }
    }
}
