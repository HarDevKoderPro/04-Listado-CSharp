namespace StudentsList
{
	partial class Principal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.label1 = new System.Windows.Forms.Label();
			this.TxtEstudiante = new System.Windows.Forms.MaskedTextBox();
			this.BtnIngresar = new System.Windows.Forms.Button();
			this.LstTabla = new System.Windows.Forms.ListBox();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnModificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Estudiante:";
			// 
			// TxtEstudiante
			// 
			this.TxtEstudiante.Location = new System.Drawing.Point(78, 12);
			this.TxtEstudiante.Name = "TxtEstudiante";
			this.TxtEstudiante.Size = new System.Drawing.Size(139, 20);
			this.TxtEstudiante.TabIndex = 1;
			// 
			// BtnIngresar
			// 
			this.BtnIngresar.Location = new System.Drawing.Point(223, 42);
			this.BtnIngresar.Name = "BtnIngresar";
			this.BtnIngresar.Size = new System.Drawing.Size(57, 27);
			this.BtnIngresar.TabIndex = 2;
			this.BtnIngresar.Text = "Ingresar";
			this.BtnIngresar.UseVisualStyleBackColor = true;
			this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
			// 
			// LstTabla
			// 
			this.LstTabla.FormattingEnabled = true;
			this.LstTabla.Location = new System.Drawing.Point(15, 41);
			this.LstTabla.Name = "LstTabla";
			this.LstTabla.Size = new System.Drawing.Size(202, 186);
			this.LstTabla.TabIndex = 3;
			this.LstTabla.SelectedIndexChanged += new System.EventHandler(this.LstTabla_SelectedIndexChanged);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(223, 75);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(57, 27);
			this.BtnEliminar.TabIndex = 4;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// BtnModificar
			// 
			this.BtnModificar.Location = new System.Drawing.Point(223, 108);
			this.BtnModificar.Name = "BtnModificar";
			this.BtnModificar.Size = new System.Drawing.Size(57, 27);
			this.BtnModificar.TabIndex = 5;
			this.BtnModificar.Text = "Editar";
			this.BtnModificar.UseVisualStyleBackColor = true;
			this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
			// 
			// Principal
			// 
			this.AcceptButton = this.BtnIngresar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 237);
			this.Controls.Add(this.BtnModificar);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.LstTabla);
			this.Controls.Add(this.BtnIngresar);
			this.Controls.Add(this.TxtEstudiante);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Principal";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listado de Estudiantes";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox TxtEstudiante;
		private System.Windows.Forms.Button BtnIngresar;
		private System.Windows.Forms.ListBox LstTabla;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button BtnModificar;
	}
}

