using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassCapaAccesoDatos;
using ClassCapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace ClassCapaLogicaNegocio
{
    public class LogicaNegociosCarrera
    {
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-C63MHBI1\SQLEXPRESS2017; Initial Catalog=Bitacora2021LabsUTP; Integrated Security = true;");

        public Boolean InsertarCarrera(Carrera carrera, ref string mensaje)
        {
            SqlParameter[] param1 = new SqlParameter[1];

            param1[0] = new SqlParameter
            {
                ParameterName = "nom",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = carrera.NombreCarrera

            };
           
            string sentenciaSql = "insert into Carrera values(@nom);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        }


        public DataTable DatosEnGridCarrera(string nom, ref string mens_salida)
        {
            string query2 = "select nombreCarrea from carrera where nombreCarrea='" + nom +"'" ;
            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public SqlDataReader EliminarCarrera(string nom, ref string mens_salida)
        {

            SqlConnection conextemp = null;
            string query = "delete from Carrera where nombreCarrea='" + nom + "'";

            conextemp = obAcc.AbrirConexion(ref mens_salida);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mens_salida);

            return datos;
        }

        public Boolean ActualizarCarrera(Carrera carrera,string datoAnterior, ref string mensaje)
        {
            SqlParameter[] param1 = new SqlParameter[1];

            param1[0] = new SqlParameter
            {
                ParameterName = "nom",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = carrera.NombreCarrera

            };

            string sentenciaSql = "UPDATE Carrera SET nombreCarrea='"+"@nom"+"' where nombreCarrea='" + datoAnterior + "'";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        }

        public Boolean InsertarProgramaED(ProgramaEducativo programapd, ref string mensaje)
        {
            SqlParameter[] param1 = new SqlParameter[3];

            param1[0] = new SqlParameter
            {
                ParameterName = "programa",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = programapd.ProgramaEd

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "carrera",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = programapd.F_Carrera

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = programapd.Extra

            };

            string sentenciaSql = "insert into ProgramaEducativo values(@programa,@carrera,@extra);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        } 


        public List<Carrera> DevuelveCarreraID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Carrera";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Carrera> listaSalida = new List<Carrera>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Carrera
                    {
                        Id_Carrera = (int)datos[0],
                        NombreCarrera = (string)datos[1]
                       

                    }
                     );
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;

        }

        //public void DropCarrera()
        //{
        //    List<Carrera> listaA = null;
        //    string m = "";
        //    listaA = DevuelveClientesID(ref m);

        //    if (listaA != null)
        //    {
        //      d  .Items.Clear();
        //        foreach (Carrera a in listaA)
        //        {
        //            dlCarrera.Items.Add(new ListItem(a.NombreCarrera, a.Id_Carrera.ToString()));
        //        }
        //    }
        //}

    }
}
