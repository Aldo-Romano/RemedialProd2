using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassCapaLogicaNegocio;
using ClassCapaEntidades;

namespace WebPresentacion
{
    public partial class RegistroCarrera : System.Web.UI.Page
    {

         LogicaNegociosCarrera object1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                object1 = new LogicaNegociosCarrera();
                Session["object1"] = object1;

            }
            else
            {
                object1 = (LogicaNegociosCarrera)Session["object1"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (dlCarrera.Text != "" )
            {
                Carrera temp = new Carrera()
                {
                    NombreCarrera = dlCarrera.SelectedValue
                };

                string ms = "";
                object1.InsertarCarrera(temp, ref ms);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "msbox('¡Insertado!','" + ms + "','success')", true);
                string a = "";

                GridView1.DataSource = object1.DatosEnGridCarrera(dlCarrera.SelectedValue ,ref a);
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCarrera.Text = GridView1.SelectedRow.Cells[1].Text;


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Carrera temp = new Carrera()
            {
                NombreCarrera = lbCarrera.Text
            };

            string a = "";

             object1.EliminarCarrera(temp, ref a);        

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (dlCarrera.Text != "")
            {
                Carrera temp = new Carrera()
                {
                    NombreCarrera = dlCarrera1.SelectedValue
                };

                string ms = "";
                object1.ActualizarCarrera(temp,lbCarrera.Text, ref ms);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "msbox('¡Insertado!','" + ms + "','success')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }
        }
    }
}