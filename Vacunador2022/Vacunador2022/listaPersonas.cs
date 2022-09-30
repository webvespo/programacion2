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
    public partial class listaPersonas : Form
    {
        public List<DNI> listaDni;

        claseAJson Clase2 = new claseAJson();
        public listaPersonas()
        {
            InitializeComponent();
            listaDni = Clase2.JsonAPersona();
            dgvForm2.DataSource = null;
            dgvForm2.DataSource = listaDni;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
