namespace FormularioPromociones
{
    partial class FrmPromocionesTareas
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
            this.picPromocion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // picPromocion
            // 
            this.picPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPromocion.Image = global::FormularioPromociones.Properties.Resources.img__1_;
            this.picPromocion.Location = new System.Drawing.Point(0, 0);
            this.picPromocion.Name = "picPromocion";
            this.picPromocion.Size = new System.Drawing.Size(322, 320);
            this.picPromocion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPromocion.TabIndex = 1;
            this.picPromocion.TabStop = false;
            // 
            // FrmPromocionesTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 320);
            this.Controls.Add(this.picPromocion);
            this.Name = "FrmPromocionesTareas";
            this.Text = "FrmPromocionesTareas";
            ((System.ComponentModel.ISupportInitialize)(this.picPromocion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPromocion;
    }
}