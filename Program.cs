using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vlist vizitList = new Vlist();
            Patient  one = new Patient (1, "Gosia");
            Patient two = new Patient(2, "Basia");
            Patient three = new Patient(3, "Krzyś");
            Staff doctorOne = new Dentist( "Zenek");
            Staff doctorTwo = new Dentist("Romuś");
            Staff doctorThree = new Dentist("Adela");
            var vizitOne = new Vizit(one, "tooth", "zabieg", "LG8");
            vizitOne.AddStaff(doctorOne);
            Console.WriteLine(one.NumberOfVizits);
            vizitList.AddPacientVizit(vizitOne);
            vizitList.DisplayList();
            Console.ReadLine();
        }
    }
}
