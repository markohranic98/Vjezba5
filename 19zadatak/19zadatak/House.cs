using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadatak
{
    internal class House
    {
        public List<Room> Rooms { get; set; }

        public string ReportSensorData()
        {
            string returnMe = "";
            foreach(var item in Rooms)
            {
                returnMe += item.ReportSenzorData();
            }
            return returnMe;
        }
    }
}
