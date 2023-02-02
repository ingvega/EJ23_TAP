namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(145, 141);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 16);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "0";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(138, 62);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(138, 95);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 5;
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(60, 204);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 34);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.DarkCyan;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.ForeColor = System.Drawing.Color.White;
            this.btnResta.Location = new System.Drawing.Point(141, 204);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 34);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacion.Location = new System.Drawing.Point(222, 204);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(105, 34);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(332, 204);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 34);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.Text = "División";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 309);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
    }
}

