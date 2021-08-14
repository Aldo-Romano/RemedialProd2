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
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }
        }
    }
}