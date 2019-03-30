namespace OlorALibro
{
    partial class FormRellenarLibrerias
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
            this.groupBoxRellenarDatos = new System.Windows.Forms.GroupBox();
            this.textBoxDescripcionRellLibrerias = new System.Windows.Forms.TextBox();
            this.labelDescripcionRellLibreria = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.labelNombreContacto = new System.Windows.Forms.Label();
            this.textBoxnombrecontacto = new System.Windows.Forms.TextBox();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxRellenarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRellenarDatos
            // 
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxDescripcionRellLibrerias);
            this.groupBoxRellenarDatos.Controls.Add(this.labelDescripcionRellLibreria);
            this.groupBoxRellenarDatos.Controls.Add(this.buttonAceptar);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxtelefono);
            this.groupBoxRellenarDatos.Controls.Add(this.labelNombreContacto);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxnombrecontacto);
            this.groupBoxRellenarDatos.Controls.Add(this.labeldireccion);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxdireccion);
            this.groupBoxRellenarDatos.Controls.Add(this.labeltelefono);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxnombre);
            this.groupBoxRellenarDatos.Controls.Add(this.labelNombre);
            this.groupBoxRellenarDatos.Location = new System.Drawing.Point(12, 42);
            this.groupBoxRellenarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRellenarDatos.Name = "groupBoxRellenarDatos";
            this.groupBoxRellenarDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRellenarDatos.Size = new System.Drawing.Size(464, 312);
            this.groupBoxRellenarDatos.TabIndex = 9;
            this.groupBoxRellenarDatos.TabStop = false;
            this.groupBoxRellenarDatos.Text = "Rellenar Datos ";
            // 
            // textBoxDescripcionRellLibrerias
            // 
            this.textBoxDescripcionRellLibrerias.Location = new System.Drawing.Point(203, 210);
            this.textBoxDescripcionRellLibrerias.Multiline = true;
            this.textBoxDescripcionRellLibrerias.Name = "textBoxDescripcionRellLibrerias";
            this.textBoxDescripcionRellLibrerias.Size = new System.Drawing.Size(133, 22);
            this.textBoxDescripcionRellLibrerias.TabIndex = 10;
            // 
            // labelDescripcionRellLibreria
            // 
            this.labelDescripcionRellLibreria.AutoSize = true;
            this.labelDescripcionRellLibreria.Location = new System.Drawing.Point(48, 213);
            this.labelDescripcionRellLibreria.Name = "labelDescripcionRellLibreria";
            this.labelDescripcionRellLibreria.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcionRellLibreria.TabIndex = 9;
            this.labelDescripcionRellLibreria.Text = "Descripción";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(361, 262);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(69, 34);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(203, 125);
            this.textBoxtelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtelefono.MaxLength = 9;
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.Size = new System.Drawing.Size(133, 22);
            this.textBoxtelefono.TabIndex = 1;
            this.textBoxtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtelefono_KeyPress);
            // 
            // labelNombreContacto
            // 
            this.labelNombreContacto.AutoSize = true;
            this.labelNombreContacto.Location = new System.Drawing.Point(48, 174);
            this.labelNombreContacto.Name = "labelNombreContacto";
            this.labelNombreContacto.Size = new System.Drawing.Size(138, 17);
            this.labelNombreContacto.TabIndex = 7;
            this.labelNombreContacto.Text = "Nombre de Contacto";
            // 
            // textBoxnombrecontacto
            // 
            this.textBoxnombrecontacto.Location = new System.Drawing.Point(203, 171);
            this.textBoxnombrecontacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombrecontacto.Name = "textBoxnombrecontacto";
            this.textBoxnombrecontacto.Size = new System.Drawing.Size(133, 22);
            this.textBoxnombrecontacto.TabIndex = 0;
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Location = new System.Drawing.Point(48, 89);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(67, 17);
            this.labeldireccion.TabIndex = 6;
            this.labeldireccion.Text = "Direccion";
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(203, 82);
            this.textBoxdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(133, 22);
            this.textBoxdireccion.TabIndex = 2;
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Location = new System.Drawing.Point(48, 130);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(64, 17);
            this.labeltelefono.TabIndex = 5;
            this.labeltelefono.Text = "Telefono";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(203, 43);
            this.textBoxnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(133, 22);
            this.textBoxnombre.TabIndex = 3;
            this.textBoxnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnombre_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(48, 43);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // FormRellenarLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 384);
            this.Controls.Add(this.groupBoxRellenarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormRellenarLibrerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRellenarLibrerias";
            this.groupBoxRellenarDatos.ResumeLayout(false);
            this.groupBoxRellenarDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRellenarDatos;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.Label labelNombreContacto;
        private System.Windows.Forms.TextBox textBoxnombrecontacto;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDescripcionRellLibrerias;
        private System.Windows.Forms.Label labelDescripcionRellLibreria;
    }
}