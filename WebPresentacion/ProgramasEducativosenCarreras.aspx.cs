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
    public partial class ProgramasEducativosenCarreras : System.Web.UI.Page
    {
        LogicaNegociosCarrera object1 = null;
        LogicaNegociosCuatriGrupo object2 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                object1 = new LogicaNegociosCarrera();
                Session["object1"] = object1;
                object2 = new LogicaNegociosCuatriGrupo();
                Session["object2"] = object2;


            }
            else
            {
                object1 = (LogicaNegociosCarrera)Session["object1"];
                object2 = (LogicaNegociosCuatriGrupo)Session["object2"];

            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        
            string mensaje2 = "";
            GridView1.DataSource = object1.DatosEnGridProgramaCarrera(Convert.ToInt16(dropCarrera.SelectedValue), ref mensaje2);
            GridView1.DataBind();
        }


        protected void btnMostrarAc_Click(object sender, EventArgs e)
        {

            string mensaje2 = "";
            GridView1.DataSource = object1.DatosEnGrid(Convert.ToInt16(dropCarrera1.SelectedValue), Convert.ToInt16(dropPeriodoC.SelectedValue), ref mensaje2);
            GridView1.DataBind();
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            string m = "";

            List<Carrera> listaC = null;
            listaC = object1.DevuelveCarreraEnID(ref m);

            if (listaC != null)
            {
                dropCarrera.Items.Clear();
                foreach (Carrera a in listaC)
                {
                    dropCarrera.Items.Add(new ListItem(a.NombreCarrera, a.Id_Carrera.ToString()));
                }
            }

            string m1 = "";

            List<Carrera> listaC1 = null;
            listaC1 = object1.DevuelveCarreraEnID(ref m1);

            if (listaC1 != null)
            {
                dropCarrera1.Items.Clear();
                foreach (Carrera a in listaC1)
                {
                    dropCarrera1.Items.Add(new ListItem(a.NombreCarrera, a.Id_Carrera.ToString()));
                }
            }


            string m2 = "";


            List<Cuatrimestre> listaCu = null;

            listaCu = object2.ListaCuatri(ref m);

            if (listaCu != null)
            {
                dropPeriodoC.Items.Clear();
                foreach (Cuatrimestre a in listaCu)
                {
                    dropPeriodoC.Items.Add(new ListItem(a.Periodo, a.Id_Cuatrimestres.ToString()));
                }
            }

        }
    }
}