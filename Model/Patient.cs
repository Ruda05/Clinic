

namespace Clinic.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfVizits { get; set; }
        public bool IsLoyal = false;   

        public Patient(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void ChangeLoyalty()
        {
            if (NumberOfVizits == 3)
            {
                IsLoyal = true;
            }
        }
    }
}
