using Datos.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Lista_Usuarios : Form
    {
        public Lista_Usuarios()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
    
        private void Lista_Usuarios_Load(object sender, EventArgs e)
        {
            lista();
        }


        private void lista()
        {
            lista_users_dataGridView.DataSource = conexion.lista_regis();
        }
    }
}
