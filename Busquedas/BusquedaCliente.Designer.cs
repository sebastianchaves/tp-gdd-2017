namespace PagoAgilFrba.Busquedas
{
    partial class BusquedaCliente
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
            this.buscarGroupBox = new System.Windows.Forms.GroupBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.descripcionBuscarLabel = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buscarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarGroupBox
            // 
            this.buscarGroupBox.Controls.Add(this.botonVolver);
            this.buscarGroupBox.Controls.Add(this.nombreLabel);
            this.buscarGroupBox.Controls.Add(this.apellidoLabel);
            this.buscarGroupBox.Controls.Add(this.dniLabel);
            this.buscarGroupBox.Controls.Add(this.descripcionBuscarLabel);
            this.buscarGroupBox.Controls.Add(this.botonBuscar);
            this.buscarGroupBox.Controls.Add(this.textBox2);
            this.buscarGroupBox.Controls.Add(this.textBox3);
            this.buscarGroupBox.Controls.Add(this.textBox1);
            this.buscarGroupBox.Location = new System.Drawing.Point(12, 12);
            this.buscarGroupBox.Name = "buscarGroupBox";
            this.buscarGroupBox.Size = new System.Drawing.Size(412, 163);
            this.buscarGroupBox.TabIndex = 5;
            this.buscarGroupBox.TabStop = false;
            this.buscarGroupBox.Text = "Busqueda de Cliente";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(48, 63);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 5;
            this.nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(48, 97);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(47, 13);
            this.apellidoLabel.TabIndex = 6;
            this.apellidoLabel.Text = "Apellido:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(48, 131);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(29, 13);
            this.dniLabel.TabIndex = 7;
            this.dniLabel.Text = "DNI:";
            // 
            // descripcionBuscarLabel
            // 
            this.descripcionBuscarLabel.AutoSize = true;
            this.descripcionBuscarLabel.Location = new System.Drawing.Point(21, 29);
            this.descripcionBuscarLabel.Name = "descripcionBuscarLabel";
            this.descripcionBuscarLabel.Size = new System.Drawing.Size(213, 13);
            this.descripcionBuscarLabel.TabIndex = 3;
            this.descripcionBuscarLabel.Text = "Busque filtrando con los siguientes campos:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(322, 128);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(84, 29);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(322, 93);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(84, 29);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 185);
            this.Controls.Add(this.buscarGroupBox);
            this.Name = "BusquedaCliente";
            this.Text = "BusquedaCliente";
            this.buscarGroupBox.ResumeLayout(false);
            this.buscarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buscarGroupBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label descripcionBuscarLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonVolver;
    }
}