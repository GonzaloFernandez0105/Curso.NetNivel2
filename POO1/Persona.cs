using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Persona
    {
        private string nombre;  
        private float sueldo;
        private int edad;

        public void setEdad(int e)
        { 
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }
    }
}
