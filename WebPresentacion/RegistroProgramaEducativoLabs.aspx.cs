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
    public partial class RegistroProgramaEducativoLabs : System.Web.UI.Page
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

            if (txtProgramaEd.Text != "" && txtExtra.Text != "" && dropProgramaED.Text != "")
            {
                ProgramaEducativo temp = new ProgramaEducativo()
                {
                    ProgramaEd = txtProgramaEd.Text,
                    F_Carrera = Convert.ToInt16(dropProgramaED.SelectedValue),
                    Extra = txtExtra.Text
                };

                string mensaje1 = "";
                object1.InsertarProgramaED (temp, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Insertado!','" + mensaje1 + "','success')", true);
                string mensaje2 = "";

                ProgramaEducativo temp1 = new ProgramaEducativo()
                {
                    F_Carrera = Convert.ToInt16(dropProgramaED.SelectedValue),
                };

                GridView1.DataSource = object1.DatosEnGridProgramaED(temp1, ref mensaje2);
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProgramaEd.Text = GridView1.SelectedRow.Cells[1].Text;

        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (dropProgramaEdActualizar.Text != "")
            {
                ProgramaEducativo temp = new ProgramaEducativo()
                {
                    ProgramaEd = txtProgramaEd.Text,
                    F_Carrera = Convert.ToInt16(dropProgramaEdActualizar.SelectedValue),
                    Extra = txtExtraA.Text
                };

                string mensaje1 = "";
                object1.ActualizarProgramaED(temp, lbProgramaEd.Text, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "SweetAlert('¡Actualizado!','Registro actualizado','success')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ProgramaEducativo temp = new ProgramaEducativo()
            {
               ProgramaEd = txtProgramaEd.Text
            };

            string mensaje1 = "";

            object1.EliminarProgramaEducativo(temp, ref mensaje1);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Eliminado!','Se ha elimando correctamente','success')", true);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            List<Carrera> listaA = null;
            string m = "";
            listaA = object1.DevuelveCarreraEnID(ref m);

            if (listaA != null)
            {
                dropProgramaED.Items.Clear();
                foreach (Carrera a in listaA)
                {
                    dropProgramaED.Items.Add(new ListItem(a.NombreCarrera, a.Id_Carrera.ToString()));
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            List<Carrera> listaA = null;
            string m = "";
            listaA = object1.DevuelveCarreraEnID(ref m);

            if (listaA != null)
            {
                dropProgramaEdActualizar.Items.Clear();
                foreach (Carrera a in listaA)
                {
                    dropProgramaEdActualizar.Items.Add(new ListItem(a.NombreCarrera, a.Id_Carrera.ToString()));
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroCuatrimestre.aspx");
        }
    }
}