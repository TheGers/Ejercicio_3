using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Conexion;
using Datos.Entidades;

namespace Ejercicio_3
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void ingreso_button_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Usuario user = new Usuario();
            user = conexion.user(usuario_textBox.Text, contra_textBox.Text);

            if (user ==  null)
            {

                MessageBox.Show("Datos Incorrectos en el login");
                return;


            }
            Lista_Usuarios frm2 = new Lista_Usuarios();
            frm2.Show();
           

        }

        private void cerrar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        
    }
}
