namespace OlorALibro
{
    partial class FormPrincipalLibrerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalLibrerias));
            this.dataGridViewPrincipalLibrerias = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.labelTituloLibrerias = new System.Windows.Forms.Label();
            this.buttonSalirLibreria = new System.Windows.Forms.Button();
            this.LogoPrincipalActividades = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeRedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.principalDatosDeRedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGuardarLibrerias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipalLibrerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrincipalLibrerias
            // 
            this.dataGridViewPrincipalLibrerias.AllowUserToAddRows = false;
            this.dataGridViewPrincipalLibrerias.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipalLibrerias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrincipalLibrerias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPrincipalLibrerias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPrincipalLibrerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipalLibrerias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.direccion,
            this.telefono,
            this.nombrecontacto});
            this.dataGridViewPrincipalLibrerias.Location = new System.Drawing.Point(67, 238);
            this.dataGridViewPrincipalLibrerias.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrincipalLibrerias.Name = "dataGridViewPrincipalLibrerias";
            this.dataGridViewPrincipalLibrerias.ReadOnly = true;
            this.dataGridViewPrincipalLibrerias.RowTemplate.Height = 29;
            this.dataGridViewPrincipalLibrerias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipalLibrerias.Size = new System.Drawing.Size(656, 305);
            this.dataGridViewPrincipalLibrerias.TabIndex = 18;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // nombrecontacto
            // 
            this.nombrecontacto.DataPropertyName = "nombreContacto";
            this.nombrecontacto.HeaderText = "Nombre de Contacto";
            this.nombrecontacto.Name = "nombrecontacto";
            this.nombrecontacto.ReadOnly = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.ImageIndex = 0;
            this.buttonEditar.ImageList = this.imageList1;
            this.buttonEditar.Location = new System.Drawing.Point(167, 191);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditar.Size = new System.Drawing.Size(44, 41);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ImageIndex = 1;
            this.buttonEliminar.ImageList = this.imageList1;
            this.buttonEliminar.Location = new System.Drawing.Point(117, 191);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(44, 41);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.AccessibleDescription = "";
            this.buttonAñadir.AccessibleName = "";
            this.buttonAñadir.ImageIndex = 2;
            this.buttonAñadir.ImageList = this.imageList1;
            this.buttonAñadir.Location = new System.Drawing.Point(68, 191);
            this.buttonAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(44, 41);
            this.buttonAñadir.TabIndex = 8;
            this.buttonAñadir.Tag = "";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // labelTituloLibrerias
            // 
            this.labelTituloLibrerias.AutoSize = true;
            this.labelTituloLibrerias.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloLibrerias.Font = new System.Drawing.Font("Candara", 48F);
            this.labelTituloLibrerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTituloLibrerias.Location = new System.Drawing.Point(271, 25);
            this.labelTituloLibrerias.Name = "labelTituloLibrerias";
            this.labelTituloLibrerias.Size = new System.Drawing.Size(400, 97);
            this.labelTituloLibrerias.TabIndex = 6;
            this.labelTituloLibrerias.Text = "LIBRERIAS";
            // 
            // buttonSalirLibreria
            // 
            this.buttonSalirLibreria.ImageIndex = 4;
            this.buttonSalirLibreria.ImageList = this.imageList1;
            this.buttonSalirLibreria.Location = new System.Drawing.Point(267, 191);
            this.buttonSalirLibreria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalirLibreria.Name = "buttonSalirLibreria";
            this.buttonSalirLibreria.Size = new System.Drawing.Size(44, 41);
            this.buttonSalirLibreria.TabIndex = 19;
            this.buttonSalirLibreria.UseVisualStyleBackColor = true;
            this.buttonSalirLibreria.Click += new System.EventHandler(this.buttonSalirLibreria_Click);
            // 
            // LogoPrincipalActividades
            // 
            this.LogoPrincipalActividades.BackColor = System.Drawing.Color.Transparent;
            this.LogoPrincipalActividades.Image = ((System.Drawing.Image)(resources.GetObject("LogoPrincipalActividades.Image")));
            this.LogoPrincipalActividades.Location = new System.Drawing.Point(16, 9);
            this.LogoPrincipalActividades.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPrincipalActividades.Name = "LogoPrincipalActividades";
            this.LogoPrincipalActividades.Size = new System.Drawing.Size(177, 146);
            this.LogoPrincipalActividades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPrincipalActividades.TabIndex = 20;
            this.LogoPrincipalActividades.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.actividadesToolStripMenuItem,
            this.UsuariosToolStripMenuItem,
            this.datosDeRedToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(2, 159);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalActividadesToolStripMenuItem,
            this.añadirActividadesToolStripMenuItem});
            this.actividadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // principalActividadesToolStripMenuItem
            // 
            this.principalActividadesToolStripMenuItem.Name = "principalActividadesToolStripMenuItem";
            this.principalActividadesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.principalActividadesToolStripMenuItem.Text = "Principal";
            this.principalActividadesToolStripMenuItem.Click += new System.EventHandler(this.principalActividadesToolStripMenuItem_Click);
            // 
            // añadirActividadesToolStripMenuItem
            // 
            this.añadirActividadesToolStripMenuItem.Name = "añadirActividadesToolStripMenuItem";
            this.añadirActividadesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.añadirActividadesToolStripMenuItem.Text = "Añadir";
            this.añadirActividadesToolStripMenuItem.Click += new System.EventHandler(this.añadirActividadesToolStripMenuItem_Click);
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalUsuariosToolStripMenuItem1});
            this.UsuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.UsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // principalUsuariosToolStripMenuItem1
            // 
            this.principalUsuariosToolStripMenuItem1.Name = "principalUsuariosToolStripMenuItem1";
            this.principalUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.principalUsuariosToolStripMenuItem1.Text = "Principal";
            this.principalUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.principalUsuariosToolStripMenuItem1_Click);
            // 
            // datosDeRedToolStripMenuItem1
            // 
            this.datosDeRedToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalDatosDeRedToolStripMenuItem2});
            this.datosDeRedToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosDeRedToolStripMenuItem1.Name = "datosDeRedToolStripMenuItem1";
            this.datosDeRedToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.datosDeRedToolStripMenuItem1.Text = "Datos de red";
            // 
            // principalDatosDeRedToolStripMenuItem2
            // 
            this.principalDatosDeRedToolStripMenuItem2.Name = "principalDatosDeRedToolStripMenuItem2";
            this.principalDatosDeRedToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.principalDatosDeRedToolStripMenuItem2.Text = "Principal";
            this.principalDatosDeRedToolStripMenuItem2.Click += new System.EventHandler(this.principalDatosDeRedToolStripMenuItem2_Click);
            // 
            // buttonGuardarLibrerias
            // 
            this.buttonGuardarLibrerias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGuardarLibrerias.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardarLibrerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarLibrerias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuardarLibrerias.ImageIndex = 5;
            this.buttonGuardarLibrerias.ImageList = this.imageList1;
            this.buttonGuardarLibrerias.Location = new System.Drawing.Point(217, 191);
            this.buttonGuardarLibrerias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarLibrerias.Name = "buttonGuardarLibrerias";
            this.buttonGuardarLibrerias.Size = new System.Drawing.Size(44, 41);
            this.buttonGuardarLibrerias.TabIndex = 28;
            this.buttonGuardarLibrerias.UseVisualStyleBackColor = false;
            this.buttonGuardarLibrerias.Click += new System.EventHandler(this.buttonGuardarLibrerias_Click);
            // 
            // FormPrincipalLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.summer_flowers_wood_texture_background_copyspace_40463562;
            this.ClientSize = new System.Drawing.Size(788, 558);
            this.Controls.Add(this.buttonGuardarLibrerias);
            this.Controls.Add(this.LogoPrincipalActividades);
            this.Controls.Add(this.buttonSalirLibreria);
            this.Controls.Add(this.dataGridViewPrincipalLibrerias);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.labelTituloLibrerias);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipalLibrerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalLibrerias";
            this.Activated += new System.EventHandler(this.FormPrincipalLibrerias_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalLibrerias_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipalLibrerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipalLibrerias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrincipalLibrerias;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Label labelTituloLibrerias;
        private System.Windows.Forms.Button buttonSalirLibreria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecontacto;
        private System.Windows.Forms.PictureBox LogoPrincipalActividades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosDeRedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem principalDatosDeRedToolStripMenuItem2;
        private System.Windows.Forms.Button buttonGuardarLibrerias;
    }
}