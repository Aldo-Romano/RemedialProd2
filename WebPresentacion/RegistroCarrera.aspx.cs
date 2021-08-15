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
            if (dropCarrera.Text != "" )
            {
                Carrera temp = new Carrera()
                {
                    NombreCarrera = dropCarrera.SelectedValue
                };

                string mensaje1 = "";
                object1.InsertarCarrera(temp, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Insertado!','" + mensaje1 + "','success')", true);
                string mensaje2 = "";

                GridView1.DataSource = object1.DatosEnGridCarrera(dropCarrera.SelectedValue ,ref mensaje2);
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
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

            string mensaje1 = "";

             object1.EliminarCarrera(temp, ref mensaje1);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Eliminado!','Se ha elimando correctamente','success')", true);
            

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (dropCarrera1.Text != "")
            {
                Carrera temp = new Carrera()
                {
                    NombreCarrera = dropCarrera1.SelectedValue
                };

                string mensaje1 = "";
                object1.ActualizarCarrera(temp,lbCarrera.Text, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "SweetAlert('¡Actualizado!','Registro actualizado','success')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }
    }
}