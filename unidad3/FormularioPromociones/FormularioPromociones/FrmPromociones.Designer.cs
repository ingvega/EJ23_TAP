﻿namespace FormularioPromociones
{
    partial class FrmPromociones
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
            this.picPromocion = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // picPromocion
            // 
            this.picPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPromocion.Image = global::FormularioPromociones.Properties.Resources.img__1_;
            this.picPromocion.Location = new System.Drawing.Point(0, 0);
            this.picPromocion.Name = "picPromocion";
            this.picPromocion.Size = new System.Drawing.Size(279, 216);
            this.picPromocion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPromocion.TabIndex = 0;
            this.picPromocion.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 216);
            this.Controls.Add(this.picPromocion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPromociones";
            this.Text = "Promociones";
            ((System.ComponentModel.ISupportInitialize)(this.picPromocion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPromocion;
        private System.Windows.Forms.Timer timer1;
    }
}