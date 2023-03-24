namespace HilosCorredores
{
    partial class Form1
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnIniciarT1 = new System.Windows.Forms.Button();
            this.btnIniciarT2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(123, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(331, 22);
            this.txtValor.TabIndex = 0;
            // 
            // btnIniciarT1
            // 
            this.btnIniciarT1.Location = new System.Drawing.Point(142, 180);
            this.btnIniciarT1.Name = "btnIniciarT1";
            this.btnIniciarT1.Size = new System.Drawing.Size(122, 35);
            this.btnIniciarT1.TabIndex = 1;
            this.btnIniciarT1.Text = "Tarea 1";
            this.btnIniciarT1.UseVisualStyleBackColor = true;
            this.btnIniciarT1.Click += new System.EventHandler(this.btnIniciarT1_Click);
            // 
            // btnIniciarT2
            // 
            this.btnIniciarT2.Location = new System.Drawing.Point(323, 180);
            this.btnIniciarT2.Name = "btnIniciarT2";
            this.btnIniciarT2.Size = new System.Drawing.Size(122, 35);
            this.btnIniciarT2.TabIndex = 2;
            this.btnIniciarT2.Text = "Tarea 2";
            this.btnIniciarT2.UseVisualStyleBackColor = true;
            this.btnIniciarT2.Click += new System.EventHandler(this.btnIniciarT2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 343);
            this.Controls.Add(this.btnIniciarT2);
            this.Controls.Add(this.btnIniciarT1);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnIniciarT1;
        private System.Windows.Forms.Button btnIniciarT2;
    }
}