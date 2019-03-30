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
    public partial class FormPrincipalActividades : Form
    {        
        Boolean guardado = false;

        //----------------------- CONSTRUCTOR ------------------------------//
        public FormPrincipalActividades()
        {
            InitializeComponent();
        }

        //----------------------- PARA REFRESCAR ------------------------------//
        private void refrescarDataGread()
        {
            dataGridViewActividades.DataSource = Metodos.actividad;
        }

        //----------------------- al pasar por encima sale el nombre ------------------------------//
        private void tools()
        {
            // aqui fa que quan pases per sobre dels botons del sobre la grid et surtin els noms.
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(buttonAñadirActividades, "Añadir");
            toolTip1.SetToolTip(buttonEliminarActividades, "Eliminar");
            toolTip1.SetToolTip(buttonModificarActividades, "Editar");
            toolTip1.SetToolTip(buttonGuardarActividades, "Guardar");
            toolTip1.SetToolTip(buttonSalirActividad, "Salir");
        }

        //------------------------- LOAD ------------------------------//
        private void FormPrincipalActividades_Load(object sender, EventArgs e)
        {
            // quitamos el autogenerador de columnas de la grid para que no se añaden columas que no queremos
            dataGridViewActividades.AutoGenerateColumns = false;
            // llamamos a la funcion tools, para que cuando carge el formulairio ya salgan los nombres
            tools();
            // Aqui llamamos a las funciones cradas en la clase metodos para leer los json
            Metodos.leerActividades();
            Metodos.leerLibrerias();
            // Y aqui mostramos la lista en la grid
            dataGridViewActividades.DataSource = Metodos.actividad;
            refrescarDataGread();
            // i ponemos guardado en false porque asi si queremos salir nos pida si queremos gurdar
            guardado = false;
        }

        //-------------------------- ACTIVATE ------------------------------//
        private void FormPrincipalActividades_Activated(object sender, EventArgs e)
        {
            //cuando se activa ponemos la dataGrid en null y luego le cargamos las actividades
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = Metodos.actividad;
            guardado = false;
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

        //------------------------- BOTONES ------------------------------//
        //----------------------------------------------------------------//
        private void buttonAñadirActividades_Click(object sender, EventArgs e)
        {
            // le pasamos la lista para que en el otro formulario vaya añadiendo las actividades nuevas
            FormActividades f = new FormActividades(); 
            f.Text = "Formulario Actividades";
            guardado = false;
            f.ShowDialog(); // para que solo puedas abrir un formulario
        }
        private void buttonModificarActividades_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;
            FormModificarActividades f = new FormModificarActividades(a);
            f.Text = "Formulario Actividades";
            guardado = false;
            f.ShowDialog();

        }
        private void buttonEliminarActividades_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;
            Metodos.actividad.Remove(a);
            refrescarDataGread();
            guardado = false;
        }
        private void buttonGuardarActividades_Click(object sender, EventArgs e)
        {
            
            Metodos.guardarActividades();
            MessageBox.Show("Se ha guardado correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guardado = true; // aqui ponemos true porque como se guarda asi no hace falta que nos lo pida otra vez al salir
        }
        private void buttonSalirActividad_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            // Aqui miramos si el guardado esta en falso te pide que si quieres guardar antes de salir
            if (guardado == false)
            {
                resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarActividades();
                    guardado = true;
                }
                else
                {
                    FormPrincipal f = new FormPrincipal();
                    f.ShowDialog();
                }
            }
            // si esta true lo cierra y vas al menu principal
            else
            {
                FormPrincipal f = new FormPrincipal();
                f.ShowDialog();
            }
        }

        //-------------------------- CLOSING ------------------------------//
        private void FormPrincipalActividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            // hacer opcion de salir i guardar o salir sin guardar
            DialogResult resultado;
            if (guardado == false)
            { 
                resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarActividades();
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
