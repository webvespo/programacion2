using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunador2022.ClasesFijas
{
    internal class AplicadasDni
    {
        public string Dni { get; set; }
        public string Apellido { get; set; }
        public DateTime FecApli { get; set; }
        public string Marca { get; set; }
        public AplicadasDni()
        {

        }
        public AplicadasDni(string _dni, string _ape, DateTime _fech, string _marca)
        {
            this.Dni = _dni;
            this.Apellido = _ape;
            this.FecApli = _fech;
            this.Marca = _marca;
        }
        public void setDni(string _dni) => this.Dni = _dni;
        public string getDni() => this.Dni;
        public void setApellido(string _ape) => this.Apellido = _ape;
        public string getApellido() => this.Apellido;
        public void setFecha(DateTime _fech) => this.FecApli = _fech;
        public DateTime getFEcha() => this.FecApli;
        public void setMarca(string _marca) => this.Marca = _marca;
        public string getMArca() => this.Marca;
    }
}
