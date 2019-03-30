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
    public partial class FormModificarLibreria : Form
    {
        Libreria modlibreria;

        //--------------------CONSTRUCTOR--------------------//
        public FormModificarLibreria()
        {
            InitializeComponent();
        }
        public FormModificarLibreria(Libreria modlibreria)//
        {
            InitializeComponent();
            this.modlibreria = modlibreria;
        }

        //--------------------LOAD--------------------//
        private void FormModificarLibreria_Load(object sender, EventArgs e)
        {
            textBoxnombreMod.Text = modlibreria.nombre;
            textBoxtelefonoMod.Text = modlibreria.telefono.ToString();
            textBoxdireccionMod.Text = modlibreria.direccion;
            textBoxnombrecontactoMod.Text = modlibreria.nombreContacto;
            textBoxDescripcionLibrerias.Text = modlibreria.descripcion;
        }

        //--------------------BOTOR ACEPTAR--------------------//
        private void buttonAceptarMod_Click(object sender, EventArgs e)
        {
            //modifica les dades al modificar les librerias
            modlibreria.nombre = textBoxnombreMod.Text;
            modlibreria.direccion = textBoxdireccionMod.Text;
            modlibreria.telefono = int.Parse(textBoxtelefonoMod.Text);
            modlibreria.nombreContacto = textBoxnombrecontactoMod.Text;
            modlibreria.descripcion = textBoxDescripcionLibrerias.Text;
            this.Close();
        }

        //--------------------COMPROBAR NOMBRE Y TELEFONO--------------------//
        private void textBoxnombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten letras");
            }
        }
        private void textBoxtelefonoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten numeros");
            }
        }
        private void textBoxnombrecontactoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten letras");
            }
        }
    }
}

