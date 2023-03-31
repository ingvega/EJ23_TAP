namespace HilosCorredores
{
    partial class CorredoresTareas
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
            this.buttonIniciar1 = new System.Windows.Forms.Button();
            this.buttonIniciar2 = new System.Windows.Forms.Button();
            this.buttonIniciar3 = new System.Windows.Forms.Button();
            this.buttonIniciarTodos = new System.Windows.Forms.Button();
            this.picCorredor3 = new System.Windows.Forms.PictureBox();
            this.picCorredor2 = new System.Windows.Forms.PictureBox();
            this.picCorredor1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCorredor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorredor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorredor1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciar1
            // 
            this.buttonIniciar1.Location = new System.Drawing.Point(48, 455);
            this.buttonIniciar1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciar1.Name = "buttonIniciar1";
            this.buttonIniciar1.Size = new System.Drawing.Size(100, 28);
            this.buttonIniciar1.TabIndex = 3;
            this.buttonIniciar1.Text = "Iniciar 1";
            this.buttonIniciar1.UseVisualStyleBackColor = true;
            this.buttonIniciar1.Click += new System.EventHandler(this.buttonIniciar1_Click);
            // 
            // buttonIniciar2
            // 
            this.buttonIniciar2.Location = new System.Drawing.Point(157, 455);
            this.buttonIniciar2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciar2.Name = "buttonIniciar2";
            this.buttonIniciar2.Size = new System.Drawing.Size(100, 28);
            this.buttonIniciar2.TabIndex = 4;
            this.buttonIniciar2.Text = "Iniciar 2";
            this.buttonIniciar2.UseVisualStyleBackColor = true;
            this.buttonIniciar2.Click += new System.EventHandler(this.buttonIniciar2_Click);
            // 
            // buttonIniciar3
            // 
            this.buttonIniciar3.Location = new System.Drawing.Point(265, 455);
            this.buttonIniciar3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciar3.Name = "buttonIniciar3";
            this.buttonIniciar3.Size = new System.Drawing.Size(100, 28);
            this.buttonIniciar3.TabIndex = 5;
            this.buttonIniciar3.Text = "Iniciar 3";
            this.buttonIniciar3.UseVisualStyleBackColor = true;
            this.buttonIniciar3.Click += new System.EventHandler(this.buttonIniciar3_Click);
            // 
            // buttonIniciarTodos
            // 
            this.buttonIniciarTodos.Location = new System.Drawing.Point(48, 492);
            this.buttonIniciarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciarTodos.Name = "buttonIniciarTodos";
            this.buttonIniciarTodos.Size = new System.Drawing.Size(317, 28);
            this.buttonIniciarTodos.TabIndex = 6;
            this.buttonIniciarTodos.Text = "Iniciar todos";
            this.buttonIniciarTodos.UseVisualStyleBackColor = true;
            this.buttonIniciarTodos.Click += new System.EventHandler(this.buttonIniciarTodos_Click);
            // 
            // picCorredor3
            // 
            this.picCorredor3.Image = global::HilosCorredores.Properties.Resources.runner;
            this.picCorredor3.Location = new System.Drawing.Point(48, 303);
            this.picCorredor3.Margin = new System.Windows.Forms.Padding(4);
            this.picCorredor3.Name = "picCorredor3";
            this.picCorredor3.Size = new System.Drawing.Size(111, 97);
            this.picCorredor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCorredor3.TabIndex = 2;
            this.picCorredor3.TabStop = false;
            // 
            // picCorredor2
            // 
            this.picCorredor2.Image = global::HilosCorredores.Properties.Resources.runner;
            this.picCorredor2.Location = new System.Drawing.Point(48, 161);
            this.picCorredor2.Margin = new System.Windows.Forms.Padding(4);
            this.picCorredor2.Name = "picCorredor2";
            this.picCorredor2.Size = new System.Drawing.Size(111, 94);
            this.picCorredor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCorredor2.TabIndex = 1;
            this.picCorredor2.TabStop = false;
            // 
            // picCorredor1
            // 
            this.picCorredor1.Image = global::HilosCorredores.Properties.Resources.runner;
            this.picCorredor1.Location = new System.Drawing.Point(48, 28);
            this.picCorredor1.Margin = new System.Windows.Forms.Padding(4);
            this.picCorredor1.Name = "picCorredor1";
            this.picCorredor1.Size = new System.Drawing.Size(111, 102);
            this.picCorredor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCorredor1.TabIndex = 0;
            this.picCorredor1.TabStop = false;
            // 
            // CorredoresTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonIniciarTodos);
            this.Controls.Add(this.buttonIniciar3);
            this.Controls.Add(this.buttonIniciar2);
            this.Controls.Add(this.buttonIniciar1);
            this.Controls.Add(this.picCorredor3);
            this.Controls.Add(this.picCorredor2);
            this.Controls.Add(this.picCorredor1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CorredoresTareas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCorredor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorredor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorredor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCorredor1;
        private System.Windows.Forms.PictureBox picCorredor2;
        private System.Windows.Forms.PictureBox picCorredor3;
        private System.Windows.Forms.Button buttonIniciar1;
        private System.Windows.Forms.Button buttonIniciar2;
        private System.Windows.Forms.Button buttonIniciar3;
        private System.Windows.Forms.Button buttonIniciarTodos;
    }
}

