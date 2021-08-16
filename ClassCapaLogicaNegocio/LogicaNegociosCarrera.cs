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


        public DataTable DatosEnGridCarrera(Carrera carreraMostrar, ref string mens_salida)
        {
            string query2 = "select nombreCarrea from carrera where nombreCarrea='" + carreraMostrar.NombreCarrera +"'" ;
            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public SqlDataReader EliminarCarrera(Carrera carreraD, ref string mens_salida)
        {

            SqlConnection conextemp = null;
            string query = "delete from Carrera where nombreCarrea='" + carreraD.NombreCarrera + "'";

            conextemp = obAcc.AbrirConexion(ref mens_salida);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mens_salida);

            return datos;
        }

        public SqlDataReader ActualizarCarrera(Carrera carrera,string datoAnterior, ref string mensaje)
        {
            SqlConnection conextemp = null;
            string query = "UPDATE Carrera SET nombreCarrea='" + carrera.NombreCarrera + "' where nombreCarrea='" + datoAnterior + "'";

            conextemp = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mensaje);

            return datos;

           
        }

        public List<Carrera> DevuelveCarreraEnID(ref string msj)
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
                        Id_Carrera = (byte)datos[0],
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

        public DataTable DatosEnGridProgramaED(ProgramaEducativo programaMostrar, ref string mens_salida)
        {
            string query2 = "select ProgramaEd, nombreCarrea, Extra from ProgramaEducativo P inner join Carrera C on P.F_Carrera = C.id_Carrera where  F_Carrera='" + programaMostrar.F_Carrera + "'";
           
            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public SqlDataReader EliminarProgramaEducativo(ProgramaEducativo ProgramaED, ref string mens_salida)
        {

            SqlConnection conextemp = null;
            string query = "delete from ProgramaEducativo where ProgramaED='" + ProgramaED.ProgramaEd + "'";

            conextemp = obAcc.AbrirConexion(ref mens_salida);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mens_salida);

            return datos;
        }

        public SqlDataReader ActualizarProgramaED(ProgramaEducativo programaA, string datoAnterior, ref string mensaje)
        {
            SqlConnection conextemp = null;
            string query = "UPDATE ProgramaEducativo SET ProgramaED='" + programaA.ProgramaEd + "',F_Carrera='" + programaA.F_Carrera +"',Extra='" + programaA.Extra + "' where ProgramaED='" + datoAnterior + "'";

            conextemp = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mensaje);

            return datos;


        }


        public DataTable DatosEnGridProgramaCarrera(int nom, ref string mens_salida)
        {
            string query2 = "select nombreCarrea,ProgramaEd from ProgramaEducativo P inner join Carrera C on P.F_Carrera=C.id_Carrera where id_Carrera='" + nom + "'";

            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public DataTable DatosEnGrid(int nom,int periodo, ref string mens_salida)
        {
            string query2 = "select nombreCarrea,Grado,Letra,Periodo,ProgramaEd from GrupoCuatrimestre G inner join Grupo Gp on G.F_Grupo=Gp.Id_grupo inner join Carrera C inner join ProgramaEducativo P on C.id_Carrera=P.F_Carrera on G.F_ProgEd=P.Id_pe inner join Cuatrimestre Cu on G.F_Cuatri=Cu.id_Cuatrimestre where id_Carrera='" + nom + "' and Id_pe='" + periodo + "';";

            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }


    }
}
