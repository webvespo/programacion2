namespace Vacunador2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Desea salir?","ADVERTENCIA", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
                //this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (FormNuevaPersona form2 = new FormNuevaPersona())
                form2.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(buscar bPacientes = new buscar())
                bPacientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock formStock = new Stock();
            formStock.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosisAplicadas dosisAplicadas = new DosisAplicadas();
            dosisAplicadas.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBuscar.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (listaPersonas personas = new listaPersonas())
                personas.ShowDialog();
        }
    }
}