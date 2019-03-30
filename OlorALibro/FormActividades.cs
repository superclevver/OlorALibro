using System;
using System.Collections.Generic;
using System.Windows.Forms;
//COMENTADO
namespace OlorALibro
{
    public partial class FormActividades : Form
    {
        Actividad act;

        string[] Categoria = new string[2] { "Infantil", "Adulto" };
        string[] TemasInfantiles = new string[15] { "Actividades", "Concursos","Club de lectura", "Presentación","Semanas tematicas","Dia tematico","Extraescolares","Talleres","Actividades fin de semana", "Repaso", "Cursos", "Charlas", "Cuentacuentos", "Mesa redonda", "Planes en familia" };
        string[] TemasAdultos = new string[13] { "Actividades", "Concursos", "Tertulias","Presentación","Club de lectura", "Semanas tematicas", "Dia tematico", "Exposiciones", "Cursos",  "Charlas", "Mesa redonda", "Noche de libros", "Planes en familia" };

        //--------------------CONSTRUCTOR--------------------//
        public FormActividades()
        {
            InitializeComponent();
        }
        
        public FormActividades(Actividad act)
        {
            InitializeComponent();
            this.act = act;
        }

        //---------------------LOAD---------------------//
        private void FormActividades_Load(object sender, EventArgs e)
        {
            listBoxLibreriasActividades.DataSource = null;
            listBoxLibreriasActividades.DataSource = Metodos.libreri;
            listBoxLibreriasActividades.DisplayMember = "nombre";
            if (radioButtonAdulto.Checked)
            {
                listBoxTemas.Items.AddRange(TemasAdultos);                
            }
            else
            {
                listBoxTemas.Items.AddRange(TemasInfantiles);
            }
            listBoxLibreriasActividades.SelectedItems.Clear();

        }

        //--------------------BOTON CREAR--------------------//
        private void buttonCrearActividad_Click(object sender, EventArgs e)
        {
            // Crea actividad

            Actividad a = new Actividad();

            a.nombre = textBoxNombreActividad.Text;
            a.fechaInicio = dateTimeFechaInicio.Value;
            a.fechaFinal = dateTimeFechaFinal.Value;
            if (radioButtonAdulto.Checked)
            {
                a.categorias = true; // el true o false es porque lo utilizamos en android
            }
            else
            {
                a.categorias = false;
            }
            a.descripcion = textBoxDescripcionActividades.Text;
            a.temas = new List<string>();
            foreach (string item in listBoxTemas.SelectedItems)
            {
                a.temas.Add(item);
            }
            a.librerias = new List<string>();
            foreach (Libreria item in listBoxLibreriasActividades.SelectedItems)
            {
                a.librerias.Add(item.nombre);
            }

            // Avisa quan intentes crear una activitat i ya esta creada
            if (Metodos.actividad.Contains(a))
            {
                MessageBox.Show("Esta actividad ya esta creada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // sino la añade en la lista
            {
                Metodos.actividad.Add(a);
            }

            this.Close(); 
        }
        private void radioButtonAdulto_CheckedChanged(object sender, EventArgs e)
        {
            listBoxTemas.Items.Clear();

            if (radioButtonAdulto.Checked)
            {
                listBoxTemas.Items.AddRange(TemasAdultos);
            }
            else
            {
                listBoxTemas.Items.AddRange(TemasInfantiles);
            }
        }
        private void radioButtonInfantil_CheckedChanged(object sender, EventArgs e)
        {
            listBoxTemas.Items.Clear();

            if (radioButtonInfantil.Checked)
            {
                listBoxTemas.Items.AddRange(TemasInfantiles);
            }
            else
            {
                listBoxTemas.Items.AddRange(TemasAdultos);
            }
        }
    }
}
