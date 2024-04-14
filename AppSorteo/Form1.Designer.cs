namespace AppSorteo
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
            this.btnGenerador = new System.Windows.Forms.Button();
            this.txtBoxNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDuo = new System.Windows.Forms.CheckBox();
            this.chkTrio = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlContador = new System.Windows.Forms.Label();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.lvlG3 = new System.Windows.Forms.Label();
            this.lvlG1 = new System.Windows.Forms.Label();
            this.lvlG2 = new System.Windows.Forms.Label();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.lvlG6 = new System.Windows.Forms.Label();
            this.lvlG5 = new System.Windows.Forms.Label();
            this.lvlG4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Grupo3 = new System.Windows.Forms.GroupBox();
            this.lvlG8 = new System.Windows.Forms.Label();
            this.lvlG7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Grupo1.SuspendLayout();
            this.Grupo2.SuspendLayout();
            this.Grupo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerador
            // 
            this.btnGenerador.Location = new System.Drawing.Point(80, 408);
            this.btnGenerador.Name = "btnGenerador";
            this.btnGenerador.Size = new System.Drawing.Size(131, 43);
            this.btnGenerador.TabIndex = 0;
            this.btnGenerador.Text = "Generar Grupos";
            this.btnGenerador.UseVisualStyleBackColor = true;
            this.btnGenerador.Click += new System.EventHandler(this.btnGenerador_Click);
            // 
            // txtBoxNombres
            // 
            this.txtBoxNombres.Location = new System.Drawing.Point(12, 60);
            this.txtBoxNombres.Multiline = true;
            this.txtBoxNombres.Name = "txtBoxNombres";
            this.txtBoxNombres.Size = new System.Drawing.Size(240, 196);
            this.txtBoxNombres.TabIndex = 1;
            this.txtBoxNombres.TextChanged += new System.EventHandler(this.txtBoxNombres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Integrantes de grupo";
            // 
            // chkDuo
            // 
            this.chkDuo.AutoSize = true;
            this.chkDuo.Checked = true;
            this.chkDuo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDuo.Location = new System.Drawing.Point(20, 33);
            this.chkDuo.Name = "chkDuo";
            this.chkDuo.Size = new System.Drawing.Size(61, 20);
            this.chkDuo.TabIndex = 3;
            this.chkDuo.Text = "Duos";
            this.chkDuo.UseVisualStyleBackColor = true;
            this.chkDuo.Click += new System.EventHandler(this.chkDuo_Click);
            // 
            // chkTrio
            // 
            this.chkTrio.AutoSize = true;
            this.chkTrio.Location = new System.Drawing.Point(20, 60);
            this.chkTrio.Name = "chkTrio";
            this.chkTrio.Size = new System.Drawing.Size(60, 20);
            this.chkTrio.TabIndex = 4;
            this.chkTrio.Text = "Trios";
            this.chkTrio.UseVisualStyleBackColor = true;
            this.chkTrio.Click += new System.EventHandler(this.chkTrio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTrio);
            this.groupBox1.Controls.Add(this.chkDuo);
            this.groupBox1.Location = new System.Drawing.Point(48, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupos en";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad Alumnos: ";
            // 
            // lvlContador
            // 
            this.lvlContador.AutoSize = true;
            this.lvlContador.Location = new System.Drawing.Point(395, 63);
            this.lvlContador.Name = "lvlContador";
            this.lvlContador.Size = new System.Drawing.Size(14, 16);
            this.lvlContador.TabIndex = 7;
            this.lvlContador.Text = "0";
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.lvlG3);
            this.Grupo1.Controls.Add(this.lvlG1);
            this.Grupo1.Controls.Add(this.lvlG2);
            this.Grupo1.Location = new System.Drawing.Point(270, 90);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(200, 100);
            this.Grupo1.TabIndex = 8;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Grupo 1";
            this.Grupo1.Visible = false;
            // 
            // lvlG3
            // 
            this.lvlG3.AutoSize = true;
            this.lvlG3.Location = new System.Drawing.Point(20, 70);
            this.lvlG3.Name = "lvlG3";
            this.lvlG3.Size = new System.Drawing.Size(44, 16);
            this.lvlG3.TabIndex = 2;
            this.lvlG3.Text = "label5";
            // 
            // lvlG1
            // 
            this.lvlG1.AutoSize = true;
            this.lvlG1.Location = new System.Drawing.Point(20, 20);
            this.lvlG1.Name = "lvlG1";
            this.lvlG1.Size = new System.Drawing.Size(44, 16);
            this.lvlG1.TabIndex = 0;
            this.lvlG1.Text = "label3";
            // 
            // lvlG2
            // 
            this.lvlG2.AutoSize = true;
            this.lvlG2.Location = new System.Drawing.Point(20, 45);
            this.lvlG2.Name = "lvlG2";
            this.lvlG2.Size = new System.Drawing.Size(44, 16);
            this.lvlG2.TabIndex = 1;
            this.lvlG2.Text = "label4";
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.lvlG6);
            this.Grupo2.Controls.Add(this.lvlG5);
            this.Grupo2.Controls.Add(this.lvlG4);
            this.Grupo2.Location = new System.Drawing.Point(270, 207);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(200, 100);
            this.Grupo2.TabIndex = 9;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Grupo 2";
            this.Grupo2.Visible = false;
            // 
            // lvlG6
            // 
            this.lvlG6.AutoSize = true;
            this.lvlG6.Location = new System.Drawing.Point(20, 70);
            this.lvlG6.Name = "lvlG6";
            this.lvlG6.Size = new System.Drawing.Size(44, 16);
            this.lvlG6.TabIndex = 2;
            this.lvlG6.Text = "label8";
            // 
            // lvlG5
            // 
            this.lvlG5.AutoSize = true;
            this.lvlG5.Location = new System.Drawing.Point(20, 45);
            this.lvlG5.Name = "lvlG5";
            this.lvlG5.Size = new System.Drawing.Size(44, 16);
            this.lvlG5.TabIndex = 1;
            this.lvlG5.Text = "label7";
            // 
            // lvlG4
            // 
            this.lvlG4.AutoSize = true;
            this.lvlG4.Location = new System.Drawing.Point(20, 20);
            this.lvlG4.Name = "lvlG4";
            this.lvlG4.Size = new System.Drawing.Size(44, 16);
            this.lvlG4.TabIndex = 0;
            this.lvlG4.Text = "label6";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 263);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Grupo3
            // 
            this.Grupo3.Controls.Add(this.lvlG8);
            this.Grupo3.Controls.Add(this.lvlG7);
            this.Grupo3.Location = new System.Drawing.Point(270, 330);
            this.Grupo3.Name = "Grupo3";
            this.Grupo3.Size = new System.Drawing.Size(200, 100);
            this.Grupo3.TabIndex = 11;
            this.Grupo3.TabStop = false;
            this.Grupo3.Text = "Grupo 3";
            this.Grupo3.Visible = false;
            // 
            // lvlG8
            // 
            this.lvlG8.AutoSize = true;
            this.lvlG8.Location = new System.Drawing.Point(20, 45);
            this.lvlG8.Name = "lvlG8";
            this.lvlG8.Size = new System.Drawing.Size(44, 16);
            this.lvlG8.TabIndex = 1;
            this.lvlG8.Text = "label4";
            // 
            // lvlG7
            // 
            this.lvlG7.AutoSize = true;
            this.lvlG7.Location = new System.Drawing.Point(20, 20);
            this.lvlG7.Name = "lvlG7";
            this.lvlG7.Size = new System.Drawing.Size(44, 16);
            this.lvlG7.TabIndex = 0;
            this.lvlG7.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 494);
            this.Controls.Add(this.Grupo3);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.lvlContador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNombres);
            this.Controls.Add(this.btnGenerador);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App de Sorteo de Compañeros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.Grupo3.ResumeLayout(false);
            this.Grupo3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerador;
        private System.Windows.Forms.TextBox txtBoxNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDuo;
        private System.Windows.Forms.CheckBox chkTrio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lvlContador;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label lvlG1;
        private System.Windows.Forms.Label lvlG2;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lvlG3;
        private System.Windows.Forms.Label lvlG6;
        private System.Windows.Forms.Label lvlG5;
        private System.Windows.Forms.Label lvlG4;
        private System.Windows.Forms.GroupBox Grupo3;
        private System.Windows.Forms.Label lvlG8;
        private System.Windows.Forms.Label lvlG7;
    }
}

