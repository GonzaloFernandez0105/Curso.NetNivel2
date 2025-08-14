using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Perro
    {
        private string nombre;
        private string raza;
        private string origen;

        public string Nombre
            {
            get { return nombre; }
            set { nombre = value; }
            }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
    }
}
