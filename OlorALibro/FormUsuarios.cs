using System;
using System.Windows.Forms;

namespace OlorALibro
{
    public partial class FormUsuarios : Form
    {       
        Boolean guardado = false;

        //----------CONSTRUCTORES----------//
        public FormUsuarios()
        {
            InitializeComponent();
        }
        //----------------------- PARA REFRESCAR ------------------------------//
        private void refrescarDataGread()
        {
            dataGridViewUsuarios.DataSource = Metodos.usuario;
        }
        //----------------------- al pasar por encima sale el nombre ------------------------------//
        private void tools()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(buttonBorrarUsuarios, "Eliminar");
            toolTip1.SetToolTip(buttonEditarUsuario, "Editar");
            toolTip1.SetToolTip(buttonGuardarUsuarios, "Guardar");
            toolTip1.SetToolTip(buttonSalirUsuarios, "Salir");
        }

        //-------------------LOAD--------------------//
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            tools();
            Metodos.leerUsuarios();
            dataGridViewUsuarios.DataSource = Metodos.usuario; // mostra la llista a la gridView
            guardado = false;
        }

        //-------------------MENU DE ARRIBA(ToolStrip)--------------------//
        //----------------------------------------------------------------//
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal f = new FormPrincipal();
            f.ShowDialog();
            this.Close();
        }
        private void principalLibreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipalLibrerias f = new FormPrincipalLibrerias();
            f.ShowDialog();
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
            f.ShowDialog();
            this.Close();
        }
        private void añadirActividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormActividades f = new FormActividades();
            f.ShowDialog();
        }
        private void principalDatosDeRedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormDatosXarxa f = new FormDatosXarxa();
            f.ShowDialog();
            this.Close();
        }

        //--------------------BOTONES--------------------//
        //-----------------------------------------------//
        private void buttonBorrarUsuarios_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
            Metodos.usuario.Remove(u);
            refrescarDataGread();
            guardado = false;
        }
        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            {
                Usuario o = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                FormEditarUsuario f = new FormEditarUsuario(o);
                f.Text = "Formulario Usuarios";
                guardado = false;
                f.ShowDialog();
            }
        }
        private void buttonGuardarUsuarios_Click(object sender, EventArgs e)
        {

            Metodos.guardarUsuarios();
            MessageBox.Show("Se ha guardado correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guardado = true;
        }
        private void buttonSalirUsuarios_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (guardado == false)
            {
                resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarUsuarios();
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

        //--------------------CLOSING--------------------//
        private void FormUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            // hacer opcion de salir i guardar o salir sin guardar
            DialogResult resultado;

            if(guardado == false)
            { 
                resultado = MessageBox.Show("Quieres guardar antes de salir?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Metodos.guardarUsuarios();
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

