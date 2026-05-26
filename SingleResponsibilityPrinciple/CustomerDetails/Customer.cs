using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }

        public Customer(string customerId, string customerName, string contactNumber,
            string emailId, string address)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.ContactNumber = contactNumber;
            this.EmailId = emailId;
            this.Address = address;
        }

        public string GetCustomerDetails()
        {
            string details = string.Format("{0, -15}: {1}\n{2, -15}: {3}\n{4, -15}: {5}\n" +
                "{6, -15}: {7}\n{8, -15}: {9}",
                "Customer Id", this.CustomerId, "Customer Name", this.CustomerName,
                "ContactNumber", this.ContactNumber, "Email Id", this.EmailId,
                "Address", this.Address);
            return details;
        }

        public string UpdateContactDetails(string contactNumber, string emailId, string address)
        {
            if (contactNumber != null)
            {
                this.ContactNumber = contactNumber;
            }
            if (emailId != null)
            {
                this.EmailId = emailId;
            }
            if (address != null)
            {
                this.Address = address;
            }
            return "\nContact Details UPDATED successfully!";
        }


    }
}
