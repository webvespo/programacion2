using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunador2022.ClasesFijas
{
    public class DNI
    {
        public string Dni { get; set; }
        public string APELLIDO { get; set; }
        public string NOMBRES { get; set; }
        public List<Vacuna> Vacuna { get; set; }
        public DNI() { }
        public DNI(
            string _dni,
            string _apellido,
            string _nombres,
            List<Vacuna> _dosis
            )
        {
            this.Dni = _dni;
            this.APELLIDO = _apellido;
            this.NOMBRES = _nombres;
            this.Vacuna = _dosis;
        }

        public string getDni()
        {
            return this.Dni;
        }
        public void setDni(string _dni)
        {
            this.Dni = _dni;
        }
        public string getApellido() => APELLIDO;
        public void setApellido(string _ape)
        {
            APELLIDO = _ape;
        }
        public string getNombres() => this.NOMBRES;
        public void setNombres(string _nombres)
        {
            NOMBRES = _nombres;
        }
        public List<Vacuna> GetVacuna() => this.Vacuna;


        public void cargaDeNuevoPersona(DNI macana, FormNuevaPersona formNuevaPersona)
        {
            formNuevaPersona.dgvVacunas.DataSource = null;
            formNuevaPersona.dgvVacunas.DataSource = macana.Vacuna;
            formNuevaPersona.txtNumDoc.Text = macana.getDni(); ;
            formNuevaPersona.txtApellido.Text = macana.getApellido();
            formNuevaPersona.txtNombres.Text = macana.getNombres();
            formNuevaPersona.ShowDialog();
        }
    }


}
