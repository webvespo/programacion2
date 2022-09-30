using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Vacunador2022.ClasesFijas
{
    public class claseAJson : Form1
    {
        string json = @"FileJson\personas.json";
        public void PersonaAJson(List<DNI> pepe)
        {
            string fileJson = json;
            File.WriteAllText(json, JsonConvert.SerializeObject(pepe, Formatting.Indented));
        }

        public List<DNI> JsonAPersona()
        {
            string fileJson = File.ReadAllText(@"FileJson\personas.json");
            List<DNI> claseDNI = JsonConvert.DeserializeObject<List<DNI>>(fileJson);
            return claseDNI;
        }

        public DNI getDni(string _dni)
        {
            List<DNI> listaDni;
            claseAJson Clase2 = new claseAJson();
            listaDni = Clase2.JsonAPersona();
            DNI persona = listaDni.Single(x => x.Dni == _dni);
            return persona;
        }
        public bool getDni2(string _dni)
        {
            try
            {
                List<DNI> listaDni;
                claseAJson Clase2 = new claseAJson();
                listaDni = Clase2.JsonAPersona();
                DNI persona = listaDni.Single(x => x.Dni == _dni);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return true;
        }
    }
}
