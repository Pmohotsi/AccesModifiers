using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.setBirthdate(new DateTime(1995, 02, 25));
            Console.WriteLine(person.getDate());
        }
    }
}
