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
    public partial class FormEstadisticas : Form
    {

        //--------------------CONSTRUCTOR--------------------//
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        //---------------------LOAD---------------------//
        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            dataGridViewActividades.AutoGenerateColumns = false;
            // llamamos a la funcion ller actividades ( ller json)
            Metodos.leerActividades();
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = Metodos.actividad;
            
           // esto calcula la cantidad de librerias que hay en cada actividad.
            for (int i = 0; i < Metodos.actividad.Count; i++)
            {
                dataGridViewActividades.Rows[i].Cells[1].Value = Metodos.actividad.ElementAt(i).librerias.Count;
            }
        }
        //-------------------MENU DE ARRIBA(ToolStrip)--------------------//
        //----------------------------------------------------------------//
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarActividades();
            FormPrincipal f = new FormPrincipal();
            f.ShowDialog();
        }
        private void principalLibreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarActividades();
            FormPrincipalLibrerias f = new FormPrincipalLibrerias();
            f.ShowDialog();
        }
        private void añadirLibreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodos.guardarActividades();
            FormRellenarLibrerias f = new FormRellenarLibrerias();
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
            FormActividades f = new FormActividades();
            f.ShowDialog();
        }
        private void principalUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarActividades();
            FormUsuarios f = new FormUsuarios();
            f.ShowDialog();
        }
        private void principalDatosDeRedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos.guardarActividades();
            FormDatosXarxa f = new FormDatosXarxa();
            f.ShowDialog();
        }
    }
}
