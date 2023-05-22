using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Parcial2
{
    public class Animal
    {
        string nombre;
        string especie;
        string alimentacion;
        string tiempo_vida;

        List<Ave> aves;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Alimentacion { get => alimentacion; set => alimentacion = value; }
        public string Tiempo_vida { get => tiempo_vida; set => tiempo_vida = value; }
        public List<Ave> Aves { get => aves; set => aves = value; }

        public Animal()
        {
            Aves = new List<Ave>();
        }
    }
}