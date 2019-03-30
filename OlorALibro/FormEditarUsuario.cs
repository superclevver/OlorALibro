using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// COMENTADO
namespace OlorALibro
{
    public partial class FormEditarUsuario : Form
    {
        Usuario modificarUsuario;

        //--------------------CONSTRUCTORES--------------------//
        public FormEditarUsuario()
        {
            InitializeComponent();
        }
        public FormEditarUsuario(Usuario modificarUsuario)
        {
            InitializeComponent();
            this.modificarUsuario = modificarUsuario;
        }

        //--------------------LOAD--------------------//
        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            textBoxNombreUsuario.Text = modificarUsuario.nombre;
            textBoxEdadUsuarios.Text = modificarUsuario.edad.ToString();
            textBoxContraseñaUsuario.Text = modificarUsuario.contraseña;
            textBoxCodPostalUsuario.Text = modificarUsuario.codiPostal.ToString();
            textBoxCorreoUsuario.Text = modificarUsuario.correo;
            textBoxTelefonoUsuario.Text = modificarUsuario.telefono.ToString();
        }

        //--------------------BOTON GUARDAR--------------------//
        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            modificarUsuario.nombre = textBoxNombreUsuario.Text;
            modificarUsuario.edad = int.Parse(textBoxEdadUsuarios.Text);
            modificarUsuario.contraseña = textBoxContraseñaUsuario.Text;
            modificarUsuario.codiPostal = int.Parse(textBoxCodPostalUsuario.Text);
            modificarUsuario.correo = textBoxCorreoUsuario.Text;
            modificarUsuario.telefono = int.Parse(textBoxTelefonoUsuario.Text);
            this.Close();
        }
    }
}
