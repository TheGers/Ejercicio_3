using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public String Codigo_Usuario { get; set; }
        public String Contraseña { get; set; }
        public String Nombre_usuario { get; set; }
        public int edad { get; set; }

        public Usuario(string codigo_Usuario, string contraseña, string nombre_usuario, int edad)
        {
            Codigo_Usuario = codigo_Usuario;
            Contraseña = contraseña;
            Nombre_usuario = nombre_usuario;
            this.edad = edad;
        }

        public Usuario()
        {
            //constrcutor vacio
        }
    }
}
