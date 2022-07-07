using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string AccountNumber { get; set; }
        public string PrimaryPersonFirstName { get; set; }
        public string PrimaryPersonLastName { get; set; }
        public string Email { get; set; }
        public string PhoneCountry { get; set; }
        public string PhoneArea { get; set; }
        public string PhoneNumber { get; set; }
        public string FoxCountry { get; set; }
        public string FoxArea { get; set; }
        public string FoxNumber { get; set; }
        public string MobileCountry { get; set; }
        public string MobileArea { get; set; }
        public string MobileNumber { get; set; }
        public string DirectDialCountry { get; set; }
        public string DirectDialArea { get; set; }
        public string DirectDialNumber { get; set; }
        public string SkypeName { get; set; }
        public string Website { get; set; }
        public string PostalAttention { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCityTown { get; set; }
        public string PostalStateRegion { get; set; }
        public string PostalZIP { get; set; }
        public string PostalCountry { get; set; }
        public string StreetAttention { get; set; }
        public string StreetAddress { get; set; }
        public string StreetCityTown { get; set; }
        public string StreetStateRegion { get; set; }
        public string StreetZIP { get; set; }
        public string StreetCountry { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }

    public class CustomerLog
    {
        public long ID { get; set; }
        public string GroupID { get; set; }
        public int CustomerID { get; set; }
        public string Description { get; set; }
        public DateTime TrxDateTime { get; set; }
        public string UserName { get; set; }
    }
}
