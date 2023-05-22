using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Parcial2
{
    public class Serpiente:Animal
    {
        string venenosa;
        int longitud;

        public string Venenosa { get => venenosa; set => venenosa = value; }
        public int Longitud { get => longitud; set => longitud = value; }
    }
}