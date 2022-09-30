namespace Vacunador2022
{
    partial class NuevaDosis
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
            this.lbAp = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDosis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbVacunas = new System.Windows.Forms.ComboBox();
            this.gbDni = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbAp
            // 
            this.lbAp.AutoSize = true;
            this.lbAp.Location = new System.Drawing.Point(102, 19);
            this.lbAp.Name = "lbAp";
            this.lbAp.Size = new System.Drawing.Size(51, 15);
            this.lbAp.TabIndex = 0;
            this.lbAp.Text = "Apellido";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(102, 58);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(51, 15);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vacuna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vacuna";
            // 
            // lbDosis
            // 
            this.lbDosis.AutoSize = true;
            this.lbDosis.Location = new System.Drawing.Point(318, 200);
            this.lbDosis.Name = "lbDosis";
            this.lbDosis.Size = new System.Drawing.Size(45, 15);
            this.lbDosis.TabIndex = 4;
            this.lbDosis.Text = "Vacuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(318, 250);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(36, 15);
            this.lbCantidad.TabIndex = 6;
            this.lbCantidad.Text = "Stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aplicada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(432, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "No guardar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbVacunas
            // 
            this.cbVacunas.FormattingEnabled = true;
            this.cbVacunas.Location = new System.Drawing.Point(102, 136);
            this.cbVacunas.Name = "cbVacunas";
            this.cbVacunas.Size = new System.Drawing.Size(275, 23);
            this.cbVacunas.TabIndex = 9;
            this.cbVacunas.SelectedIndexChanged += new System.EventHandler(this.cbVacunas_SelectedIndexChanged);
            // 
            // gbDni
            // 
            this.gbDni.Location = new System.Drawing.Point(12, 3);
            this.gbDni.Name = "gbDni";
            this.gbDni.Size = new System.Drawing.Size(549, 287);
            this.gbDni.TabIndex = 10;
            this.gbDni.TabStop = false;
            this.gbDni.Text = "Documento:";
            // 
            // NuevaDosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 292);
            this.Controls.Add(this.cbVacunas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDosis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbAp);
            this.Controls.Add(this.gbDni);
            this.Name = "NuevaDosis";
            this.Text = "Registro de dosis aplicada";
            this.Load += new System.EventHandler(this.NuevaDosis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label lbDosis;
        private Button button1;
        private Button btnCancelar;
        private ComboBox cbVacunas;
        public Label lbAp;
        public Label lbNom;
        public Label label3;
        public Label label6;
        public Label lbCantidad;
        public GroupBox gbDni;
    }
}