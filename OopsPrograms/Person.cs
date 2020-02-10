using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    class Person
    {
        private string fName;
        private string lName;
        private string address;
        private string street;
        private string city;
        private long zip;
        private long phoneNumber;

       

        public string FName { get =>fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Address { get => address; set => address = value; }
        public string Street { get => street; set => street = value; }
        public long Zip { get => zip; set => zip = value; }
        public string City { get => city; set => city = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
