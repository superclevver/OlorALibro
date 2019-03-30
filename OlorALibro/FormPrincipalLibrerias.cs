using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// COMENTADO
namespace OlorALibro
{
    public partial class FormPrincipalLibrerias : Form
    {
        Boolean guardado = false;

        /*CONSTRUCTORS*/
        public FormPrincipalLibrerias()
        {
            InitializeComponent();
        }

        //----------------------------ACTIVATED------------------------------//
        private void FormPrincipalLibrerias_Activated(object sender, EventArgs e)
        {
            dataGridViewPrincipalLibrerias.DataSource = null;
            dataGridViewPrincipalLibrerias.DataSource = Metodos.libreri;
            guardado = false;
        }

        //----------------------- al pasar por encima sale el nombre ------------------------------
        private void tools()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(buttonAñadir, "Añadir");
            toolTip1.SetToolTip(buttonEliminar, "Eliminar");
            toolTip1.SetToolTip(buttonEditar, "Editar");
            toolTip1.SetToolTip(buttonGuardarLibrerias, "Guardar");
            toolTip1.SetToolTip(buttonSalirLibreria, "Salir");
        }

        // -------------------------- LOAD ----------------------------- //
        private void FormPrincipalLibrerias_Load(object sender, EventArgs e)
        {
            tools();
            Metodos.leerLibrerias(); // llamamos a la funcion leer librerias
            guardado = false;
        }

        //-------------------------MENU DE ARRIBA(ToolStrip)----------------------------//
        //------------------------------------------------------------------------------//
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarLibrerias();
            FormPrincipal f = new FormPrincipal();
            f.ShowDialog();
        }
        private void principalActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarLibrerias();
            FormPrincipalActividades f = new FormPrincipalActividades();
            f.ShowDialog();
            

        }
        private void añadirActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodos.guardarLibrerias();
            guardado = true;
            FormActividades f = new FormActividades();
            f.ShowDialog();
            
            //Si quiere crear si quiere quedarse en el formulario este o ir donde lo este añadiendo 
            //if()
        }
        private void principalUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarLibrerias();
            FormUsuarios f = new FormUsuarios();
            f.ShowDialog();
        }
        private void principalDatosDeRedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarLibrerias();
            guardado = true;
            FormDatosXarxa f = new FormDatosXarxa();
            f.ShowDialog();
        }

        //-------------------- BOTONES --------------------//
        //-------------------------------------------------//
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FormRellenarLibrerias libreria = new FormRellenarLibrerias();
            libreria.ShowDialog();
            guardado = false;
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Metodos.libreri.Remove((Libreria)dataGridViewPrincipalLibrerias.SelectedRows[0].DataBoundItem);
            dataGridViewPrincipalLibrerias.DataSource = null;
            dataGridViewPrincipalLibrerias.DataSource = Metodos.libreri;
            guardado = false;
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Libreria l = (Libreria)dataGridViewPrincipalLibrerias.SelectedRows[0].DataBoundItem;
            FormModificarLibreria f = new FormModificarLibreria(l);
            f.Text = "Formulario Librerias";
            f.ShowDialog();
            guardado = false;
        }
        private void buttonGuardarLibrerias_Click(object sender, EventArgs e)
        {
            Metodos.guardarLibrerias();
            MessageBox.Show("Se ha guardado correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guardado = true;
        }
        private void buttonSalirLibreria_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (guardado == false)
            {
                resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarLibrerias();
                    guardado = true;
                    this.Close();
                }
                else
                {
                    FormPrincipal f = new FormPrincipal();
                    f.ShowDialog();
                }
            }
            else
            {
                FormPrincipal f = new FormPrincipal();
                f.ShowDialog();
            }
        }

        //---------------------------CLOSING--------------------------------//
        private void FormPrincipalLibrerias_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;

            if(guardado == false)
            { 
                resultado = MessageBox.Show("Quieres guardar antes de salir? ", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarLibrerias();
                    guardado = true;
                    this.Close();
                }
                else
                {

                }
            }
            else
            {

            }
        }   
    }
}