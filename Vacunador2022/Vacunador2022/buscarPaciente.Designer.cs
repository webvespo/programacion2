namespace Vacunador2022
{
    partial class buscar
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarDni = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lbExiste = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(291, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 22);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarDni
            // 
            this.btnAgregarDni.Location = new System.Drawing.Point(409, 16);
            this.btnAgregarDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarDni.Name = "btnAgregarDni";
            this.btnAgregarDni.Size = new System.Drawing.Size(82, 22);
            this.btnAgregarDni.TabIndex = 2;
            this.btnAgregarDni.Text = "Agregar";
            this.btnAgregarDni.UseVisualStyleBackColor = true;
            this.btnAgregarDni.Click += new System.EventHandler(this.btnAgregarDni_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(88, 18);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(168, 23);
            this.txtBusca.TabIndex = 3;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // lbExiste
            // 
            this.lbExiste.AutoSize = true;
            this.lbExiste.Location = new System.Drawing.Point(89, 49);
            this.lbExiste.Name = "lbExiste";
            this.lbExiste.Size = new System.Drawing.Size(10, 15);
            this.lbExiste.TabIndex = 4;
            this.lbExiste.Text = ".";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 71);
            this.Controls.Add(this.lbExiste);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnAgregarDni);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "buscar";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button button2;
        private Button btnAgregarDni;
        private TextBox txtBusca;
        private Label lbExiste;
        private ErrorProvider EP;
    }
}