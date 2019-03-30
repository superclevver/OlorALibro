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
    public partial class FormPrincipal : Form
    {
        /*CONSTRUCTOR*/
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //--------------------BOTONES--------------------//
        private void buttonLibrerias_Click(object sender, EventArgs e)
        {
            FormPrincipalLibrerias f = new FormPrincipalLibrerias();
            f.ShowDialog();
        }
        private void buttonActividades_Click(object sender, EventArgs e)
        {
            FormPrincipalActividades f = new FormPrincipalActividades();
            f.ShowDialog();
        }
        private void buttonEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas f = new FormEstadisticas();
            f.ShowDialog();
        }
        private void buttonDatosDeLaRed_Click(object sender, EventArgs e)
        {
            FormDatosXarxa f = new FormDatosXarxa();
            f.ShowDialog();
        }
        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios f = new FormUsuarios();
            f.ShowDialog();
        }

        //--------------------CLOSING--------------------//
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }        
    }
}
