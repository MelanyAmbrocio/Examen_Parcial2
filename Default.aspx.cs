using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_Parcial2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();

           
            List<Animal> animales = new List<Animal>();
            
            animales = archivo.Leer();

            
            if (animales == null)
                animales = new List<Animal>();

           
            Animal animalExiste = animales.Find(u => u.Nombre == txtNombre.Text);

           
            if (animalExiste == null)
            {
                
                Animal animalNuevo = new Animal();


                animalNuevo.Nombre = txtNombre.Text;
                animalNuevo.Especie = txtEspecie.Text;
                animalNuevo.Alimentacion = txtAlimentacion.Text;
                animalNuevo.Tiempo_vida = txtVida.Text;

                Ave aveNueva = new Ave();

                aveNueva.Nombre = txtNombre.Text;
                aveNueva.Vuela = txtVolador.Text;
                aveNueva.Incubación = Convert.ToInt32(txtIncubacion.Text);
               
                animalNuevo.Aves.Add(aveNueva);
                animales.Add(animalNuevo);
            }
            else 
            {
                
                Ave aveExiste = animalExiste.Aves.Find(a => a.Nombre == txtNombre.Text);

               
                if (aveExiste == null)
                {
                    Ave aveNueva = new Ave();
                    aveNueva.Nombre = txtNombre.Text;
                    aveNueva.Vuela = txtVolador.Text;
                    aveNueva.Incubación = Convert.ToInt32(txtIncubacion.Text);

                   

                    animalExiste.Aves.Add(aveNueva);

                }
            }
          
            archivo.Grabar(animales);

        }
    }
}