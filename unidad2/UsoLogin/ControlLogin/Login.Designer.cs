namespace ControlLogin
{
    partial class Login
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRecordarme = new System.Windows.Forms.CheckBox();
            this.lklRegistrarme = new System.Windows.Forms.LinkLabel();
            this.lklRecuperar = new System.Windows.Forms.LinkLabel();
            this.btnInciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(106, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(226, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(107, 53);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(225, 22);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // chkRecordarme
            // 
            this.chkRecordarme.AutoSize = true;
            this.chkRecordarme.Location = new System.Drawing.Point(106, 98);
            this.chkRecordarme.Name = "chkRecordarme";
            this.chkRecordarme.Size = new System.Drawing.Size(105, 20);
            this.chkRecordarme.TabIndex = 4;
            this.chkRecordarme.Text = "Recordarme";
            this.chkRecordarme.UseVisualStyleBackColor = true;
            // 
            // lklRegistrarme
            // 
            this.lklRegistrarme.AutoSize = true;
            this.lklRegistrarme.Location = new System.Drawing.Point(104, 133);
            this.lklRegistrarme.Name = "lklRegistrarme";
            this.lklRegistrarme.Size = new System.Drawing.Size(190, 16);
            this.lklRegistrarme.TabIndex = 5;
            this.lklRegistrarme.TabStop = true;
            this.lklRegistrarme.Text = "No tengo cuenta (Registrarme)";
            // 
            // lklRecuperar
            // 
            this.lklRecuperar.AutoSize = true;
            this.lklRecuperar.Location = new System.Drawing.Point(104, 155);
            this.lklRecuperar.Name = "lklRecuperar";
            this.lklRecuperar.Size = new System.Drawing.Size(133, 16);
            this.lklRecuperar.TabIndex = 6;
            this.lklRecuperar.TabStop = true;
            this.lklRecuperar.Text = "Olvidé mi contraseña";
            // 
            // btnInciar
            // 
            this.btnInciar.Location = new System.Drawing.Point(107, 189);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(145, 36);
            this.btnInciar.TabIndex = 7;
            this.btnInciar.Text = "Iniciar sesión";
            this.btnInciar.UseVisualStyleBackColor = true;
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInciar);
            this.Controls.Add(this.lklRecuperar);
            this.Controls.Add(this.lklRegistrarme);
            this.Controls.Add(this.chkRecordarme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(357, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRecordarme;
        private System.Windows.Forms.LinkLabel lklRegistrarme;
        private System.Windows.Forms.LinkLabel lklRecuperar;
        private System.Windows.Forms.Button btnInciar;
    }
}
