using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objstud = new Student()
            {
                Id = 1, Name = "Dipak",Marks = 90.99F,
            };

            Console.WriteLine(objstud.Id);
            Console.WriteLine(objstud.Name);
            Console.WriteLine(objstud.Marks);
            Console.ReadKey();

        }

        public class Student
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public float Marks { get; set; }

            private string Email { get; set; }
        }
    }
}
