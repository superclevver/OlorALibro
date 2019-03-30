using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//COMENTAT
namespace OlorALibro
{
    public partial class FormModificarActividades : Form
    {
        Actividad modAct;

        // llistes de temas per selecionar depenent si es adult o infantil
        string[] Categoria = new string[2] { "Infantil", "Adulto" };
        string[] TemasInfantiles = new string[15] { "Actividades", "Concursos", "Club de lectura", "Presentación", "Semanas tematicas", "Dia tematico", "Extraescolares", "Talleres", "Actividades fin de semana", "Repaso", "Cursos", "Charlas", "Cuentacuentos", "Mesa redonda", "Planes en familia" };
        string[] TemasAdultos = new string[13] { "Actividades", "Concursos", "Tertulias", "Presentación", "Club de lectura", "Semanas tematicas", "Dia tematico", "Exposiciones", "Cursos", "Charlas", "Mesa redonda", "Noche de libros", "Planes en familia" };


        //--------------------CONSTRUCTOR--------------------//
        public FormModificarActividades()
        {
            InitializeComponent();
        }
        public FormModificarActividades(Actividad modAct)
        {
            InitializeComponent();
            this.modAct = modAct;
        }

        //--------------------LOAD--------------------//
        private void FormularioModificarActividades_Load(object sender, EventArgs e)
        {
            //Carregem totes les dades al formulari de l'activitat que hem selecionat
            textBoxNombreModificarActividad.Text = modAct.nombre;
            dateTimeModiciarFechaInicio.Value = modAct.fechaInicio;
            dateTimeModificarFechaFinal.Value = modAct.fechaFinal;
            if (radioButtonAdulto.Checked)
            {
                listBoxTemasModAct.Items.AddRange(TemasAdultos);
            }
            else
            {
                listBoxTemasModAct.Items.AddRange(TemasInfantiles);
            }

            listBoxTemasModAct.SelectedItems.Clear();
            if (modAct.temas != null)
            {
                foreach (string item in modAct.temas)
                {
                    listBoxTemasModAct.SelectedItems.Add(item);
                }
            }
            textBoxDescripcionModificarActividades.Text = modAct.descripcion;
            listBoxLibreriasModificarActividades.DataSource = null;
            listBoxLibreriasModificarActividades.DataSource = Metodos.libreri;
            listBoxLibreriasModificarActividades.DisplayMember = "nombre";
            listBoxLibreriasModificarActividades.ClearSelected();
            if(modAct.librerias != null)
            { 
                foreach (string item in modAct.librerias)
                {
                   for (int i = 0; i < Metodos.libreri.Count; i++)
                   {
                        if (Metodos.libreri[i].nombre == item)
                        {
                          listBoxLibreriasModificarActividades.SelectedItems.Add(Metodos.libreri[i]);
                         }
                   }
                }
            }
        }

        //--------------------Guarda la actividad modificada--------------------//
        private void buttonCrearModificarActividad_Click(object sender, EventArgs e)
        {
            // Aqui guarda totes les dades de l'activitat quan ja estan modificades
            modAct.nombre = textBoxNombreModificarActividad.Text;
            modAct.fechaInicio = dateTimeModiciarFechaInicio.Value;
            modAct.fechaFinal = dateTimeModificarFechaFinal.Value;
            if (radioButtonAdulto.Checked)
            {
                modAct.categorias = true;
            }
            else
            {
                modAct.categorias = false;
            }
            modAct.descripcion = textBoxDescripcionModificarActividades.Text;
            modAct.temas = new List<string>();
            foreach (string item in listBoxTemasModAct.SelectedItems)
            {
                modAct.temas.Add(item);
            }
            modAct.librerias = new List<string>();
            foreach (Libreria item in listBoxLibreriasModificarActividades.SelectedItems)
            {
                modAct.librerias.Add(item.nombre);
            }
             this.Close();
        }
        private void radioButtonAdulto_CheckedChanged(object sender, EventArgs e)
        {
            // aqui comprova si el radioButon esta selecionar adulto per mostrar la llista de temas
            // sino ho esta mostra la llista infantil.
            listBoxTemasModAct.Items.Clear();

            if (radioButtonAdulto.Checked)
            {
                listBoxTemasModAct.Items.AddRange(TemasAdultos);
            }
            else
            {
                listBoxTemasModAct.Items.AddRange(TemasInfantiles);
            }
        }
        private void radioButtonInfantil_CheckedChanged(object sender, EventArgs e)
        {
        // I aqui es al reves, mira si esta selecionat el infantil i sino et mostra la llista d'adults.
            listBoxTemasModAct.Items.Clear();

            if (radioButtonInfantil.Checked)
            {
                listBoxTemasModAct.Items.AddRange(TemasInfantiles);
            }
            else
            {
                listBoxTemasModAct.Items.AddRange(TemasAdultos);
            }
        }
    }
}
