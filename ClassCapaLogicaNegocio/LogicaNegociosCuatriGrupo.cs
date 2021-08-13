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
    public class LogicaNegociosCuatriGrupo
    {
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-C63MHBI1\SQLEXPRESS2017; Initial Catalog=Bitacora2021LabsUTP; Integrated Security = true;");

        public Boolean InsertarCuatrimestre(Cuatrimestre cuatrimestre, ref string mensaje)
        {
            SqlParameter[] param1 = new SqlParameter[5];

            param1[0] = new SqlParameter
            {
                ParameterName = "periodo",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Direction = ParameterDirection.Input,
                Value = cuatrimestre.Periodo

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "anio",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = cuatrimestre.Anio

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "inicio",
                SqlDbType = SqlDbType.Date,
                Direction = ParameterDirection.Input,
                Value = cuatrimestre.Inicio

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "fin",
                SqlDbType = SqlDbType.Date,
                Direction = ParameterDirection.Input,
                Value = cuatrimestre.Fin

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = cuatrimestre.Fin

            };


            string sentenciaSql = "insert into Cuatrimestre values(@periodo,@anio,@inicio,@fin,@extra);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        }

        public Boolean InsertarGrupoCuatrimestre(GrupoCuatrimestre grupoCuatri, ref string mensaje)
        {
            SqlParameter[] param1 = new SqlParameter[6];

            param1[0] = new SqlParameter
            {
                ParameterName = "f_progEd",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = grupoCuatri.F_ProgEd

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "f_grupo",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = grupoCuatri.F_Grupo

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "f_cuatri",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = grupoCuatri.F_Cuatri

            };

            param1[3] = new SqlParameter
            {
                ParameterName = "turno",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = grupoCuatri.Turno

            };

            param1[4] = new SqlParameter
            {
                ParameterName = "modalidad",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = grupoCuatri.Modalidad

            };

            param1[5] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = grupoCuatri.Extra

            };



            string sentenciaSql = "insert into GrupoCuatrimestre values(@f_progEd,@f_grupo,@f_cuatri,@turno,@modalidad,@extra);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        }
    }
}
