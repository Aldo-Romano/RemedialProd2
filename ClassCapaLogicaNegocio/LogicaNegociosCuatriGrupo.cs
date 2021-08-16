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
                Value = cuatrimestre.Extra

            };


            string sentenciaSql = "insert into Cuatrimestre values(@periodo,@anio,@inicio,@fin,@extra);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref mensaje), ref mensaje, param1);

            return salida;
        }

        public DataTable DatosEnGridCuati(Cuatrimestre cuatrimestre, ref string mens_salida)
        {
            string query2 = "select Periodo, Anio, Inicio, Fin,Extra from Cuatrimestre where Periodo='" + cuatrimestre.Periodo + "'";
            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public SqlDataReader EliminarCuatri(Cuatrimestre cuatriD, ref string mens_salida)
        {

            SqlConnection conextemp = null;
            string query = "delete from Cuatrimestre where Periodo='" + cuatriD.Periodo + "'";

            conextemp = obAcc.AbrirConexion(ref mens_salida);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mens_salida);

            return datos;
        }

        public SqlDataReader ActualizarCuatri(Cuatrimestre cuatriA, string datoAnterior, ref string mensaje)
        {
            SqlConnection conextemp = null;
            string query = "UPDATE Carrera SET Periodo='" + cuatriA.Periodo + "',Anio='" + cuatriA.Anio + "',Inicio='" + cuatriA.Inicio + "',Fin='" + cuatriA.Fin + "',Extra='" + cuatriA.Extra + "' where Periodo='" + datoAnterior + "'";

            conextemp = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mensaje);

            return datos;


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


        public DataTable DatosEnGridGrupoCuati(int id, ref string mens_salida)
        {
            string query2 = "select ProgramaEd,nombreCarrea,Grado, Letra,Turno,Modalidad,G.Extra from GrupoCuatrimestre G inner join ProgramaEducativo P on G.F_ProgEd=P.Id_pe inner join Grupo GR on G.F_Grupo=GR.Id_grupo inner join Carrera C on P.F_Carrera=C.id_Carrera where F_Grupo='" + id + "'";
            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

        public SqlDataReader EliminarGrupoCuatri(GrupoCuatrimestre grupoC, ref string mens_salida)
        {

            SqlConnection conextemp = null;
            string query = "delete from GrupoCuatrimestre where F_Grupo='" + grupoC.F_Grupo + "'";

            conextemp = obAcc.AbrirConexion(ref mens_salida);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mens_salida);

            return datos;
        }

        public SqlDataReader ActualizarGrupoCuatri(GrupoCuatrimestre grupoC, string datoAnterior, ref string mensaje)
        {
            SqlConnection conextemp = null;
            string query = "UPDATE GrupoCuatrimestre SET F_ProgEd='" + grupoC.F_ProgEd + "',F_Grupo='" + grupoC.F_Grupo + "',F_Cuatri='" + grupoC.F_Cuatri + "',Turno='" + grupoC.Turno + "',Modalidad='" + grupoC.Modalidad + "',Extra='" + grupoC.Extra + "' where Periodo='" + datoAnterior + "'";

            conextemp = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref mensaje);

            return datos;
        }

        public List<ProgramaEducativo> ListaProgramaEducativo(ref string mensaje)
        {
            SqlConnection conex = null;
            string query = "select * from ProgramaEducativo";

            conex = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conex, ref mensaje);

            List<ProgramaEducativo> lista = new List<ProgramaEducativo>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    lista.Add(new ProgramaEducativo
                    {
                        Id_Pe = (byte)datos[0],
                        ProgramaEd = datos[1].ToString(),
                    }
                     );
                }
            }
            else
            {
                lista = null;
            }
            conex.Close();
            conex.Dispose();

            return lista;
        }

        public List<Cuatrimestre> ListaCuatri(ref string mensaje)
        {
            SqlConnection conex = null;
            string query = "select * from Cuatrimestre";

            conex = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conex, ref mensaje);

            List<Cuatrimestre> lista = new List<Cuatrimestre>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    lista.Add(new Cuatrimestre
                    {
                        Id_Cuatrimestres = (short)datos[0],
                        Periodo = datos[1].ToString(),
                    }
                     );
                }
            }
            else
            {
                lista = null;
            }
            conex.Close();
            conex.Dispose();

            return lista;
        }

        public List<Grupo> ListaGrupo(ref string mensaje)
        {
            SqlConnection conex = null;
            string query = "select * from Grupo";

            conex = obAcc.AbrirConexion(ref mensaje);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conex, ref mensaje);

            List<Grupo> lista = new List<Grupo>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    lista.Add(new Grupo
                    {
                        Id_Grupo = (short)datos[0],
                        Grado =  (byte)datos[1],
                    }
                     );
                }
            }
            else
            {
                lista = null;
            }
            conex.Close();
            conex.Dispose();

            return lista;
        }

    }
}
