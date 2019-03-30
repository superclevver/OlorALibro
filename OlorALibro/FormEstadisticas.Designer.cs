namespace OlorALibro
{
    partial class FormEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticas));
            this.labelEstadisticas = new System.Windows.Forms.Label();
            this.LogoPrincipalActividades = new System.Windows.Forms.PictureBox();
            this.menuStripActividades = new System.Windows.Forms.MenuStrip();
            this.InicioToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LibreriasToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.principalLibreriasToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreriasToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.principalActividadesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirActividadesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.principalUsuariosToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeRedToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.principalDatosDeRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.NombreActividades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelActividades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).BeginInit();
            this.menuStripActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEstadisticas
            // 
            this.labelEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.labelEstadisticas.Font = new System.Drawing.Font("Candara", 48F);
            this.labelEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelEstadisticas.Location = new System.Drawing.Point(188, 31);
            this.labelEstadisticas.Margin = new System.Windows.Forms.Padding(0);
            this.labelEstadisticas.Name = "labelEstadisticas";
            this.labelEstadisticas.Size = new System.Drawing.Size(516, 94);
            this.labelEstadisticas.TabIndex = 13;
            this.labelEstadisticas.Text = "ESTADISTICAS";
            this.labelEstadisticas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEstadisticas.UseCompatibleTextRendering = true;
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
            this.LogoPrincipalActividades.TabIndex = 14;
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
            this.InicioToolStrip,
            this.LibreriasToolStrip,
            this.actividadesToolStrip,
            this.UsuariosToolStrip,
            this.datosDeRedToolStrip});
            this.menuStripActividades.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripActividades.Location = new System.Drawing.Point(6, 183);
            this.menuStripActividades.Name = "menuStripActividades";
            this.menuStripActividades.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripActividades.Size = new System.Drawing.Size(789, 28);
            this.menuStripActividades.TabIndex = 27;
            this.menuStripActividades.Text = "menuStripActividades";
            // 
            // InicioToolStrip
            // 
            this.InicioToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioToolStrip.ForeColor = System.Drawing.Color.Black;
            this.InicioToolStrip.Name = "InicioToolStrip";
            this.InicioToolStrip.Size = new System.Drawing.Size(59, 24);
            this.InicioToolStrip.Text = "Inicio";
            // 
            // LibreriasToolStrip
            // 
            this.LibreriasToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalLibreriasToolStrip,
            this.añadirLibreriasToolStrip});
            this.LibreriasToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibreriasToolStrip.ForeColor = System.Drawing.Color.Black;
            this.LibreriasToolStrip.Name = "LibreriasToolStrip";
            this.LibreriasToolStrip.Size = new System.Drawing.Size(81, 24);
            this.LibreriasToolStrip.Text = "Librerias";
            // 
            // principalLibreriasToolStrip
            // 
            this.principalLibreriasToolStrip.Name = "principalLibreriasToolStrip";
            this.principalLibreriasToolStrip.Size = new System.Drawing.Size(144, 26);
            this.principalLibreriasToolStrip.Text = "Principal";
            // 
            // añadirLibreriasToolStrip
            // 
            this.añadirLibreriasToolStrip.Name = "añadirLibreriasToolStrip";
            this.añadirLibreriasToolStrip.Size = new System.Drawing.Size(144, 26);
            this.añadirLibreriasToolStrip.Text = "Añadir";
            // 
            // actividadesToolStrip
            // 
            this.actividadesToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalActividadesToolStrip,
            this.añadirActividadesToolStrip});
            this.actividadesToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actividadesToolStrip.ForeColor = System.Drawing.Color.Black;
            this.actividadesToolStrip.Name = "actividadesToolStrip";
            this.actividadesToolStrip.Size = new System.Drawing.Size(102, 24);
            this.actividadesToolStrip.Text = "Actividades";
            // 
            // principalActividadesToolStrip
            // 
            this.principalActividadesToolStrip.Name = "principalActividadesToolStrip";
            this.principalActividadesToolStrip.Size = new System.Drawing.Size(144, 26);
            this.principalActividadesToolStrip.Text = "Principal";
            // 
            // añadirActividadesToolStrip
            // 
            this.añadirActividadesToolStrip.Name = "añadirActividadesToolStrip";
            this.añadirActividadesToolStrip.Size = new System.Drawing.Size(144, 26);
            this.añadirActividadesToolStrip.Text = "Añadir";
            // 
            // UsuariosToolStrip
            // 
            this.UsuariosToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalUsuariosToolStrip});
            this.UsuariosToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosToolStrip.ForeColor = System.Drawing.Color.Black;
            this.UsuariosToolStrip.Name = "UsuariosToolStrip";
            this.UsuariosToolStrip.Size = new System.Drawing.Size(82, 24);
            this.UsuariosToolStrip.Text = "Usuarios";
            // 
            // principalUsuariosToolStrip
            // 
            this.principalUsuariosToolStrip.Name = "principalUsuariosToolStrip";
            this.principalUsuariosToolStrip.Size = new System.Drawing.Size(144, 26);
            this.principalUsuariosToolStrip.Text = "Principal";
            // 
            // datosDeRedToolStrip
            // 
            this.datosDeRedToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalDatosDeRedToolStripMenuItem});
            this.datosDeRedToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosDeRedToolStrip.Name = "datosDeRedToolStrip";
            this.datosDeRedToolStrip.Size = new System.Drawing.Size(110, 24);
            this.datosDeRedToolStrip.Text = "Datos de red";
            // 
            // principalDatosDeRedToolStripMenuItem
            // 
            this.principalDatosDeRedToolStripMenuItem.Name = "principalDatosDeRedToolStripMenuItem";
            this.principalDatosDeRedToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.principalDatosDeRedToolStripMenuItem.Text = "Principal";
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AllowUserToAddRows = false;
            this.dataGridViewActividades.AllowUserToDeleteRows = false;
            this.dataGridViewActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreActividades,
            this.contador});
            this.dataGridViewActividades.Location = new System.Drawing.Point(48, 298);
            this.dataGridViewActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.ReadOnly = true;
            this.dataGridViewActividades.RowTemplate.Height = 24;
            this.dataGridViewActividades.Size = new System.Drawing.Size(713, 282);
            this.dataGridViewActividades.TabIndex = 29;
            // 
            // NombreActividades
            // 
            this.NombreActividades.DataPropertyName = "nombre";
            this.NombreActividades.HeaderText = "Nombre";
            this.NombreActividades.Name = "NombreActividades";
            this.NombreActividades.ReadOnly = true;
            // 
            // contador
            // 
            this.contador.DataPropertyName = "contador";
            this.contador.HeaderText = "Librerias";
            this.contador.Name = "contador";
            this.contador.ReadOnly = true;
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.BackColor = System.Drawing.Color.Transparent;
            this.labelActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelActividades.Location = new System.Drawing.Point(276, 231);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(235, 46);
            this.labelActividades.TabIndex = 32;
            this.labelActividades.Text = "Actividades";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.summer_flowers_wood_texture_background_copyspace_40463562;
            this.ClientSize = new System.Drawing.Size(801, 605);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.dataGridViewActividades);
            this.Controls.Add(this.menuStripActividades);
            this.Controls.Add(this.LogoPrincipalActividades);
            this.Controls.Add(this.labelEstadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).EndInit();
            this.menuStripActividades.ResumeLayout(false);
            this.menuStripActividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstadisticas;
        private System.Windows.Forms.PictureBox LogoPrincipalActividades;
        private System.Windows.Forms.MenuStrip menuStripActividades;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStrip;
        private System.Windows.Forms.ToolStripMenuItem LibreriasToolStrip;
        private System.Windows.Forms.ToolStripMenuItem principalLibreriasToolStrip;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreriasToolStrip;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem principalActividadesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStrip;
        private System.Windows.Forms.ToolStripMenuItem principalUsuariosToolStrip;
        private System.Windows.Forms.ToolStripMenuItem datosDeRedToolStrip;
        private System.Windows.Forms.ToolStripMenuItem principalDatosDeRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirActividadesToolStrip;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
    }
}