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
    public partial class RegistroGrupoCuatrimestre : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (dropProgramaEd.SelectedValue.ToString() != "" && dropGrupo.SelectedValue.ToString() != "" && dropCuatri.SelectedValue.ToString() != "" && txtTurno.Text != "" && txtModalidad.Text != "" && txtExtra.Text != "")
            {
                GrupoCuatrimestre temp = new GrupoCuatrimestre()
                {
                   F_ProgEd = Convert.ToInt16(dropProgramaEd.SelectedValue),
                   F_Grupo = Convert.ToInt16(dropGrupo.SelectedValue),
                   F_Cuatri = Convert.ToInt16(dropCuatri.SelectedValue),
                   Turno = txtTurno.Text,
                   Modalidad = txtModalidad.Text,
                   Extra = txtExtra.Text
                };


                string mensaje1 = "";
                object2.InsertarGrupoCuatrimestre(temp, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Insertado!','" + mensaje1 + "','success')", true);

               
                string mensaje2 = "";

                GridView1.DataSource = object2.DatosEnGridGrupoCuati(Convert.ToInt16(dropGrupo.SelectedValue), ref mensaje2);
                GridView1.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (dropProgramaEd.SelectedValue.ToString() != "" && dropGrupo.SelectedValue.ToString() != "" && dropCuatri.SelectedValue.ToString() != "" && txtTurno.Text != "" && txtModalidad.Text != "" && txtExtra.Text != "")
            {
                GrupoCuatrimestre temp = new GrupoCuatrimestre()
                {
                    F_ProgEd = Convert.ToInt16(dropProgramaEDA.SelectedValue),
                    F_Grupo = Convert.ToInt16(dropGrupoA.SelectedValue),
                    F_Cuatri = Convert.ToInt16(dropCuatriA.SelectedValue),
                    Turno = txtTurnoA.Text,
                    Modalidad = txtModalidadA.Text,
                    Extra = txtExtraA.Text
                };


                string mensaje1 = "";
                object2.ActualizarGrupoCuatri(temp, lbMateria.Text, ref mensaje1);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "SweetAlert('¡Actualizado!','Registro actualizado','success')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "SweetAlert('¡Error!','Inserte todos los datos','error')", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GrupoCuatrimestre temp = new GrupoCuatrimestre()
            {
                F_Grupo = Convert.ToInt16(dropGrupo)
            };

            string mensaje1 = "";

            object2.EliminarGrupoCuatri(temp, ref mensaje1);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje1", "SweetAlert('¡Eliminado!','Se ha elimando correctamente','success')", true);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMateria.Text = GridView1.SelectedRow.Cells[1].Text;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProgramasEducativosenCarreras.aspx");
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {

            string m = "";

            List<Cuatrimestre> listaCu = null;
            listaCu = object2.ListaCuatri(ref m);

            if (listaCu != null)
            {
                dropCuatri.Items.Clear();
                foreach (Cuatrimestre a in listaCu)
                {
                    dropCuatri.Items.Add(new ListItem(a.Periodo, a.Id_Cuatrimestres.ToString()));
                }
            }

            List<ProgramaEducativo> listaP = null;
            listaP = object2.ListaProgramaEducativo(ref m);

            if (listaCu != null)
            {
                dropProgramaEd.Items.Clear();
                foreach (ProgramaEducativo a in listaP)
                {
                    dropProgramaEd.Items.Add(new ListItem(a.ProgramaEd, a.Id_Pe.ToString()));
                }
            }

            List<Grupo> listaG = null;
            listaG = object2.ListaGrupo(ref m);

            if (listaCu != null)
            {
                dropGrupo.Items.Clear();
                foreach (Grupo a in listaG)
                {
                    dropGrupo.Items.Add(new ListItem(a.Grado.ToString(), a.Id_Grupo.ToString()));
                }
            }
        }
    }
}