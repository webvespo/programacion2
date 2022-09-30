using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunador2022.ClasesFijas
{
    public class Valida
    {
        ErrorProvider EP = new ErrorProvider();
        public bool ValidaDni(string _dni)
        {
            List<DNI> listaDni;
            claseAJson Clase2 = new claseAJson();
            listaDni = Clase2.JsonAPersona();
            if (listaDni.Any(x => x.getDni() == _dni)) return true;
            return false;
        }
        public bool validacionCB(ComboBox InB)
        {
            if (InB.Text == null || InB.Text.Length == 0)
            {
                EP.SetError(InB, "Debe seleccionar una opcion");
                return false;
            }
            EP.SetError(InB, "");
            return true;
        }
       
        public bool validacionTB(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                switch (tb.Name)
                {
                    case "txtApellido":
                        EP.SetError(tb, "El campo Apellido es Obligatorio");
                        break;
                    case "txtNombres":
                        EP.SetError(tb, "El campo Nombres es Obligatorio");
                        break;
                    default:
                        EP.SetError(tb, "El campo es obligatorio");
                        break;
                }
                return false;
            }
            EP.SetError(tb, "");
            return true;
        }
    }


}
