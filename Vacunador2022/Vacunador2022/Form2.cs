using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunador2022.ClasesFijas;

namespace Vacunador2022
{
    public partial class FormNuevaPersona : Form
    {
        public List<ClasesFijas.DNI> listaDni;
        public DNI PersonaDelForm;
        public Valida valida = new Valida();
        claseAJson Clase2 = new claseAJson();
        public FormNuevaPersona()
        {
            InitializeComponent();
        }

        private void FormNuevaPersona_Load(object sender, EventArgs e)
        {
            listaDni = Clase2.JsonAPersona();
            btnCargar.Enabled = false;
            //lbInformes.Enabled = false;
            btnAplicarDosis.Enabled = true;
            if (!valida.ValidaDni(txtNumDoc.Text)) btnCargar.Enabled = true;
            txtApellido.Focus();
        }
        private bool validacion_Principal()
        {
            bool validado = true;
            validado &= valida.validacionTB(txtNumDoc);
            validado &= valida.validacionTB(txtApellido);
            validado &= valida.validacionTB(txtNombres);
            return validado;
        }

        public void btnCargar_Click(object sender, EventArgs e)
        {

            if (!validacion_Principal()) return;

            string _dni = txtNumDoc.Text;
            string _apellido = txtApellido.Text;
            string _nombres = txtNombres.Text;
            DateTime _dosis = DateTime.Now.Date;
            string _marca = "Fecha Alta --> ";
            Vacuna _nuevaDosis = new Vacuna(_marca, _dosis);
            List<Vacuna> DatosDosis = new List<Vacuna>();
            DatosDosis.Add(_nuevaDosis);
            PersonaDelForm = new DNI(_dni, _apellido, _nombres, DatosDosis);
            listaDni.Add(PersonaDelForm);
            Clase2.PersonaAJson(listaDni);
            MessageBox.Show($"El Dni {_dni} fue agregado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                EP.SetError(txtNumDoc, "Solo admite numeros");
            }
            else EP.SetError(txtNumDoc, "");
        }

        private void txtNumDoc_Leave(object sender, EventArgs e)
        {
            if (!valida.ValidaDni(txtNumDoc.Text))
            {
                EP.SetError(txtNumDoc, "");
                btnCargar.Enabled = true;
                lbInformes.Text = "";
                lbInformes.Enabled = false;
            }
            else
            {
                btnCargar.Enabled = false;
                EP.SetError(txtNumDoc, "El Numero ya existe");
                lbInformes.Enabled = true;
                lbInformes.Text = "El Numero ya existe!";
                lbRecorrer.Text = Clase2.getDni(txtNumDoc.Text).Dni;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolverForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicarDosis_Click(object sender, EventArgs e)
        {
            NuevaDosis nuevaDosis = new NuevaDosis();
            nuevaDosis.Text += txtNumDoc.Text;
            nuevaDosis.lbAp.Text = txtApellido.Text;
            nuevaDosis.lbNom.Text = txtNombres.Text;
            nuevaDosis.gbDni.Text = txtNumDoc.Text;
            this.Close();
            nuevaDosis.ShowDialog();
        }
    }
}