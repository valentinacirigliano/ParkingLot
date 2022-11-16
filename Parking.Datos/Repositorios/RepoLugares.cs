using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoLugares
    {
        private SqlConnection cn;

        public RepoLugares(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Lugar> GetLista()
        {
            List<Lugar> lista = new List<Lugar>();
            try
            {
                var cadenaComando =
                    "SELECT LugarId, Nombre, NivelId, TipoEstacionamientoId FROM Lugares";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lugar lugar = ConstruirLugar(reader);
                        lista.Add(lugar);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }




        private Lugar ConstruirLugar(SqlDataReader reader)
        {
            return new Lugar()
            {
                LugarId = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                NivelId = reader.GetInt32(2),
                TipoEstacionamientoId = reader.GetString(3)
            
            };
        }

        

        public List<Lugar> GetLista(Nivel nivel = null, TipoEstacionamiento tipo=null)
        {
            List<Lugar> lista = new List<Lugar>();
            try
            {
                StringBuilder sb =
                    new StringBuilder("SELECT LugarId, Nombre, NivelId, TipoEstacionamientoId FROM Lugares ");
                if (nivel != null)
                {
                    sb.Append("WHERE NivelId=@niv");
                }else if(tipo != null)
                {
                    sb.Append("WHERE TipoEstacionamientoId=@tip");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (nivel != null)
                {
                    comando.Parameters.AddWithValue("@niv", nivel.NivelId);
                }
                if (tipo != null)
                {
                    comando.Parameters.AddWithValue("@tip", tipo.TipoestacionamientoId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lugar lugar = ConstruirLugar(reader);
                        lista.Add(lugar);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Lugar> GetListaSinEgresar()
        {
            List<Lugar> lista = new List<Lugar>();
            try
            {
                var cadenaComando =
                    " SELECT IV.LugarId,Nombre,NivelId,TipoEstacionamientoId" +
                    " FROM Lugares L JOIN IngresosVehiculos IV ON L.LugarId = IV.IngresoId" +
                    " left join Egresos E on IV.IngresoId = E.IngresoId where E.IngresoId is null";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lugar lugar = ConstruirLugar(reader);
                        lista.Add(lugar);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int GetCantidad(Nivel nivel=null, TipoEstacionamiento tipo=null)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Lugares");
                if (nivel != null)
                {
                    sb.Append(" WHERE NivelId=@niv");
                }
                if (tipo != null)
                {
                    sb.Append(" WHERE TipoEstacionamientoId=@tip");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (nivel != null)
                {
                    comando.Parameters.AddWithValue("@niv", nivel.NivelId);
                }
                if (tipo != null)
                {
                    comando.Parameters.AddWithValue("@tip", tipo.TipoestacionamientoId);
                }
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        

        public Lugar GetLugarPorId(int id)
        {
            Lugar lugar = null;
            try
            {
                var cadenaComando =
                    "SELECT LugarId, Nombre, NivelId, TipoEstacionamientoId FROM Lugares WHERE LugarId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lugar = ConstruirLugar(reader);
                        }
                    }
                }
                return lugar;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Lugar> GetListaPaginada(int paginaActual, int registrosPorPagina, Nivel nivel = null, TipoEstacionamiento tipo=null)
        {
            List<Lugar> lista = new List<Lugar>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT LugarId, Nombre, NivelId, TipoEstacionamientoId FROM Lugares ");
                if (nivel != null)
                {
                    sb.Append("WHERE NivelId=@niv ");
                }
                else if(tipo != null)
                {
                    sb.Append("WHERE TipoEstacionamientoId=@tip ");
                }
                sb.Append(" ORDER BY LugarId OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
                if (nivel != null)
                {
                    comando.Parameters.AddWithValue("@niv", nivel.NivelId);
                }
                if (tipo != null)
                {
                    comando.Parameters.AddWithValue("@tip", tipo.TipoestacionamientoId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var lugar = ConstruirLugar(reader);
                        lista.Add(lugar);
                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer de la tabla de Lugares");
            }
        }

    }
}
