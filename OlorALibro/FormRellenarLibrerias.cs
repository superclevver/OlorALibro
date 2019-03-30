using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//COMENTADO
namespace OlorALibro
{
    public partial class FormRellenarLibrerias : Form
    {
        //--------------------CONSTRUCTOR--------------------//
        public FormRellenarLibrerias()
        {
            InitializeComponent();
        }

        //--------------------COMPORBAR ERRORES--------------------//
        private void GuardadoYErrores(Libreria l)
        {
            if (l.nombre == "")
            {
                MessageBox.Show("No has añadido el nombre!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxnombre.Focus();
            }

            else if (l.direccion == "")
            {
                MessageBox.Show("No has añadido la direccion!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxdireccion.Focus();
            }
            else if (l.telefono == 0)
            {
                MessageBox.Show("No has añadido el telefono!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxtelefono.Focus();
            }
            else if (Metodos.libreri.Contains(l))
            {
                MessageBox.Show("Esta libreria ya esta creada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else if(l.telefono != )
            {
                MaskedTextBox mascara = new MaskedTextBox();
                mascara.Mask = "(93)-0000-0000";
            }*/
            else
            {
                Metodos.libreri.Add(l);
                this.Close();
            }
        }

        //--------------------BOTON ACEPTAR--------------------//
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Libreria l = new Libreria();
            l.nombre = textBoxnombre.Text;
            l.direccion = textBoxdireccion.Text;
            l.telefono = int.Parse(textBoxtelefono.Text);
            l.nombreContacto = textBoxnombrecontacto.Text;
            l.descripcion = textBoxDescripcionRellLibrerias.Text;
            GuardadoYErrores(l);// le pasamos la libreria
            this.Close();
        }

        //--------------------COMPROBAR NOMBRE Y TELEFONO--------------------//
        private void textBoxnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten letras");
            }
        }
        private void textBoxtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("solo se permiten numeros");
            }
            // cuando empieza por 9 o 6
        }
    }
}
