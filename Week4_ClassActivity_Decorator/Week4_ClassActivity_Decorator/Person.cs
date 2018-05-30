using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassActivity_Decorator
{
    public interface IPerson
    {
        string Name { get; set; }
        string Display();
    }
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Display()
        {
            return Name;
        }
    }

    public class EmailDecorator : IPerson
    {
        IPerson person;
        public string Email { get; set; }
        public string Name { get; set; }
        public EmailDecorator(IPerson p)
        {
            person = p;
        }
        public string Display()
        {
            string data = person.Name;
            data += " has an email : "+Email;
            return data;
        }
    }
    public class PhoneDecorator : IPerson
    {
        IPerson person;
        public string Phone { get; set; }
        public string Name { get; set; }
        public PhoneDecorator(IPerson p)
        {
            person = p;
        }
        public string Display()
        {
            string data = person.Name;
            data += " has a phone number : "+Phone;
            return data;
        }
    }
    public class SchoolDecorator : IPerson
    {
        IPerson person;
        public string Name { get; set; }
        public SchoolDecorator(IPerson p)
        {
            person = p;
        }
        public string AddBehaviour()
        {
            return "is going to school.";
        }
        public string Display()
        {
            return person.Name;
        }
    }
}
