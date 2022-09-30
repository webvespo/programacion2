namespace Vacunador2022
{
    partial class listaPersonas
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
            this.dgvForm2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForm2
            // 
            this.dgvForm2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm2.Location = new System.Drawing.Point(18, 23);
            this.dgvForm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvForm2.Name = "dgvForm2";
            this.dgvForm2.RowHeadersWidth = 51;
            this.dgvForm2.RowTemplate.Height = 29;
            this.dgvForm2.Size = new System.Drawing.Size(672, 225);
            this.dgvForm2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvForm2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "listaPersonas";
            this.Text = "listaPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvForm2;
        private Button button1;
    }
}