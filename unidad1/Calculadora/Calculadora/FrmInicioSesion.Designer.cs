namespace Calculadora
{
    partial class FrmInicioSesion
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRetroUsuario = new System.Windows.Forms.Label();
            this.lblRetroContrasenia = new System.Windows.Forms.Label();
            this.epErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegistrarme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(164, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(164, 112);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(198, 22);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(141, 163);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(128, 23);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // lblRetroUsuario
            // 
            this.lblRetroUsuario.AutoSize = true;
            this.lblRetroUsuario.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRetroUsuario.Location = new System.Drawing.Point(369, 88);
            this.lblRetroUsuario.Name = "lblRetroUsuario";
            this.lblRetroUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblRetroUsuario.TabIndex = 5;
            // 
            // lblRetroContrasenia
            // 
            this.lblRetroContrasenia.AutoSize = true;
            this.lblRetroContrasenia.Location = new System.Drawing.Point(369, 115);
            this.lblRetroContrasenia.Name = "lblRetroContrasenia";
            this.lblRetroContrasenia.Size = new System.Drawing.Size(0, 16);
            this.lblRetroContrasenia.TabIndex = 6;
            // 
            // epErrores
            // 
            this.epErrores.ContainerControl = this;
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.Location = new System.Drawing.Point(64, 202);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(291, 23);
            this.btnRegistrarme.TabIndex = 7;
            this.btnRegistrarme.Text = "No tengo una cuenta (registrarme)";
            this.btnRegistrarme.UseVisualStyleBackColor = true;
            this.btnRegistrarme.Click += new System.EventHandler(this.btnRegistrarme_Click);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 244);
            this.Controls.Add(this.btnRegistrarme);
            this.Controls.Add(this.lblRetroContrasenia);
            this.Controls.Add(this.lblRetroUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmInicioSesion";
            this.Text = "InicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRetroUsuario;
        private System.Windows.Forms.Label lblRetroContrasenia;
        private System.Windows.Forms.ErrorProvider epErrores;
        private System.Windows.Forms.Button btnRegistrarme;
    }
}