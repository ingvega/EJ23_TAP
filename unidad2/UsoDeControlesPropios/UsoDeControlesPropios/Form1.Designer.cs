namespace UsoDeControlesPropios
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
            this.passwordTextBox1 = new ControlesDeUsuario.PasswordTextBox();
            this.focusableTextBox3 = new ControlesDeUsuario.FocusableTextBox();
            this.focusableTextBox2 = new ControlesDeUsuario.FocusableTextBox();
            this.focusableTextBox1 = new ControlesDeUsuario.FocusableTextBox();
            this.SuspendLayout();
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.behavior = ControlesDeUsuario.Behavior.Click;
            this.passwordTextBox1.Location = new System.Drawing.Point(30, 193);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(386, 36);
            this.passwordTextBox1.TabIndex = 3;
            // 
            // focusableTextBox3
            // 
            this.focusableTextBox3.FocusColor = System.Drawing.Color.LightBlue;
            this.focusableTextBox3.Location = new System.Drawing.Point(170, 133);
            this.focusableTextBox3.Name = "focusableTextBox3";
            this.focusableTextBox3.Size = new System.Drawing.Size(100, 22);
            this.focusableTextBox3.TabIndex = 2;
            // 
            // focusableTextBox2
            // 
            this.focusableTextBox2.FocusColor = System.Drawing.Color.LightBlue;
            this.focusableTextBox2.Location = new System.Drawing.Point(170, 104);
            this.focusableTextBox2.Name = "focusableTextBox2";
            this.focusableTextBox2.Size = new System.Drawing.Size(100, 22);
            this.focusableTextBox2.TabIndex = 1;
            // 
            // focusableTextBox1
            // 
            this.focusableTextBox1.FocusColor = System.Drawing.Color.LightBlue;
            this.focusableTextBox1.Location = new System.Drawing.Point(170, 75);
            this.focusableTextBox1.Name = "focusableTextBox1";
            this.focusableTextBox1.Size = new System.Drawing.Size(100, 22);
            this.focusableTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 264);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.focusableTextBox3);
            this.Controls.Add(this.focusableTextBox2);
            this.Controls.Add(this.focusableTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesDeUsuario.FocusableTextBox focusableTextBox1;
        private ControlesDeUsuario.FocusableTextBox focusableTextBox2;
        private ControlesDeUsuario.FocusableTextBox focusableTextBox3;
        private ControlesDeUsuario.PasswordTextBox passwordTextBox1;
    }
}

