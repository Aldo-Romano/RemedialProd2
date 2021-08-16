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
    public class LogicaNegociosMateria
    {
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-C63MHBI1\SQLEXPRESS2017; Initial Catalog=Bitacora2021LabsUTP; Integrated Security = true;");

        public Boolean InsertarMateria(Materia materiaN, ref string mensaje)
        {
            SqlParameter[] param1 = new SqlParameter[3];

            param1[0] = new SqlParameter
            {
                ParameterName = "Nombe",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = materiaN.NombeMateria

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "HorasSemana",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = materiaN.HorasSemana

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "Extra",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = materiaN.Extra

            };
           

            string sentenciaSql = "insert into Materia values(@Nombe,@HorasSemana,@Extra);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        }

        public DataTable DatosEnGridCuati(Materia materiaD, ref string mens_salida)
        {
            string query2 = "select NombeMateria, HorasSemana, Extra where NombeMateria='" + materiaD.NombeMateria + "'";
            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public SqlDataReader EliminarMateria(Materia materia, ref string mens_salida)
        {

            SqlConnection conextemp = null;
            string query = "delete from Materia where NombeMateria='" + materia.NombeMateria + "'";

            conextemp = obAcc.AbrirConexion(ref mens_salida);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mens_salida);

            return datos;
        }

        public SqlDataReader ActualizarMateria(Materia materiaA, string datoAnterior, ref string mensaje)
        {
            SqlConnection conextemp = null;
            string query = "UPDATE Materia SET NombeMateria='" + materiaA.NombeMateria + "',HorasSemana='" + materiaA.HorasSemana + "',Extra='" + materiaA.Extra + "' where NombeMateria='" + datoAnterior + "'";

            conextemp = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mensaje);

            return datos;


        }
    }
}
