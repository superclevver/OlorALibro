namespace OlorALibro
{
    partial class FormDatosXarxa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosXarxa));
            this.buttonPasarAJSON = new System.Windows.Forms.Button();
            this.textBoxProyecto = new System.Windows.Forms.TextBox();
            this.labelTituloDatosRed = new System.Windows.Forms.Label();
            this.LogoPrincipalActividades = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.libreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalLibreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibreriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalActividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirActividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalUsuarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxGrupo = new System.Windows.Forms.TextBox();
            this.labelProyecto = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPasarAJSON
            // 
            this.buttonPasarAJSON.Location = new System.Drawing.Point(644, 503);
            this.buttonPasarAJSON.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPasarAJSON.Name = "buttonPasarAJSON";
            this.buttonPasarAJSON.Size = new System.Drawing.Size(121, 28);
            this.buttonPasarAJSON.TabIndex = 5;
            this.buttonPasarAJSON.Text = "Pasar a JSON";
            this.buttonPasarAJSON.UseVisualStyleBackColor = true;
            this.buttonPasarAJSON.Click += new System.EventHandler(this.buttonPasarAJSON_Click);
            // 
            // textBoxProyecto
            // 
            this.textBoxProyecto.Location = new System.Drawing.Point(128, 234);
            this.textBoxProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProyecto.Multiline = true;
            this.textBoxProyecto.Name = "textBoxProyecto";
            this.textBoxProyecto.Size = new System.Drawing.Size(493, 126);
            this.textBoxProyecto.TabIndex = 4;
            // 
            // labelTituloDatosRed
            // 
            this.labelTituloDatosRed.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloDatosRed.Font = new System.Drawing.Font("Candara", 48F);
            this.labelTituloDatosRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTituloDatosRed.Location = new System.Drawing.Point(185, 25);
            this.labelTituloDatosRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloDatosRed.Name = "labelTituloDatosRed";
            this.labelTituloDatosRed.Size = new System.Drawing.Size(600, 92);
            this.labelTituloDatosRed.TabIndex = 3;
            this.labelTituloDatosRed.Text = "DATOS DE  RED";
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.libreriasToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 157);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 15;
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
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(26, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // libreriasToolStripMenuItem
            // 
            this.libreriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalLibreriasToolStripMenuItem,
            this.añadirLibreriasToolStripMenuItem});
            this.libreriasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libreriasToolStripMenuItem.Name = "libreriasToolStripMenuItem";
            this.libreriasToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.libreriasToolStripMenuItem.Text = "Librerias";
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
            this.añadirLibreriasToolStripMenuItem.Click += new System.EventHandler(this.añadirLibreriasToolStripMenuItem_Click);
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
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalUsuarioToolStripMenuItem2});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // principalUsuarioToolStripMenuItem2
            // 
            this.principalUsuarioToolStripMenuItem2.Name = "principalUsuarioToolStripMenuItem2";
            this.principalUsuarioToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.principalUsuarioToolStripMenuItem2.Text = "Principal";
            this.principalUsuarioToolStripMenuItem2.Click += new System.EventHandler(this.principalUsuariosToolStripMenuItem2_Click);
            // 
            // textBoxGrupo
            // 
            this.textBoxGrupo.Location = new System.Drawing.Point(128, 405);
            this.textBoxGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGrupo.Multiline = true;
            this.textBoxGrupo.Name = "textBoxGrupo";
            this.textBoxGrupo.Size = new System.Drawing.Size(493, 126);
            this.textBoxGrupo.TabIndex = 16;
            // 
            // labelProyecto
            // 
            this.labelProyecto.AutoSize = true;
            this.labelProyecto.BackColor = System.Drawing.Color.Transparent;
            this.labelProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelProyecto.Location = new System.Drawing.Point(264, 205);
            this.labelProyecto.Name = "labelProyecto";
            this.labelProyecto.Size = new System.Drawing.Size(227, 25);
            this.labelProyecto.TabIndex = 17;
            this.labelProyecto.Text = "Descripción proyecto: ";
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.BackColor = System.Drawing.Color.Transparent;
            this.labelGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelGrupo.Location = new System.Drawing.Point(264, 376);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(203, 25);
            this.labelGrupo.TabIndex = 18;
            this.labelGrupo.Text = "Descripción Grupo: ";
            // 
            // FormDatosXarxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OlorALibro.Properties.Resources.summer_flowers_wood_texture_background_copyspace_40463562;
            this.ClientSize = new System.Drawing.Size(788, 558);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.labelProyecto);
            this.Controls.Add(this.textBoxGrupo);
            this.Controls.Add(this.LogoPrincipalActividades);
            this.Controls.Add(this.buttonPasarAJSON);
            this.Controls.Add(this.textBoxProyecto);
            this.Controls.Add(this.labelTituloDatosRed);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormDatosXarxa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatosXarxa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatosXarxa_FormClosing);
            this.Load += new System.EventHandler(this.FormDadesXarxa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPasarAJSON;
        private System.Windows.Forms.TextBox textBoxProyecto;
        private System.Windows.Forms.Label labelTituloDatosRed;
        private System.Windows.Forms.PictureBox LogoPrincipalActividades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalLibreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibreriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalActividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem añadirActividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem principalUsuarioToolStripMenuItem2;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.Label labelProyecto;
        private System.Windows.Forms.Label labelGrupo;
    }
}