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
    public partial class FormInicio : Form
    {
        //--------------------CONSTRUCTOR--------------------//
        public FormInicio()
        {
            InitializeComponent();
        }

        //--------------------BARRA CARGAR--------------------//
        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100) this.timerInicio.Stop();
            // el 100 se modifica dependiendo de lo que tarde en abrir-se la app
            // si dura menos bajamos el numero si tarda mas lo sumamos
        }
    }
}
