using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_Parcial2
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Grabar(List<Animal> animales)
        {
            string json = JsonConvert.SerializeObject(animales);
            string archive = Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archive, json);
        }

        private List<Animal> Leer()
        {
            List<Animal> lista = new List<Animal>();
            string archivo = Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Animal>>(json);

            return lista;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Animal> animales = Leer();
            Animal animal = animales.Find(u => u.Nombre == txtBuscar.Text);
            if (animal != null)
            {
                Response.Write("<script>alert { 'Animal encontrado' } </script");
                lblNombreAnimal.Text = animal.Nombre;
                btnDelete.Enabled = true;
            }
            else
            {
                Response.Write("<script>alert { 'Animal no encontrado' } </script");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

           

            List<Animal> animales = Leer();
           
            Animal animal = animales.Find(u => u.Nombre == lblNombreAnimal.Text);
            lblNombreAnimal.Text = animal.Nombre;

            animales.Remove(animal);
            Response.Write("<script>alert('Animal eliminado!')</script>");

            Grabar(animales);
        }
    }
}