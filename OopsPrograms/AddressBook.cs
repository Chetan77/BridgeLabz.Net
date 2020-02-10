using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OopsPrograms
{
    class AddressBook
    {
        public static void AddressBookTest()
        {
            GetPersonDetails();
        }
        public static void GetPersonDetails()
        {
            var JsonFile = File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\PersonDetails.json");
            try
            {
                var jObj = JsonConvert.DeserializeObject<List<Person>>(JsonFile);
                if (jObj != null)
                {
                    foreach (var js in jObj)
                    {

                        Console.WriteLine("Fisrt name is :" + js.FName);
                        Console.WriteLine("Last name is :" + js.LName);
                        Console.WriteLine("Last name is :" + js.Address);
                        Console.WriteLine("Street is " + js.Street);
                        Console.WriteLine("City is" + js.City);
                        Console.WriteLine("zip is" + js.Zip);
                        Console.WriteLine("phone number is " + js.PhoneNumber);
                    }
                    Console.WriteLine("To add person details enter 1");
                    int num = OopsUtility.IntInput();
                    if (num == 1)
                    {
                        Person obj = new Person();
                        obj = AddPeronDetails();
                        jObj.Add(obj);
                        string newJson = JsonConvert.SerializeObject(jObj);
                        File.WriteAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\PersonDetails.json", newJson);
                    }
                    Console.WriteLine("to delete a person details enter 2");
                    int n = OopsUtility.IntInput();
                    if (n == 2)
                    {
                        DeletePerson();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("exception in GetPersonDetails" + e.Message);
            }
        }
        public static Person AddPeronDetails()
        {
            Person obj = new Person();

            try
            {
                Console.WriteLine("enter persons first name");
                var name = OopsUtility.StringInput();
                Console.WriteLine("enter persons last name");
                var lName = OopsUtility.StringInput();
                Console.WriteLine("enter persons address");
                var address = OopsUtility.StringInput();
                Console.WriteLine("enter persons street name");
                var street = OopsUtility.StringInput();
                Console.WriteLine("enter persons city");
                var city = OopsUtility.StringInput();
                Console.WriteLine("enter zip code");
                var zip = OopsUtility.LongInput();
                Console.WriteLine("enter phone number");
                long phoneNumber = OopsUtility.LongInput();

                obj.FName = name;
                obj.LName = lName;
                obj.Address = address;
                obj.Street = street;
                obj.City = city;
                obj.Zip = zip;
                obj.PhoneNumber = phoneNumber;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception in AddPeronDetails" + e.Message);
            }

            return obj;
        }
        public static void DeletePerson()
        {
            var JsonFile = File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\PersonDetails.json");
            List<Person> obj = JsonConvert.DeserializeObject<List<Person>>(JsonFile);
            Console.WriteLine("enter the name to delete the details");
            string na = OopsUtility.StringInput();
            int count = 0;
            foreach (var ob in obj)
            {
                if (ob.FName != na)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            obj.RemoveAt(count);

            string newJson = JsonConvert.SerializeObject(obj);
            File.WriteAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\PersonDetails.json", newJson);

        }
        public static void PrintJson()
        {

            var JsonFile = File.ReadAllText(@"C:\Users\Bridge Labz\source\repos\OopsPrograms\PersonDetails.json");
            try
            {
                var ob = JsonConvert.DeserializeObject<List<Person>>(JsonFile);

                foreach (var js in ob)
                {

                    Console.WriteLine("Fisrt name is :" + js.FName);
                    Console.WriteLine("Last name is :" + js.LName);
                    Console.WriteLine("Last name is :" + js.Address);
                    Console.WriteLine("Street is " + js.Street);
                    Console.WriteLine("City is" + js.City);
                    Console.WriteLine("zip is" + js.Zip);
                    Console.WriteLine("phone number is " + js.PhoneNumber);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("exception in PrintJson" + e.Message);
            }
        }
    }
}
