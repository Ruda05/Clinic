
namespace Clinic.Model
{
    public class Dentist : Staff
    {
        public Specializations Specialization { get; set; }
        public Dentist(string name) : base(name)
        {
            Specialization = Specializations.Dentist;

        }
    }
}
