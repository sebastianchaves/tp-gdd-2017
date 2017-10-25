namespace PagoAgilFrba.AbmSucursal
{
    partial class BajaSucursal
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
            this.bajaSucursalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bajaSucursalLabel
            // 
            this.bajaSucursalLabel.AutoSize = true;
            this.bajaSucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaSucursalLabel.Location = new System.Drawing.Point(82, 9);
            this.bajaSucursalLabel.Name = "bajaSucursalLabel";
            this.bajaSucursalLabel.Size = new System.Drawing.Size(107, 20);
            this.bajaSucursalLabel.TabIndex = 1;
            this.bajaSucursalLabel.Text = "Baja Sucursal";
            // 
            // BajaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bajaSucursalLabel);
            this.Name = "BajaSucursal";
            this.Text = "Baja Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bajaSucursalLabel;
    }
}