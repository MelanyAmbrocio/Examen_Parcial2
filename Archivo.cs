using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Examen_Parcial2
{
    public class Archivo
    {
        public void Grabar(List<Animal> animales)
        {
            string json = JsonConvert.SerializeObject(animales);
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Animal> Leer()
        {
            List<Animal> lista = new List<Animal>();
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            if (json != null)
            {
                lista = JsonConvert.DeserializeObject<List<Animal>>(json);
            }


            return lista;


        }
    }
}