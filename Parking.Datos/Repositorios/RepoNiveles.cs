using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoNiveles
    {
        private SqlConnection cn;

        public RepoNiveles(SqlConnection cn)
        {
            this.cn = cn;
        }

        public Nivel GetNivelPorId(int id)
        {
            Nivel nivel = null;
            try
            {
                var cadenaComando =
                    "SELECT NivelId, Descripcion FROM Niveles WHERE NivelId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            nivel = ConstruirNivel(reader);
                        }
                    }
                }
                return nivel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Nivel> GetLista()
        {
            List<Nivel> lista = new List<Nivel>();
            try
            {
                var cadenaComando = "SELECT NivelId, Descripcion FROM Niveles";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nivel nivel = ConstruirNivel(reader);
                        lista.Add(nivel);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Nivel ConstruirNivel(SqlDataReader reader)
        {
            return new Nivel()
            {
                NivelId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }



        public int GetCantidad()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Niveles");

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
