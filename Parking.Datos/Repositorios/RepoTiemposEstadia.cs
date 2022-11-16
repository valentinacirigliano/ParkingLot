using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoTiemposEstadia
    {
        private SqlConnection cn;

        public RepoTiemposEstadia(SqlConnection cn)
        {
            this.cn = cn;
        }
        public TiempoEstadia GetTiempoPorId(int id)
        {
            TiempoEstadia tiempo = null;
            try
            {
                var cadenaComando =
                    "SELECT TiempoId, Nombre, Descripcion FROM TiemposEstadia WHERE TiempoId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tiempo = ConstruirTiempoEstadia(reader);
                        }
                    }
                }
                return tiempo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TiempoEstadia> GetLista()
        {
            List<TiempoEstadia> lista = new List<TiempoEstadia>();
            try
            {
                var cadenaComando = "SELECT TiempoId, Nombre, Descripcion FROM TiemposEstadia";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TiempoEstadia tiempo = ConstruirTiempoEstadia(reader);
                        lista.Add(tiempo);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private TiempoEstadia ConstruirTiempoEstadia(SqlDataReader reader)
        {
            return new TiempoEstadia()
            {
                TiempoId = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Descripcion = reader.GetString(2)
            };
        }
    }
}
