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
    public partial class DosisAplicadas : Form
    {
        List<DNI> listaDni;
        claseAJson traeJson = new claseAJson();
        stockVacunas stockVacunas = new stockVacunas();
        public DosisAplicadas()
        {
            listaDni = traeJson.JsonAPersona();
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> arrayVacunas = stockVacunas.getNombres();
            dgvDosis.DataSource = buscaFechas(dtp1, dtp2);
        }
        private List<AplicadasDni> buscaFechas(DateTimePicker dtp1, DateTimePicker dtp2)
        {
            listaDni = traeJson.JsonAPersona();
            List<AplicadasDni> ap = new List<AplicadasDni>();
            int cantDosis = 0;
            foreach (var item in listaDni)
            {
                foreach (var dtVacuna in item.GetVacuna())
                {
                    if (dtVacuna.getDosis().Date >= dtp1.Value.Date && dtVacuna.getDosis().Date <= dtp2.Value.Date && dtVacuna.getMarca() != "Fecha Alta --> ")
                    {
                        cantDosis += 1;
                        AplicadasDni nuevoAplique = new AplicadasDni(item.getDni(), item.getApellido(), dtVacuna.getDosis(), dtVacuna.getMarca());
                        ap.Add(nuevoAplique);
                    }
                }
            }
            lbDosis.Text = "Cantidad de dosis aplicadas: " + cantDosis.ToString();
            return ap;
        }

    }
}
