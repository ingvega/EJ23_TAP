namespace Vista
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
            this.dgvCaterorias = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaterorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaterorias
            // 
            this.dgvCaterorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaterorias.Location = new System.Drawing.Point(12, 72);
            this.dgvCaterorias.Name = "dgvCaterorias";
            this.dgvCaterorias.RowHeadersWidth = 51;
            this.dgvCaterorias.RowTemplate.Height = 24;
            this.dgvCaterorias.Size = new System.Drawing.Size(594, 352);
            this.dgvCaterorias.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(306, 23);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(242, 24);
            this.cboCategorias.TabIndex = 3;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(554, 23);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 4;
            this.btnIndex.Text = "Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(645, 25);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(75, 23);
            this.btnItem.TabIndex = 5;
            this.btnItem.Text = "Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(739, 25);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(75, 23);
            this.btnValue.TabIndex = 6;
            this.btnValue.Text = "Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCaterorias);
            this.Name = "Form1";
            this.Text = "Catálogo de categorías";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaterorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaterorias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnValue;
    }
}

