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
    public partial class RegistroMateria : System.Web.UI.Page
    {
        LogicaNegociosMateria object3 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                object3 = new LogicaNegociosMateria();
                Session["object3"] = object3;

            }
            else
            {
                object3 = (LogicaNegociosMateria)Session["object3"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text != "" && txtHora.Text != "" && txtExtra.Text != "")
            {
                Materia temp = new Materia()
                {
                    NombeMateria = txtMateria.Text,
                    HorasSemana = Convert.ToByte(txtHora.Text),
                    Extra = txtExtra.Text
                };


                string mensaje1 = "";
                object3.InsertarMateria(temp, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Insertado!','" + mensaje1 + "','success')", true);

                Materia temp1 = new Materia()
                {
                    NombeMateria = txtMateria.Text
                };

                string mensaje2 = "";

                GridView1.DataSource = object3.DatosEnGridCuati(temp1, ref mensaje2);
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text != "" && txtHora.Text != "" && txtExtra.Text != "")
            {
                Materia temp = new Materia()
                {
                    NombeMateria = txtMateriaA.Text,
                    HorasSemana = Convert.ToByte(txtHorasA.Text),
                    Extra = txtExtraA.Text

                };

                string mensaje1 = "";
                object3.ActualizarMateria(temp, lbMateria.Text, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "SweetAlert('¡Actualizado!','Registro actualizado','success')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Materia temp = new Materia()
            {
                NombeMateria = txtMateria.Text
            };

            string mensaje1 = "";

            object3.EliminarMateria(temp, ref mensaje1);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Eliminado!','Se ha elimando correctamente','success')", true);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMateria.Text = GridView1.SelectedRow.Cells[1].Text;

        }
    }
}