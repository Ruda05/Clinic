

namespace Clinic.Model
{
    public class Hygienist : Staff
    {
        public Specializations Specialization { get; set; }
        public Hygienist(string name) : base(name)
        {
            Specialization = Specializations.DentalHygienist;

        }
    }
}
