namespace OlorALibro
{
    partial class FormEditarUsuario
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
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.textBoxTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCodPostalUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCorreoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.labelTelefonoUsuario = new System.Windows.Forms.Label();
            this.labelCorreoUsuario = new System.Windows.Forms.Label();
            this.labelContraseñaUsuario = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBoxEdadUsuarios = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelEdadUsuarios = new System.Windows.Forms.Label();
            this.labelCodPostalUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(398, 278);
            this.buttonGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(132, 28);
            this.buttonGuardarUsuario.TabIndex = 17;
            this.buttonGuardarUsuario.Text = "Guardar usuario";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = false;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGuardarUsuario_Click);
            // 
            // textBoxTelefonoUsuario
            // 
            this.textBoxTelefonoUsuario.Location = new System.Drawing.Point(159, 226);
            this.textBoxTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTelefonoUsuario.Name = "textBoxTelefonoUsuario";
            this.textBoxTelefonoUsuario.Size = new System.Drawing.Size(320, 22);
            this.textBoxTelefonoUsuario.TabIndex = 16;
            // 
            // textBoxCodPostalUsuario
            // 
            this.textBoxCodPostalUsuario.Location = new System.Drawing.Point(159, 196);
            this.textBoxCodPostalUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodPostalUsuario.Name = "textBoxCodPostalUsuario";
            this.textBoxCodPostalUsuario.Size = new System.Drawing.Size(320, 22);
            this.textBoxCodPostalUsuario.TabIndex = 15;
            // 
            // textBoxCorreoUsuario
            // 
            this.textBoxCorreoUsuario.Location = new System.Drawing.Point(159, 166);
            this.textBoxCorreoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            this.textBoxCorreoUsuario.Size = new System.Drawing.Size(320, 22);
            this.textBoxCorreoUsuario.TabIndex = 14;
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(159, 136);
            this.textBoxContraseñaUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(320, 22);
            this.textBoxContraseñaUsuario.TabIndex = 13;
            // 
            // labelTelefonoUsuario
            // 
            this.labelTelefonoUsuario.AutoSize = true;
            this.labelTelefonoUsuario.Location = new System.Drawing.Point(45, 231);
            this.labelTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefonoUsuario.Name = "labelTelefonoUsuario";
            this.labelTelefonoUsuario.Size = new System.Drawing.Size(64, 17);
            this.labelTelefonoUsuario.TabIndex = 12;
            this.labelTelefonoUsuario.Text = "Telefono";
            // 
            // labelCorreoUsuario
            // 
            this.labelCorreoUsuario.AutoSize = true;
            this.labelCorreoUsuario.Location = new System.Drawing.Point(45, 171);
            this.labelCorreoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreoUsuario.Name = "labelCorreoUsuario";
            this.labelCorreoUsuario.Size = new System.Drawing.Size(51, 17);
            this.labelCorreoUsuario.TabIndex = 11;
            this.labelCorreoUsuario.Text = "Correo";
            // 
            // labelContraseñaUsuario
            // 
            this.labelContraseñaUsuario.AutoSize = true;
            this.labelContraseñaUsuario.Location = new System.Drawing.Point(45, 139);
            this.labelContraseñaUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseñaUsuario.Name = "labelContraseñaUsuario";
            this.labelContraseñaUsuario.Size = new System.Drawing.Size(81, 17);
            this.labelContraseñaUsuario.TabIndex = 10;
            this.labelContraseñaUsuario.Text = "Contraseña";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(45, 84);
            this.labelNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(58, 17);
            this.labelNombreUsuario.TabIndex = 9;
            this.labelNombreUsuario.Text = "Nombre";
            // 
            // textBoxEdadUsuarios
            // 
            this.textBoxEdadUsuarios.Location = new System.Drawing.Point(159, 107);
            this.textBoxEdadUsuarios.Name = "textBoxEdadUsuarios";
            this.textBoxEdadUsuarios.Size = new System.Drawing.Size(320, 22);
            this.textBoxEdadUsuarios.TabIndex = 18;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(159, 79);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(320, 22);
            this.textBoxNombreUsuario.TabIndex = 19;
            // 
            // labelEdadUsuarios
            // 
            this.labelEdadUsuarios.AutoSize = true;
            this.labelEdadUsuarios.Location = new System.Drawing.Point(45, 110);
            this.labelEdadUsuarios.Name = "labelEdadUsuarios";
            this.labelEdadUsuarios.Size = new System.Drawing.Size(41, 17);
            this.labelEdadUsuarios.TabIndex = 20;
            this.labelEdadUsuarios.Text = "Edad";
            // 
            // labelCodPostalUsuarios
            // 
            this.labelCodPostalUsuarios.AutoSize = true;
            this.labelCodPostalUsuarios.Location = new System.Drawing.Point(45, 199);
            this.labelCodPostalUsuarios.Name = "labelCodPostalUsuarios";
            this.labelCodPostalUsuarios.Size = new System.Drawing.Size(94, 17);
            this.labelCodPostalUsuarios.TabIndex = 21;
            this.labelCodPostalUsuarios.Text = "Codigo postal";
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 319);
            this.Controls.Add(this.labelCodPostalUsuarios);
            this.Controls.Add(this.labelEdadUsuarios);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.textBoxEdadUsuarios);
            this.Controls.Add(this.buttonGuardarUsuario);
            this.Controls.Add(this.textBoxTelefonoUsuario);
            this.Controls.Add(this.textBoxCodPostalUsuario);
            this.Controls.Add(this.textBoxCorreoUsuario);
            this.Controls.Add(this.textBoxContraseñaUsuario);
            this.Controls.Add(this.labelTelefonoUsuario);
            this.Controls.Add(this.labelCorreoUsuario);
            this.Controls.Add(this.labelContraseñaUsuario);
            this.Controls.Add(this.labelNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarUsuario";
            this.Load += new System.EventHandler(this.FormEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarUsuario;
        private System.Windows.Forms.TextBox textBoxTelefonoUsuario;
        private System.Windows.Forms.TextBox textBoxCodPostalUsuario;
        private System.Windows.Forms.TextBox textBoxCorreoUsuario;
        private System.Windows.Forms.TextBox textBoxContraseñaUsuario;
        private System.Windows.Forms.Label labelTelefonoUsuario;
        private System.Windows.Forms.Label labelCorreoUsuario;
        private System.Windows.Forms.Label labelContraseñaUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxEdadUsuarios;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label labelEdadUsuarios;
        private System.Windows.Forms.Label labelCodPostalUsuarios;
    }
}