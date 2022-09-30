namespace Vacunador2022
{
    partial class DosisAplicadas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvDosis = new System.Windows.Forms.DataGridView();
            this.lbDosis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 22);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(32, 39);
            this.dtp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(176, 23);
            this.dtp1.TabIndex = 1;
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(235, 39);
            this.dtp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(163, 23);
            this.dtp2.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(571, 40);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 22);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvDosis
            // 
            this.dgvDosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDosis.Location = new System.Drawing.Point(36, 86);
            this.dgvDosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDosis.Name = "dgvDosis";
            this.dgvDosis.RowHeadersWidth = 51;
            this.dgvDosis.RowTemplate.Height = 29;
            this.dgvDosis.Size = new System.Drawing.Size(600, 229);
            this.dgvDosis.TabIndex = 4;
            // 
            // lbDosis
            // 
            this.lbDosis.AutoSize = true;
            this.lbDosis.Location = new System.Drawing.Point(38, 9);
            this.lbDosis.Name = "lbDosis";
            this.lbDosis.Size = new System.Drawing.Size(10, 15);
            this.lbDosis.TabIndex = 5;
            this.lbDosis.Text = ".";
            // 
            // DosisAplicadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.lbDosis);
            this.Controls.Add(this.dgvDosis);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DosisAplicadas";
            this.Text = "DosisAplicadas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private DateTimePicker dtp1;
        private DateTimePicker dtp2;
        private Button btnVolver;
        private DataGridView dgvDosis;
        private Label lbDosis;
    }
}