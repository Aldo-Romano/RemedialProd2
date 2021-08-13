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

    }
}
