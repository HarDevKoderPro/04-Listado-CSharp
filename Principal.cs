using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//-----------------------------------------------------------------------------------------------------------------------------------
namespace StudentsList
{
	public partial class Principal : Form
	{
		//---------    Método que Recarga Listbox con los  nuevos datos ------------------------------------------
		public void RefrescaListBox ()
		{
			//Refresco listBox para actualizar datos ingresados
			LstTabla.DataSource = null;
			//Ingreso dato al listBox
			LstTabla.DataSource = estudiantes;
		}
		//------------------------------------------ ELEMENTOS GLOBALES ----------------------------------------------------
		List<string> estudiantes = new List<string>();	// Lista de Estudiantes
		public int posicion;										//Posición de Elemento seleccionado en ListBox
		//-----------------------------------------------------------------------------------------------------------------------------------
		private void Form1_Load(object sender, EventArgs e)
		{
		}
		public Principal()
		{
			InitializeComponent();
		}
		//------------------------------------------- INGRESO DE DATOS ----------------------------------------------------------
		private void BtnIngresar_Click(object sender, EventArgs e)
		{
			//capturar nombre de estudiante
			string estudiante = TxtEstudiante.Text;
			//valido que no esté vacio el Textbox
			if (estudiante != "")
			{
				//Agrego el estudiante a la lista
				estudiantes.Add(estudiante);
				//Refresco listBox para actualizar datos ingresados
				RefrescaListBox();
			}
			else
			{
				MessageBox.Show("No hay información para ingresar ...");
			}
			//limpiado de Textbox
			TxtEstudiante.Clear();
			//Asigno Foco a la caja de texto para escribir el nuevo dato
			TxtEstudiante.Focus();
		}
		//------------------------------------------- ELIMINAR  DATOS -----------------------------------------------------------------
		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			//solo edita si hay un item seleccionado
			if (LstTabla.SelectedIndex >= 0)
			{
				int posicion = LstTabla.SelectedIndex;
				string item = estudiantes[posicion];
				var res = MessageBox.Show("Desea Eliminar a  " + item + "?", "Eliminar Estudiante", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					//Elimino elemento de la lista
					estudiantes.RemoveAt(posicion);
					//Refresco listBox para actualizar datos ingresados
					RefrescaListBox();
					//limpiado de Textbox
					TxtEstudiante.Clear();
				}
			}
			else
			{
				MessageBox.Show("Seleccione un Item para eliminar!");
			}
		}
		//------------------------------------------- MODIFICAR  DATOS -----------------------------------------------------------------
		private void BtnModificar_Click(object sender, EventArgs e)
		{
			BtnIngresar.Enabled = false;	
			BtnEliminar.Enabled=false;
			AcceptButton = BtnModificar;
			if (BtnModificar.Text == "Editar")
			{
				//Obtengo la posición del item seleccionado
				posicion = LstTabla.SelectedIndex;
				//MessageBox.Show(posicion.ToString());
				BtnModificar.Text = "Guardar";
				if (LstTabla.SelectedIndex >= 0)
				{
					//Muestro valor seleccionado en el textbox
					TxtEstudiante.Text = LstTabla.SelectedItem.ToString();
					//Asigno Foco a la caja de texto para escribir el nuevo dato
					TxtEstudiante.Focus();
					//Coloco el cursor al final del contenido de la caja de texto
					TxtEstudiante.SelectionStart = TxtEstudiante.Text.Length;
				}
			}
			else
			{
				if (TxtEstudiante.Text != "")
				{
					//Restauro el nombre inicial del botón
					BtnModificar.Text = "Editar";
					//Elimino item seleccionado de la lista
					estudiantes.RemoveAt(posicion);
					//Inserto el nuevo dato en la lista
					estudiantes.Insert(posicion, TxtEstudiante.Text);
					//Refresco listBox para actualizar datos ingresados
					RefrescaListBox();
					//Limpio TextBox
					TxtEstudiante.Clear();
					//Habilito Botones
					BtnIngresar.Enabled = true;
					BtnEliminar.Enabled = true;
					//Asigno enter a boton ingresar
					AcceptButton = BtnIngresar ;
					//Asigno Foco a la caja de texto para escribir el nuevo dato
					TxtEstudiante.Focus();
				}
				else
				{
					MessageBox.Show("No se puede ingresar Dato Vacío ...");
					TxtEstudiante.Text = LstTabla.SelectedItem.ToString();
					//Asigno Foco a la caja de texto para escribir el nuevo dato
					TxtEstudiante.Focus();
					//Coloco el cursor al final del contenido de la caja de texto
					TxtEstudiante.SelectionStart = TxtEstudiante.Text.Length;
				}
			}
		}
		public void LstTabla_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
