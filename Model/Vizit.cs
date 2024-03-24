

using System.Collections.Generic;

namespace Clinic.Model
{
    public class Vizit
    {
        public Patient Patient { get;}
        public string TypeOfProcedure { get; set; }
        public string Description { get; set; }
        public string Tooth { get; set; }

        public List<Staff> StaffInvolved;

        public Vizit(Patient pacient, string typeOfProcedure, string description, string tooth)
        {
            StaffInvolved = new List<Staff>();
            Patient = pacient;
            TypeOfProcedure = typeOfProcedure;
            Description = description;  
            Tooth = tooth;
            AddVizit();
            Patient.ChangeLoyalty();
        }

        public void AddVizit()
        {
            Patient.NumberOfVizits++;
           
        }
        public void AddStaff(Staff staff)
        {
            StaffInvolved.Add(staff);
        }
    }
}
