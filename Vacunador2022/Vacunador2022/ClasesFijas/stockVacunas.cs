using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vacunador2022.ClasesFijas
{
    public class stockVacunas
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Aplic { get; set; }
        public stockVacunas()
        {

        }
        public stockVacunas(string _id, string _name, int _stock, int _aplic)
        {
            Id = _id;
            Name = _name;
            Stock = _stock;
            Aplic = _aplic;
        }
        public string getId() => this.Id;
        public void setId(string _id) => Id = _id;
        public string getName() => this.Name;
        public void setName(string _name) => Name = _name;
        public int getStock() => Stock;
        public void setStock(int _stock) => Stock = _stock;
        public int getAplic() => Aplic;
        public void setAplic(int _newAplic) => Aplic = _newAplic;
        public void manejarStock(string _id)
        {
            int _nuevoStock = 0;
            int _nuevoAplic = 0;
            try
            {
                List<stockVacunas> listaVacuna = getListaVacunas();
                stockVacunas vacunaSeleccionada = listaVacuna.Single(x => x.getName() == _id);
                _nuevoStock = vacunaSeleccionada.getStock();
                _nuevoStock--;
                _nuevoAplic = vacunaSeleccionada.getAplic();
                _nuevoAplic++;
                listaVacuna.Remove(vacunaSeleccionada);
                vacunaSeleccionada.setStock(_nuevoStock);
                vacunaSeleccionada.setAplic(_nuevoAplic);
                listaVacuna.Add(vacunaSeleccionada);
                File.WriteAllText(getJsonName(), JsonConvert.SerializeObject(listaVacuna, Newtonsoft.Json.Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public string getJsonName()
        {
            string json = @"FileJson\stockVacunas.json";
            return json;
        }
        public List<stockVacunas> getListaVacunas()
        {
            try
            {
                string vacunasDeJson = File.ReadAllText(getJsonName());
                List<stockVacunas> vacuna = JsonConvert.DeserializeObject<List<stockVacunas>>(vacunasDeJson);
                return vacuna;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public stockVacunas getVacuna(string _id)
        {
            List<stockVacunas> listaVacuna = getListaVacunas();
            stockVacunas vacuna = listaVacuna.Single(x => x.getId() == _id);
            return vacuna;
        }
        public List<string> getNombres()
        {
            List<stockVacunas> listaVacuna = getListaVacunas();
            List<string> nombres = new List<string>();
            foreach (var item in listaVacuna)
            {
                string nombre = item.getName();
                nombres.Add(nombre);
            }
            return nombres;
        }
        public int getStock(string _name)
        {
            int _nuevoStock = 0;
            try
            {
                List<stockVacunas> vacuna = getListaVacunas();
                stockVacunas stock = vacuna.Single(x => x.getName() == _name);
                _nuevoStock = stock.getStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return _nuevoStock;
        }
    }


}
