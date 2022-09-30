using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunador2022.ClasesFijas
{
    public class Vacuna
    {
        public string Marca { get; set; }
        public DateTime Dosis { get; set; }
        public Vacuna() { }
        public Vacuna(string _marca, DateTime _dosis)
        {
            this.Dosis = _dosis;
            this.Marca = _marca;
        }
        public DateTime getDosis() => this.Dosis;
        public void setDosis(DateTime _dosis) => this.Dosis = _dosis;
        public string getMarca() => Marca;
        public void setMarca(string _marca) => this.Marca = _marca;
    }
}
