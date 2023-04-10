using taxi_workshop.DomainModels.Enums;

namespace taxi_workshop.DomainModels.Models
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public Car Car { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpieryDate { get; set; }

        public Driver() { }
        public Driver(string firstName, string lastName, Shift shift, Car car, string license, DateTime licenseExpieryDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            License = license;
            LicenseExpieryDate = licenseExpieryDate;
        }

        public ExpieryStatus IsLicenseExpiered()
        {
            if (DateTime.Today >= LicenseExpieryDate)
                return ExpieryStatus.Expired;
            if (DateTime.Today.AddMonths(3) >= LicenseExpieryDate)
                return ExpieryStatus.Warning;
            return ExpieryStatus.Valid;
        }

        public override string Print()
        {
            string model = Car == null ? "/" : Car.Model;
            return $"{FirstName} {LastName} driving in the shift {Shift} with {model} car";
        }
    }
}
