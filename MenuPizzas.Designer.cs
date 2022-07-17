namespace ejemploclase
{
    partial class Pizzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizzas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpPizzas = new System.Windows.Forms.GroupBox();
            this.nmrCantidad = new System.Windows.Forms.NumericUpDown();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.btCalcula = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPizzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).BeginInit();
            this.grpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizzas (incluye 1 queso)";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(79, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Chica $250";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mediana $300";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Grande $450";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Familiar $500";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(274, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ingredientes (adicionales)";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 92);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(119, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Piña y Palmito $190";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Roquefort $120";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Con papas $100";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Extra Queso $70";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grpPizzas
            // 
            this.grpPizzas.BackColor = System.Drawing.Color.Chocolate;
            this.grpPizzas.Controls.Add(this.nmrCantidad);
            this.grpPizzas.Location = new System.Drawing.Point(12, 179);
            this.grpPizzas.Name = "grpPizzas";
            this.grpPizzas.Size = new System.Drawing.Size(210, 127);
            this.grpPizzas.TabIndex = 2;
            this.grpPizzas.TabStop = false;
            this.grpPizzas.Text = "Numero de Pizas= a esta";
            // 
            // nmrCantidad
            // 
            this.nmrCantidad.Location = new System.Drawing.Point(6, 28);
            this.nmrCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCantidad.Name = "nmrCantidad";
            this.nmrCantidad.Size = new System.Drawing.Size(120, 20);
            this.nmrCantidad.TabIndex = 0;
            this.nmrCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpTotal
            // 
            this.grpTotal.BackColor = System.Drawing.Color.Chocolate;
            this.grpTotal.Controls.Add(this.lblTotal1);
            this.grpTotal.Location = new System.Drawing.Point(12, 322);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(126, 74);
            this.grpTotal.TabIndex = 1;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(17, 32);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(16, 17);
            this.lblTotal1.TabIndex = 0;
            this.lblTotal1.Text = "$";
            // 
            // btCalcula
            // 
            this.btCalcula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btCalcula.Font = new System.Drawing.Font("MS Outlook", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcula.Location = new System.Drawing.Point(433, 231);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(154, 39);
            this.btCalcula.TabIndex = 3;
            this.btCalcula.Text = "Calcular Orden";
            this.btCalcula.UseVisualStyleBackColor = false;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btBorrar.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(496, 276);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(91, 39);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // Pizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 464);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpPizzas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pizzas";
            this.Text = "Pida sus pizzas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpPizzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).EndInit();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpPizzas;
        private System.Windows.Forms.NumericUpDown nmrCantidad;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lblTotal1;
    }
}

