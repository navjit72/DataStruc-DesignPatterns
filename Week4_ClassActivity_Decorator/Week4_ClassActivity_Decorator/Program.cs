using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassActivity_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson p1 = new Person();
            Console.WriteLine("****************Email decorator***************");
            EmailDecorator ed = new EmailDecorator(p1);
            p1.Name = "ABC";
            ed.Email = "abc@gmail.com";
            Console.WriteLine(ed.Display());
            Console.WriteLine("****************Phone decorator***************");
            PhoneDecorator pd = new PhoneDecorator(p1);
            p1.Name = "XYZ";
            pd.Phone = "642354653435";
            Console.WriteLine(pd.Display());
            Console.WriteLine("****************School decorator***************");
            SchoolDecorator sd = new SchoolDecorator(p1);
            p1.Name = "Navjit";
            Console.WriteLine(sd.Display() +" " +sd.AddBehaviour());
            Console.Read();
        }
    }
}
