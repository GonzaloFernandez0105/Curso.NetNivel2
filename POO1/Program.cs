using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.setEdad(20);
            Console.WriteLine($"La edad de p1 es {p1.getEdad()}");

            //

            Perro dog1 = new Perro();
            dog1.Nombre = "Peque";
            dog1.Raza = "Caniche";
            dog1.Origen = "Buenos Aires";

            Perro dog2 = new Perro();
            dog2.Nombre = "Luna";
            dog2.Raza = "Labrador";
            dog2.Origen = "BsAs";
        }

    }

}
