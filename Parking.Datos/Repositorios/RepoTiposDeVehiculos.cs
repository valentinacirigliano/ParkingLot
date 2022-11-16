using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoTiposDeVehiculos
    {
        private SqlConnection cn;

        public RepoTiposDeVehiculos(SqlConnection cn)
        {
            this.cn = cn;
        }
        public int Agregar(TipoDeVehiculo tipo)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "INSERT INTO TiposDeVehiculo (TipoVehiculo)" +
                    " VALUES(@nom)";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", tipo.TipoVehiculo);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    tipo.TipoDeVehiculoId = (int)(decimal)comando.ExecuteScalar();

                }
                return registrosAfectados;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Borrar(TipoDeVehiculo tipo)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM TiposDeVehiculo WHERE TipoVehiculoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipo.TipoDeVehiculoId);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoDeVehiculo GetTipoPorId(int id)
        {
            try
            {
                TipoDeVehiculo tipo = null;
                var cadenaComando = "SELECT TipoVehiculoId, TipoVehiculo FROM TiposDeVehiculo" +
                    "  WHERE TipoVehiculoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tipo = ConstruirTipoVehiculo(reader);
                    }
                }

                return tipo;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<TipoDeVehiculo> GetLista()
        {
            List<TipoDeVehiculo> lista = new List<TipoDeVehiculo>();
            try
            {
                var cadenaComando =
                    "SELECT TipoVehiculoId, TipoVehiculo FROM TiposDeVehiculo";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoDeVehiculo tipo = ConstruirTipoVehiculo(reader);
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



        private TipoDeVehiculo ConstruirTipoVehiculo(SqlDataReader reader)
        {
            return new TipoDeVehiculo()
            {
                TipoDeVehiculoId = reader.GetInt32(0),
                TipoVehiculo = reader.GetString(1)
            };
        }

        public List<TipoDeVehiculo> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            List<TipoDeVehiculo> lista = new List<TipoDeVehiculo>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TipoVehiculoId, TipoVehiculo FROM TiposDeVehiculo");
                
                sb.Append(" ORDER BY TipoVehiculo OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
                
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tarifa = ConstruirTipoVehiculo(reader);
                        lista.Add(tarifa);
                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer de la tabla de TiposDeVehiculo");
            }
        }
    }
}
