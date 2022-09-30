using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacunador2022.ClasesFijas;

namespace Vacunador2022
{
    public partial class Stock : Form
    {
        public stockVacunas stockVacunas = new stockVacunas();
        public Stock()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            dgvVacunas.DataSource = stockVacunas.getListaVacunas();
        }
    }
}
