using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxi_workshop.DomainModels.Enums;

namespace taxi_workshop.Desktop.Models
{
    public class DriverLicenseDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public string License { get; set; }
        public string LicenseExpieryDate { get; set; }
        public ExpieryStatus Status { get; set; }

        public DriverLicenseDisplay(string firstName, string lastName, Shift shift, string license, DateTime licenseDate, ExpieryStatus status)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            License = license;
            LicenseExpieryDate = licenseDate.ToShortDateString();
            Status = status;
        }
        public DriverLicenseDisplay(){
            FirstName = string.Empty;
            LastName = string.Empty;
            License = string.Empty;
            LicenseExpieryDate = string.Empty;
        }
    }
}
