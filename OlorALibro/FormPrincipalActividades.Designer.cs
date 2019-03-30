namespace OlorALibro
{
    partial class FormPrincipalActividades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalActividades));
            this.buttonSalirActividad = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.buttonModificarActividades = new System.Windows.Forms.Button();
            this.buttonEliminarActividades = new System.Windows.Forms.Button();
            this.buttonAñadirActividades = new System.Windows.Forms.Button();
            this.labelTituloActividades = new System.Windows.Forms.Label();
            this.LogoPrincipalActividades = new System.Windows.Forms.PictureBox();
            this.menuStripActividades = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LibreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalLibreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datodDeRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalDatosDeRedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGuardarActividades = new System.Windows.Forms.Button();
            this.NomActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).BeginInit();
            this.menuStripActividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalirActividad
            // 
            this.buttonSalirActividad.ImageIndex = 4;
            this.buttonSalirActividad.ImageList = this.imageList1;
            this.buttonSalirActividad.Location = new System.Drawing.Point(273, 192);
            this.buttonSalirActividad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalirActividad.Name = "buttonSalirActividad";
            this.buttonSalirActividad.Size = new System.Drawing.Size(44, 41);
            this.buttonSalirActividad.TabIndex = 19;
            this.buttonSalirActividad.UseVisualStyleBackColor = true;
            this.buttonSalirActividad.Click += new System.EventHandler(this.buttonSalirActividad_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editar.png");
            this.imageList1.Images.SetKeyName(1, "eliminar.png");
            this.imageList1.Images.SetKeyName(2, "mas.png");
            this.imageList1.Images.SetKeyName(3, "usuario.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "boton-descargar.png");
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AllowUserToAddRows = false;
            this.dataGridViewActividades.AllowUserToDeleteRows = false;
            this.dataGridViewActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActividades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewActividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomActividad,
            this.dataInicio,
            this.dataFinal});
            this.dataGridViewActividades.Location = new System.Drawing.Point(67, 238);
            this.dataGridViewActividades.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.ReadOnly = true;
            this.dataGridViewActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActividades.Size = new System.Drawing.Size(656, 305);
            this.dataGridViewActividades.TabIndex = 18;
            // 
            // buttonModificarActividades
            // 
            this.buttonModificarActividades.ImageIndex = 0;
            this.buttonModificarActividades.ImageList = this.imageList1;
            this.buttonModificarActividades.Location = new System.Drawing.Point(171, 192);
            this.buttonModificarActividades.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificarActividades.Name = "buttonModificarActividades";
            this.buttonModificarActividades.Size = new System.Drawing.Size(44, 41);
            this.buttonModificarActividades.TabIndex = 17;
            this.buttonModificarActividades.UseVisualStyleBackColor = true;
            this.buttonModificarActividades.Click += new System.EventHandler(this.buttonModificarActividades_Click);
            // 
            // buttonEliminarActividades
            // 
            this.buttonEliminarActividades.ImageIndex = 1;
            this.buttonEliminarActividades.ImageList = this.imageList1;
            this.buttonEliminarActividades.Location = new System.Drawing.Point(119, 190);
            this.buttonEliminarActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarActividades.Name = "buttonEliminarActividades";
            this.buttonEliminarActividades.Size = new System.Drawing.Size(44, 41);
            this.buttonEliminarActividades.TabIndex = 16;
            this.buttonEliminarActividades.UseVisualStyleBackColor = true;
            this.buttonEliminarActividades.Click += new System.EventHandler(this.buttonEliminarActividades_Click);
            // 
            // buttonAñadirActividades
            // 
            this.buttonAñadirActividades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAñadirActividades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAñadirActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirActividades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAñadirActividades.ImageIndex = 2;
            this.buttonAñadirActividades.ImageList = this.imageList1;
            this.buttonAñadirActividades.Location = new System.Drawing.Point(68, 191);
            this.buttonAñadirActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAñadirActividades.Name = "buttonAñadirActividades";
            this.buttonAñadirActividades.Size = new System.Drawing.Size(44, 41);
            this.buttonAñadirActividades.TabIndex = 25;
            this.buttonAñadirActividades.UseVisualStyleBackColor = false;
            this.buttonAñadirActividades.Click += new System.EventHandler(this.buttonAñadirActividades_Click);
            // 
            // labelTituloActividades
            // 
            this.labelTituloActividades.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloActividades.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTituloActividades.Location = new System.Drawing.Point(188, 31);
            this.labelTituloActividades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloActividades.Name = "labelTituloActividades";
            this.labelTituloActividades.Padding = new System.Windows.Forms.Padding(27, 6, 13, 12);
            this.labelTituloActividades.Size = new System.Drawing.Size(584, 108);
            this.labelTituloActividades.TabIndex = 14;
            this.labelTituloActividades.Text = "ACTIVIDADES";
            // 
            // LogoPrincipalActividades
            // 
            this.LogoPrincipalActividades.BackColor = System.Drawing.Color.Transparent;
            this.LogoPrincipalActividades.Image = ((System.Drawing.Image)(resources.GetObject("LogoPrincipalActividades.Image")));
            this.LogoPrincipalActividades.Location = new System.Drawing.Point(16, 9);
            this.LogoPrincipalActividades.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPrincipalActividades.Name = "LogoPrincipalActividades";
            this.LogoPrincipalActividades.Size = new System.Drawing.Size(164, 144);
            this.LogoPrincipalActividades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPrincipalActividades.TabIndex = 13;
            this.LogoPrincipalActividades.TabStop = false;
            // 
            // menuStripActividades
            // 
            this.menuStripActividades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStripActividades.AutoSize = false;
            this.menuStripActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStripActividades.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripActividades.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripActividades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStripActividades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioToolStripMenuItem,
            this.LibreriasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.datodDeRedToolStripMenuItem});
            this.menuStripActividades.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripActividades.Location = new System.Drawing.Point(0, 160);
            this.menuStripActividades.Name = "menuStripActividades";
            this.menuStripActividades.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripActividades.Size = new System.Drawing.Size(789, 28);
            this.menuStripActividades.TabIndex = 26;
            this.menuStripActividades.Text = "menuStripActividades";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.InicioToolStripMenuItem.Text = "Inicio";
            this.InicioToolStripMenuItem.Click += new System.EventHandler(this.InicioToolStripMenuItem_Click);
            // 
            // LibreriasToolStripMenuItem
            // 
            this.LibreriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalLibreriasToolStripMenuItem,
            this.añadirLibreriasToolStripMenuItem});
            this.LibreriasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibreriasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.LibreriasToolStripMenuItem.Name = "LibreriasToolStripMenuItem";
            this.LibreriasToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.LibreriasToolStripMenuItem.Text = "Librerias";
            // 
            // principalLibreriasToolStripMenuItem
            // 
            this.principalLibreriasToolStripMenuItem.Name = "principalLibreriasToolStripMenuItem";
            this.principalLibreriasToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.principalLibreriasToolStripMenuItem.Text = "Principal";
            this.principalLibreriasToolStripMenuItem.Click += new System.EventHandler(this.principalLibreriasToolStripMenuItem_Click);
            // 
            // añadirLibreriasToolStripMenuItem
            // 
            this.añadirLibreriasToolStripMenuItem.Name = "añadirLibreriasToolStripMenuItem";
            this.añadirLibreriasToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.añadirLibreriasToolStripMenuItem.Text = "Añadir";
            this.añadirLibreriasToolStripMenuItem.Click += new System.EventHandler(this.añadirLibreriaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalUsuariosToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // principalUsuariosToolStripMenuItem1
            // 
            this.principalUsuariosToolStripMenuItem1.Name = "principalUsuariosToolStripMenuItem1";
            this.principalUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.principalUsuariosToolStripMenuItem1.Text = "Principal";
            this.principalUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.principalUsuariosToolStripMenuItem1_Click);
            // 
            // datodDeRedToolStripMenuItem
            // 
            this.datodDeRedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalDatosDeRedToolStripMenuItem2});
            this.datodDeRedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datodDeRedToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.datodDeRedToolStripMenuItem.Name = "datodDeRedToolStripMenuItem";
            this.datodDeRedToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.datodDeRedToolStripMenuItem.Text = "Datos de red";
            // 
            // principalDatosDeRedToolStripMenuItem2
            // 
            this.principalDatosDeRedToolStripMenuItem2.Name = "principalDatosDeRedToolStripMenuItem2";
            this.principalDatosDeRedToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.principalDatosDeRedToolStripMenuItem2.Text = "Principal";
            this.principalDatosDeRedToolStripMenuItem2.Click += new System.EventHandler(this.principalDatosDeRedToolStripMenuItem2_Click);
            // 
            // buttonGuardarActividades
            // 
            this.buttonGuardarActividades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGuardarActividades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardarActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarActividades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuardarActividades.ImageIndex = 5;
            this.buttonGuardarActividades.ImageList = this.imageList1;
            this.buttonGuardarActividades.Location = new System.Drawing.Point(221, 192);
            this.buttonGuardarActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarActividades.Name = "buttonGuardarActividades";
            this.buttonGuardarActividades.Size = new System.Drawing.Size(44, 41);
            this.buttonGuardarActividades.TabIndex = 27;
            this.buttonGuardarActividades.UseVisualStyleBackColor = false;
            this.buttonGuardarActividades.Click += new System.EventHandler(this.buttonGuardarActividades_Click);
            // 
            // NomActividad
            // 
            this.NomActividad.DataPropertyName = "nombre";
            this.NomActividad.HeaderText = "Nombre";
            this.NomActividad.Name = "NomActividad";
            this.NomActividad.ReadOnly = true;
            // 
            // dataInicio
            // 
            this.dataInicio.DataPropertyName = "fechaInicio";
            this.dataInicio.HeaderText = "Fecha inicio";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            // 
            // dataFinal
            // 
            this.dataFinal.DataPropertyName = "fechaFinal";
            this.dataFinal.HeaderText = "Fecha final";
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            // 
            // FormPrincipalActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.summer_flowers_wood_texture_background_copyspace_40463562;
            this.ClientSize = new System.Drawing.Size(788, 558);
            this.Controls.Add(this.buttonGuardarActividades);
            this.Controls.Add(this.buttonSalirActividad);
            this.Controls.Add(this.dataGridViewActividades);
            this.Controls.Add(this.buttonModificarActividades);
            this.Controls.Add(this.buttonEliminarActividades);
            this.Controls.Add(this.buttonAñadirActividades);
            this.Controls.Add(this.labelTituloActividades);
            this.Controls.Add(this.menuStripActividades);
            this.Controls.Add(this.LogoPrincipalActividades);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripActividades;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipalActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalActividades";
            this.Activated += new System.EventHandler(this.FormPrincipalActividades_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalActividades_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipalActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).EndInit();
            this.menuStripActividades.ResumeLayout(false);
            this.menuStripActividades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalirActividad;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.Button buttonModificarActividades;
        private System.Windows.Forms.Button buttonEliminarActividades;
        private System.Windows.Forms.Button buttonAñadirActividades;
        private System.Windows.Forms.Label labelTituloActividades;
        private System.Windows.Forms.PictureBox LogoPrincipalActividades;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStripActividades;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LibreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalLibreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datodDeRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalDatosDeRedToolStripMenuItem2;
        private System.Windows.Forms.Button buttonGuardarActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
    }
}