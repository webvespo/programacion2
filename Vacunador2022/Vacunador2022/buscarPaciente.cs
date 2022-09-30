using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunador2022.ClasesFijas;

namespace Vacunador2022
{
    public partial class buscar : Form
    {
        public List<DNI> listaDni;
        public DNI PersonaDelForm;
        claseAJson traeJson = new claseAJson();

        public buscar()
        {
            InitializeComponent();
        }



        private void buscar_Load(object sender, EventArgs e)
        {
            try
            {
                listaDni = traeJson.JsonAPersona();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
            btnAgregarDni.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBusca.Text;
            if (listaDni.Any(x => x.getDni() == dni))
            {
                DNI unica = listaDni.Single(x => x.getDni() == dni);
                FormNuevaPersona form2 = new FormNuevaPersona();
                this.Close();
                form2.btnAplicarDosis.Enabled = true;
                unica.cargaDeNuevoPersona(unica, form2);
            }
            else
            {
                lbExiste.Text = "DNI no encontrado: desea agregarlo?";
                btnAgregarDni.Enabled = true;
                btnAgregarDni.Focus();
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnBuscar_Click(sender, e);
            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)(Keys.Enter)))
            {
                EP.SetError(txtBusca, "Solo admite numeros");
            }
            else EP.SetError(txtBusca, "");
            if (e.KeyChar == (char)(Keys.Back))
            {
                lbExiste.Text = "";
                btnAgregarDni.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregarDni_Click(object sender, EventArgs e)
        {
            FormNuevaPersona form2 = new FormNuevaPersona();
            form2.txtNumDoc.Text = txtBusca.Text;
            form2.btnCargar_Click(sender, e);
            form2.ShowDialog();
        }
    }
}
