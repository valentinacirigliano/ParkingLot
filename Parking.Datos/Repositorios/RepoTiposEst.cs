using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoTiposEst
    {
        private SqlConnection cn;

        public RepoTiposEst(SqlConnection cn)
        {
            this.cn = cn;
        }

        public TipoEstacionamiento GetTipoPorId(string id)
        {
            TipoEstacionamiento tipo = null;
            try
            {
                var cadenaComando =
                    "SELECT TipoEstacionamientoId, Descripcion FROM TiposEstacionamiento " +
                    "WHERE TipoEstacionamientoId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tipo = ConstruirTipoEstacionamiento(reader);
                        }
                    }
                }
                return tipo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<TipoEstacionamiento> GetLista()
        {
            List<TipoEstacionamiento> lista = new List<TipoEstacionamiento>();
            try
            {
                var cadenaComando = "SELECT TipoEstacionamientoId, Descripcion FROM TiposEstacionamiento";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoEstacionamiento tipo = ConstruirTipoEstacionamiento(reader);
                        lista.Add(tipo);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private TipoEstacionamiento ConstruirTipoEstacionamiento(SqlDataReader reader)
        {
            return new TipoEstacionamiento()
            {
                TipoestacionamientoId = reader.GetString(0),
                Descripcion = reader.GetString(1)
            };
        }



        public int GetCantidad()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM TiposEstacionamiento");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);

                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
