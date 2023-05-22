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
        int tiempo_vida;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Alimentacion { get => alimentacion; set => alimentacion = value; }
        public int Tiempo_vida { get => tiempo_vida; set => tiempo_vida = value; }
    }
}