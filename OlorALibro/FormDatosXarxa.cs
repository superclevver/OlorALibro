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
    public partial class FormDatosXarxa : Form
    {
        Boolean guardado = false;

        //--------------------CONSTRUCTORES--------------------//
        public FormDatosXarxa()
        {
            InitializeComponent();
        }

        //-------------------- LOAD --------------------//
        private void FormDadesXarxa_Load(object sender, EventArgs e)
        {
            Metodos.leerDatosDeRed();
            textBoxProyecto.Text = Metodos.red.proyecto;
            textBoxGrupo.Text = Metodos.red.grupo;
            guardado = false;
        }

        //--------------------BOTON PASAR A JSON--------------------//
        private void buttonPasarAJSON_Click(object sender, EventArgs e)
        {
            Metodos.red.proyecto = textBoxProyecto.Text;
            Metodos.red.grupo = textBoxGrupo.Text;
            Metodos.guardarDatosDeRed();
            guardado = true;
        }

        //-------------------MENU DE ARRIBA(ToolStrip)--------------------//
        //----------------------------------------------------------------//
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.Show();
            this.Close();
        }
        private void principalLibreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipalLibrerias f = new FormPrincipalLibrerias();
            f.Show();
            this.Close();
        }
        private void añadirLibreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRellenarLibrerias f = new FormRellenarLibrerias();
            f.ShowDialog();
        }
        private void principalActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPrincipalActividades f = new FormPrincipalActividades();
            f.Show();
            this.Close();
        }
        private void añadirActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormActividades f = new FormActividades();
            f.ShowDialog();
        }
        private void principalUsuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormUsuarios f = new FormUsuarios();
            f.Show();
            this.Close();
        }

        //-------------------------- CLOSING ------------------------------
        private void FormDatosXarxa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;

            if(guardado == false)
            { 
                resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarDatosDeRed();
                    guardado = true;
                    this.Close();
                }
                else
                {
                    // ho deixem en blanc per tal de que no sobrin molts formularis principals
                }
            }
            else
            {

            }
        }
    }
}
