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
    public partial class RegistroCuatrimestre : System.Web.UI.Page
    {
        LogicaNegociosCuatriGrupo object2 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                object2 = new LogicaNegociosCuatriGrupo();
                Session["object2"] = object2;

            }
            else
            {
                object2 = (LogicaNegociosCuatriGrupo)Session["object2"];
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtPeriodo.Text != "" && txtAnio.Text != "" && CLInicio.SelectedDate.ToString() != "" && CLFin.SelectedDate.ToString() != "" && txtExtra.Text != "")
            {
                Cuatrimestre temp = new Cuatrimestre()
                {
                    Periodo = txtPeriodo.Text,
                    Anio = Convert.ToInt16(txtAnio.Text),
                    Inicio = CLInicio.SelectedDate,
                    Fin = CLFin.SelectedDate,
                    Extra = txtExtra.Text
                };


                string mensaje1 = "";
                object2.InsertarCuatrimestre(temp, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Insertado!','" + mensaje1 + "','success')", true);
                string mensaje2 = "";


                Cuatrimestre temp1 = new Cuatrimestre()
                {
                    Periodo = txtPeriodo.Text
                   
                };

                GridView1.DataSource = object2.DatosEnGridCuati(temp1, ref mensaje2);
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Cuatrimestre temp = new Cuatrimestre()
            {
                Periodo = txtPeriodo.Text
            };

            string mensaje1 = "";

            object2.EliminarCuatri(temp, ref mensaje1);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Eliminado!','Se ha elimando correctamente','success')", true);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtPeriodo.Text != "" && txtAnio.Text != "" && CLInicio.SelectedDate.ToString() != "" && CLFin.SelectedDate.ToString() != "" && txtExtra.Text != "")
            {
                Cuatrimestre temp = new Cuatrimestre()
                {
                    Periodo = txtPeriodoA.Text,
                    Anio = Convert.ToInt16(txtAñoA.Text),
                    Inicio = CLInicioA.SelectedDate,
                    Fin = CLFinA.SelectedDate,
                    Extra = txtExtraA.Text
                };

                string mensaje1 = "";
                object2.ActualizarCuatri(temp, lbCuatri.Text, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "SweetAlert('¡Actualizado!','Registro actualizado','success')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCuatri.Text = GridView1.SelectedRow.Cells[1].Text;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroGrupoCuatrimestre.aspx");
        }
    }
}