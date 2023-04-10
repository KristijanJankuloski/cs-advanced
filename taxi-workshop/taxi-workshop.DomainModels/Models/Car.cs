using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxi_workshop.DomainModels.Enums;

namespace taxi_workshop.DomainModels.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime LicensePlateExpireDate { get; set; }
        public List<Driver> AssignedDrivers { get; set; }

        public Car() { }
        public Car(string model, string licensePlate, DateTime licensePlateExpireDate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpireDate = licensePlateExpireDate;
            AssignedDrivers = new List<Driver>();
        }

        public ExpieryStatus IsLicenseExpiered()
        {
            if (DateTime.Today >= LicensePlateExpireDate)
                return ExpieryStatus.Expired;
            if (DateTime.Today.AddMonths(3) >= LicensePlateExpireDate)
                return ExpieryStatus.Warning;
            return ExpieryStatus.Valid;
        }

        public override string Print()
        {
            int assignedPercent = (AssignedDrivers.Count / 3) * 100;
            return $"{Model} with plate: {LicensePlate} and utilized {assignedPercent}%";
        }
    }
}
