
namespace Clinic.Model
{
    public class Technical : Staff
    {
        public Specializations Specialization { get; set; }
        public Technical(string name) : base(name)
        {
            Specialization = Specializations.XrayTechnician;

        }
    }
}
