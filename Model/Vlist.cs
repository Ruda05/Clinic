

using System.Collections.Generic;

namespace Clinic.Model
{
    public class Vlist
    {
        private List<Vizit> VizitList;

        public Vlist()
        {
            VizitList = new List<Vizit>();

        }

        public void AddPacientVizit(Vizit vizit)
        {
            VizitList.Add(vizit);
        }
        
        
        public void DisplayList()
        {
            foreach (Vizit vizit in VizitList)
            {
                System.Console.WriteLine(vizit.Patient.Name);
            }
        }

    }
}
