namespace OlorALibro
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.buttonEditarUsuario = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonBorrarUsuarios = new System.Windows.Forms.Button();
            this.labelTituloUsuarios = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.buttonSalirUsuarios = new System.Windows.Forms.Button();
            this.LogoPrincipalActividades = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.libreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalLibreriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalActividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirActividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGuardarUsuarios = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditarUsuario.ImageIndex = 0;
            this.buttonEditarUsuario.ImageList = this.imageList1;
            this.buttonEditarUsuario.Location = new System.Drawing.Point(120, 192);
            this.buttonEditarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(44, 41);
            this.buttonEditarUsuario.TabIndex = 7;
            this.buttonEditarUsuario.UseVisualStyleBackColor = true;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
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
            // buttonBorrarUsuarios
            // 
            this.buttonBorrarUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBorrarUsuarios.ImageIndex = 1;
            this.buttonBorrarUsuarios.ImageList = this.imageList1;
            this.buttonBorrarUsuarios.Location = new System.Drawing.Point(68, 191);
            this.buttonBorrarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrarUsuarios.Name = "buttonBorrarUsuarios";
            this.buttonBorrarUsuarios.Size = new System.Drawing.Size(44, 41);
            this.buttonBorrarUsuarios.TabIndex = 6;
            this.buttonBorrarUsuarios.UseVisualStyleBackColor = true;
            this.buttonBorrarUsuarios.Click += new System.EventHandler(this.buttonBorrarUsuarios_Click);
            // 
            // labelTituloUsuarios
            // 
            this.labelTituloUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloUsuarios.Font = new System.Drawing.Font("Candara", 48F);
            this.labelTituloUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTituloUsuarios.Location = new System.Drawing.Point(276, 32);
            this.labelTituloUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloUsuarios.Name = "labelTituloUsuarios";
            this.labelTituloUsuarios.Size = new System.Drawing.Size(568, 108);
            this.labelTituloUsuarios.TabIndex = 5;
            this.labelTituloUsuarios.Text = "USUARIOS";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Edad,
            this.contraseña,
            this.correo,
            this.CodigoPostal,
            this.telefono});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(67, 238);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(656, 305);
            this.dataGridViewUsuarios.TabIndex = 18;
            // 
            // buttonSalirUsuarios
            // 
            this.buttonSalirUsuarios.ImageIndex = 4;
            this.buttonSalirUsuarios.ImageList = this.imageList1;
            this.buttonSalirUsuarios.Location = new System.Drawing.Point(222, 191);
            this.buttonSalirUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalirUsuarios.Name = "buttonSalirUsuarios";
            this.buttonSalirUsuarios.Size = new System.Drawing.Size(44, 41);
            this.buttonSalirUsuarios.TabIndex = 20;
            this.buttonSalirUsuarios.UseVisualStyleBackColor = true;
            this.buttonSalirUsuarios.Click += new System.EventHandler(this.buttonSalirUsuarios_Click);
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
            this.LogoPrincipalActividades.TabIndex = 21;
            this.LogoPrincipalActividades.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.libreriasToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.datosDeRedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 160);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 22;
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
            // libreriasToolStripMenuItem
            // 
            this.libreriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalLibreriaToolStripMenuItem,
            this.añadirLibreriaToolStripMenuItem});
            this.libreriasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libreriasToolStripMenuItem.Name = "libreriasToolStripMenuItem";
            this.libreriasToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.libreriasToolStripMenuItem.Text = "Librerias";
            // 
            // principalLibreriaToolStripMenuItem
            // 
            this.principalLibreriaToolStripMenuItem.Name = "principalLibreriaToolStripMenuItem";
            this.principalLibreriaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.principalLibreriaToolStripMenuItem.Text = "Principal";
            this.principalLibreriaToolStripMenuItem.Click += new System.EventHandler(this.principalLibreriaToolStripMenuItem_Click);
            // 
            // añadirLibreriaToolStripMenuItem
            // 
            this.añadirLibreriaToolStripMenuItem.Name = "añadirLibreriaToolStripMenuItem";
            this.añadirLibreriaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.añadirLibreriaToolStripMenuItem.Text = "Añadir";
            this.añadirLibreriaToolStripMenuItem.Click += new System.EventHandler(this.añadirLibreriasToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalActividadesToolStripMenuItem1,
            this.añadirActividadesToolStripMenuItem1});
            this.actividadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // principalActividadesToolStripMenuItem1
            // 
            this.principalActividadesToolStripMenuItem1.Name = "principalActividadesToolStripMenuItem1";
            this.principalActividadesToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.principalActividadesToolStripMenuItem1.Text = "Principal";
            this.principalActividadesToolStripMenuItem1.Click += new System.EventHandler(this.principalActividadesToolStripMenuItem1_Click);
            // 
            // añadirActividadesToolStripMenuItem1
            // 
            this.añadirActividadesToolStripMenuItem1.Name = "añadirActividadesToolStripMenuItem1";
            this.añadirActividadesToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.añadirActividadesToolStripMenuItem1.Text = "Añadir";
            this.añadirActividadesToolStripMenuItem1.Click += new System.EventHandler(this.añadirActividadesToolStripMenuItem1_Click);
            // 
            // datosDeRedToolStripMenuItem
            // 
            this.datosDeRedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem2});
            this.datosDeRedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosDeRedToolStripMenuItem.Name = "datosDeRedToolStripMenuItem";
            this.datosDeRedToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.datosDeRedToolStripMenuItem.Text = "Datos de red";
            // 
            // principalToolStripMenuItem2
            // 
            this.principalToolStripMenuItem2.Name = "principalToolStripMenuItem2";
            this.principalToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.principalToolStripMenuItem2.Text = "Principal";
            this.principalToolStripMenuItem2.Click += new System.EventHandler(this.principalDatosDeRedToolStripMenuItem2_Click);
            // 
            // buttonGuardarUsuarios
            // 
            this.buttonGuardarUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGuardarUsuarios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuardarUsuarios.ImageIndex = 5;
            this.buttonGuardarUsuarios.ImageList = this.imageList1;
            this.buttonGuardarUsuarios.Location = new System.Drawing.Point(171, 192);
            this.buttonGuardarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarUsuarios.Name = "buttonGuardarUsuarios";
            this.buttonGuardarUsuarios.Size = new System.Drawing.Size(44, 41);
            this.buttonGuardarUsuarios.TabIndex = 28;
            this.buttonGuardarUsuarios.UseVisualStyleBackColor = false;
            this.buttonGuardarUsuarios.Click += new System.EventHandler(this.buttonGuardarUsuarios_Click);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.DataPropertyName = "codiPostal";
            this.CodigoPostal.HeaderText = "Cod. Postal";
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.summer_flowers_wood_texture_background_copyspace_40463562;
            this.ClientSize = new System.Drawing.Size(788, 558);
            this.Controls.Add(this.buttonGuardarUsuarios);
            this.Controls.Add(this.LogoPrincipalActividades);
            this.Controls.Add(this.buttonSalirUsuarios);
            this.Controls.Add(this.buttonEditarUsuario);
            this.Controls.Add(this.buttonBorrarUsuarios);
            this.Controls.Add(this.labelTituloUsuarios);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditarUsuario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonBorrarUsuarios;
        private System.Windows.Forms.Label labelTituloUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonSalirUsuarios;
        private System.Windows.Forms.PictureBox LogoPrincipalActividades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalLibreriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalActividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem añadirActividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosDeRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem2;
        private System.Windows.Forms.Button buttonGuardarUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}