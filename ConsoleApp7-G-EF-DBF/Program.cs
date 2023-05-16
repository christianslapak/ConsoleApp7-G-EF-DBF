using ConsoleApp7_G_EF_DBF.Modelos;
using System;
using System.Linq;

namespace ConsoleApp7_G_EF_DBF
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new SchoolDBContext();

            var Estudiantes = contexto.Student.ToList();
            foreach (var item in Estudiantes)
            {
                Console.WriteLine("Nombre:" + item.StudentName);
            }

            Console.ReadKey();


            Console.WriteLine("Estuiantes con letra d");
            var consulta = from estu in Estudiantes where estu.StudentName.Contains("d") select estu;

            foreach (var item in consulta)
            {
                Console.WriteLine("Nombre: " + item.StudentName);
            }

            Console.ReadKey();

            Console.WriteLine("Lambda con standardId = 1");
            var consulta2 = contexto.Student.Where(es => es.StandardId == 1).ToList();
            foreach (var item in consulta2)
            {
                Console.WriteLine("Nombre:" + item.StudentName);
            }
            Console.ReadKey();


            Console.WriteLine("agregamos un nuevo estudiante");
            contexto.Student.Add(new Student() { StudentName = "NUEVO", StandardId = 3 });
            contexto.SaveChanges();
            Console.ReadKey();
        }
    }
}
