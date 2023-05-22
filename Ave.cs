using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Parcial2
{
    public class Ave:Animal
    {
        string vuela;
        int incubación;

        public string Vuela { get => vuela; set => vuela = value; }
        public int Incubación { get => incubación; set => incubación = value; }
    }
}