using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
// COMENTADO
namespace OlorALibro
{
    public partial class FormLogin : Form
    {
        Usuario admnistrador = new Usuario();

        //--------------------CONSTRUCTOR--------------------//
        public FormLogin()
        {
            // esto es el splash
            Thread tardar = new Thread(new ThreadStart(pantalla));
            tardar.Start();
            Thread.Sleep(8000); // la rapidesa que va en avançar
            InitializeComponent();
            tardar.Abort();
        }
        public void pantalla() { Application.Run(new FormInicio()); }

        //--------------------LOAD--------------------//
        private void FormLogin_Load(object sender, EventArgs e)
        {
            admnistrador.nombre = "admin";
            admnistrador.contraseña = "admin";
        }

        //--------------------BOTON ACEPTAR--------------------//
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //comprobamos si los datos introducidos son iguales a los de administrador
            if (textBoxNombre.Text == admnistrador.nombre && textBoxContraseña.Text == admnistrador.contraseña)
            {
                FormPrincipal f = new FormPrincipal();
                f.ShowDialog();//abrimos el FormPrincipal           
            }
            else
            {
                MessageBox.Show("Contrasña incorrecta o usuario incorrecto", "Información Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNombre.Clear();
                textBoxContraseña.Clear();
            }
        }    
    }
}
