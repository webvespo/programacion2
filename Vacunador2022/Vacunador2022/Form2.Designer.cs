namespace Vacunador2022
{
    partial class FormNuevaPersona
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAplicarDosis = new System.Windows.Forms.Button();
            this.btnVolverForm1 = new System.Windows.Forms.Button();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRecorrer = new System.Windows.Forms.Label();
            this.lbCantDni = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbInformes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(694, 45);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 29);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Guardar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAplicarDosis
            // 
            this.btnAplicarDosis.Location = new System.Drawing.Point(694, 116);
            this.btnAplicarDosis.Name = "btnAplicarDosis";
            this.btnAplicarDosis.Size = new System.Drawing.Size(94, 29);
            this.btnAplicarDosis.TabIndex = 1;
            this.btnAplicarDosis.Text = "Vacunar";
            this.btnAplicarDosis.UseVisualStyleBackColor = true;
            this.btnAplicarDosis.Click += new System.EventHandler(this.btnAplicarDosis_Click);
            // 
            // btnVolverForm1
            // 
            this.btnVolverForm1.Location = new System.Drawing.Point(694, 321);
            this.btnVolverForm1.Name = "btnVolverForm1";
            this.btnVolverForm1.Size = new System.Drawing.Size(94, 29);
            this.btnVolverForm1.TabIndex = 2;
            this.btnVolverForm1.Text = "Salir";
            this.btnVolverForm1.UseVisualStyleBackColor = true;
            this.btnVolverForm1.Click += new System.EventHandler(this.btnVolverForm1_Click);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(64, 47);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(161, 27);
            this.txtNumDoc.TabIndex = 3;
            this.txtNumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDoc_KeyPress);
            this.txtNumDoc.Leave += new System.EventHandler(this.txtNumDoc_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(251, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 27);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(477, 47);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(185, 27);
            this.txtNombres.TabIndex = 5;
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.AllowUserToDeleteRows = false;
            this.dgvVacunas.AllowUserToResizeColumns = false;
            this.dgvVacunas.AllowUserToResizeRows = false;
            this.dgvVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunas.Location = new System.Drawing.Point(64, 116);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.RowHeadersVisible = false;
            this.dgvVacunas.RowHeadersWidth = 51;
            this.dgvVacunas.RowTemplate.Height = 29;
            this.dgvVacunas.Size = new System.Drawing.Size(619, 235);
            this.dgvVacunas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // lbRecorrer
            // 
            this.lbRecorrer.AutoSize = true;
            this.lbRecorrer.Location = new System.Drawing.Point(66, 92);
            this.lbRecorrer.Name = "lbRecorrer";
            this.lbRecorrer.Size = new System.Drawing.Size(107, 20);
            this.lbRecorrer.TabIndex = 10;
            this.lbRecorrer.Text = "Historia clinica";
            // 
            // lbCantDni
            // 
            this.lbCantDni.AutoSize = true;
            this.lbCantDni.Location = new System.Drawing.Point(131, 19);
            this.lbCantDni.Name = "lbCantDni";
            this.lbCantDni.Size = new System.Drawing.Size(12, 20);
            this.lbCantDni.TabIndex = 11;
            this.lbCantDni.Text = ":";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // lbInformes
            // 
            this.lbInformes.AutoSize = true;
            this.lbInformes.Location = new System.Drawing.Point(131, 19);
            this.lbInformes.Name = "lbInformes";
            this.lbInformes.Size = new System.Drawing.Size(15, 20);
            this.lbInformes.TabIndex = 12;
            this.lbInformes.Text = "_";
            // 
            // FormNuevaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lbInformes);
            this.Controls.Add(this.lbCantDni);
            this.Controls.Add(this.lbRecorrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVacunas);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.btnVolverForm1);
            this.Controls.Add(this.btnAplicarDosis);
            this.Controls.Add(this.btnCargar);
            this.Name = "FormNuevaPersona";
            this.Text = "Agregar pacientes";
            this.Load += new System.EventHandler(this.FormNuevaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnVolverForm1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbRecorrer;
        private Label lbCantDni;
        private ErrorProvider EP;
        public DataGridView dgvVacunas;
        public TextBox txtNumDoc;
        public TextBox txtApellido;
        public TextBox txtNombres;
        private Label lbInformes;
        public Button btnAplicarDosis;
        public Button btnCargar;
    }
}