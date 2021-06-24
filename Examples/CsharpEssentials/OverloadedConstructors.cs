using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEssentials
{
    class Customer
    {
        // string name(m), id(m), address(O), contactNumber,  adharNumber(M), panCardNumber(M), emailId(o);
        string name, id, address, contactNumber, adharNumber, panCardNumber, emailId;

        //OverLoaded Constructor
        public Customer(string name, string adhar, string panCard)
        {
            this.name = name;
            this.adharNumber = adhar;
            this.panCardNumber = panCard;
        }
        public Customer(string name, string adhar, string panCard, string contactNumber) : this(name, adhar, panCard)
        {
            this.contactNumber = contactNumber;
        }
        public Customer(string name, string adhar, string panCard, string contactNumber, string emailId) : this(name, adhar, panCard, contactNumber)
        {
            this.emailId = emailId;

        }

    }
}
