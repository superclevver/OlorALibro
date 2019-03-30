using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    public class Usuario:IEquatable<Usuario>
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public int codiPostal { get; set; }
        public int telefono { get; set; }
        public List<string> actividades { get; set; }

        public bool Equals(Usuario a)
        {
            bool igual = false;

            if (a.nombre == this.nombre &&
                a.edad == this.edad && 
                a.correo == this.correo &&
                a.codiPostal == this.codiPostal &&
                a.telefono == this.telefono)
            {
                igual = true;
            }
            return igual;
        }

    }
}
