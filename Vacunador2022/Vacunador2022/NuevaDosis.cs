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
    public partial class NuevaDosis : Form
    {
        public List<DNI> listaDni;

        public DNI PersonaDelForm;

        public claseAJson traerJson = new claseAJson();

        public stockVacunas stockVacunas = new stockVacunas();
        public NuevaDosis()
        {
            listaDni = traerJson.JsonAPersona();
            InitializeComponent();
        }

        private void NuevaDosis_Load(object sender, EventArgs e)
        {
            cargaVacunas();
        }
        public void cargaVacunas()
        {
            dynamic arrayVacunas = stockVacunas.getListaVacunas();
            foreach (var item in arrayVacunas)
            {
                cbVacunas.Items.Add(item.Name);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = gbDni.Text;
            if (listaDni.Any(x => x.getDni() == dni))
            {
                PersonaDelForm = listaDni.Single(x => x.getDni() == dni);
                listaDni.Remove(PersonaDelForm);
                string _marca = cbVacunas.Text;
                string _idVacuna = cbVacunas.Text;
                stockVacunas.manejarStock(_idVacuna);
                DateTime _fechaDosis = DateTime.Now.Date;
                Vacuna nuevaVacuna = new Vacuna(_marca, _fechaDosis);
                PersonaDelForm.Vacuna.Add(nuevaVacuna);
                listaDni.Add(PersonaDelForm);
                traerJson.PersonaAJson(listaDni);
                this.Close();
                FormNuevaPersona formNuevaPersona = new FormNuevaPersona();
                formNuevaPersona.btnAplicarDosis.Enabled = false;
                PersonaDelForm.cargaDeNuevoPersona(PersonaDelForm, formNuevaPersona);
            }
        }

        private void cbVacunas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDosis.Text = cbVacunas.Text;
            string _name = cbVacunas.Text;
            try
            {
                lbCantidad.Text = stockVacunas.getStock(_name).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }
    }
}
