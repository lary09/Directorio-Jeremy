using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directorio
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string direccion { get; set; }
        public Usuarios()
        {

        }
        public Usuarios(int iD, string nombre, int telefono, string email, string direccion)
        {
            ID = iD;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            this.direccion = direccion;
        }
    }
}
