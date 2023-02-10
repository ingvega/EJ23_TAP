namespace Calculadora
{
    partial class FrmRegistro
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia1 = new System.Windows.Forms.TextBox();
            this.chkTerminos = new System.Windows.Forms.CheckBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYaTengoCuenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasenia2 = new System.Windows.Forms.TextBox();
            this.epErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 28);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(201, 57);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(234, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasenia1
            // 
            this.txtContrasenia1.Location = new System.Drawing.Point(201, 86);
            this.txtContrasenia1.MaxLength = 20;
            this.txtContrasenia1.Name = "txtContrasenia1";
            this.txtContrasenia1.Size = new System.Drawing.Size(234, 22);
            this.txtContrasenia1.TabIndex = 2;
            this.txtContrasenia1.TextChanged += new System.EventHandler(this.txtContrasenia1_TextChanged);
            // 
            // chkTerminos
            // 
            this.chkTerminos.AutoSize = true;
            this.chkTerminos.Location = new System.Drawing.Point(201, 206);
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.Size = new System.Drawing.Size(233, 20);
            this.chkTerminos.TabIndex = 3;
            this.chkTerminos.Text = "Acepto los términos y condiciones";
            this.chkTerminos.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(201, 141);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(234, 24);
            this.cboEstado.Sorted = true;
            this.cboEstado.TabIndex = 4;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(201, 171);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(234, 24);
            this.cboMunicipio.TabIndex = 5;
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.Location = new System.Drawing.Point(201, 248);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(111, 36);
            this.btnRegistrarme.TabIndex = 6;
            this.btnRegistrarme.Text = "Registrarme";
            this.btnRegistrarme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Municipio";
            // 
            // btnYaTengoCuenta
            // 
            this.btnYaTengoCuenta.Location = new System.Drawing.Point(318, 248);
            this.btnYaTengoCuenta.Name = "btnYaTengoCuenta";
            this.btnYaTengoCuenta.Size = new System.Drawing.Size(162, 36);
            this.btnYaTengoCuenta.TabIndex = 12;
            this.btnYaTengoCuenta.Text = "Ya tengo una cuenta";
            this.btnYaTengoCuenta.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirmar contraseña";
            // 
            // txtContrasenia2
            // 
            this.txtContrasenia2.Location = new System.Drawing.Point(201, 114);
            this.txtContrasenia2.MaxLength = 20;
            this.txtContrasenia2.Name = "txtContrasenia2";
            this.txtContrasenia2.Size = new System.Drawing.Size(234, 22);
            this.txtContrasenia2.TabIndex = 13;
            this.txtContrasenia2.TextChanged += new System.EventHandler(this.txtContrasenia2_TextChanged);
            // 
            // epErrores
            // 
            this.epErrores.ContainerControl = this;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContrasenia2);
            this.Controls.Add(this.btnYaTengoCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarme);
            this.Controls.Add(this.cboMunicipio);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.chkTerminos);
            this.Controls.Add(this.txtContrasenia1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia1;
        private System.Windows.Forms.CheckBox chkTerminos;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYaTengoCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasenia2;
        private System.Windows.Forms.ErrorProvider epErrores;
    }
}