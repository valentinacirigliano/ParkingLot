using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoTarifas
    {
        private SqlConnection cn;

        public RepoTarifas(SqlConnection cn)
        {
            this.cn = cn;
        }

        public Tarifa GetTarifaPorId(int id)
        {
            try
            {
                Tarifa tarifa = null;
                var cadenaComando = "SELECT TarifaId, NombreTarifa, TiempoId, TipovehiculoId, Precio, RowVersion FROM Tarifas  WHERE TarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tarifa = ConstruirTarifa(reader);
                    }
                }

                return tarifa;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        private Tarifa ConstruirTarifa(SqlDataReader reader)
        {
            return new Tarifa()
            {
                TarifaId = reader.GetInt32(0),
                NombreTarifa = reader.GetString(1),
                TiempoId = reader.GetInt32(2),
                TipoVehiculoId =reader.GetInt32(3),
                Precio=reader.GetDecimal(4),
                RowVersion = (byte[])reader[5]

            };
        }
        public int Agregar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "INSERT INTO Tarifas (NombreTarifa, TiempoId, TipoVehiculoId, Precio)" +
                    " VALUES(@nom , @time, @tipo, @pre)";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", tarifa.NombreTarifa);
                comando.Parameters.AddWithValue("@time", tarifa.TiempoId);
                comando.Parameters.AddWithValue("@tipo", tarifa.TipoVehiculoId);
                comando.Parameters.AddWithValue("@pre", tarifa.Precio);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    tarifa.TarifaId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Ciudades WHERE TarifaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                    tarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }
                return registrosAfectados;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Tarifa> GetLista(TipoDeVehiculo tipo=null)
        {
            List<Tarifa> lista = new List<Tarifa>();
            try
            {
                StringBuilder sb =
                    new StringBuilder("SELECT TarifaId, NombreTarifa, TiempoId, TipoVehiculoId, Precio, RowVersion FROM Tarifas ");
                if (tipo != null)
                {
                    sb.Append("WHERE TipoVehiculoId=@id");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (tipo != null)
                {
                    comando.Parameters.AddWithValue("@id", tipo.TipoDeVehiculoId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tarifa tarifa = ConstruirTarifa(reader);
                        lista.Add(tarifa);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Tarifa tarifa)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Tarifas WHERE NombreTarifa=@nom";
                if (tarifa.TarifaId != 0)
                {
                    cadenaComando += " AND TarifaId<>@tarifaId";
                }
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", tarifa.NombreTarifa);

                if (tarifa.TarifaId != 0)
                {
                    comando.Parameters.AddWithValue("@tarifaId", tarifa.TarifaId);
                }

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Tarifas WHERE TarifaId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                comando.Parameters.AddWithValue("@r", tarifa.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Tarifa tarifa)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "UPDATE Tarifas SET Precio=@p " +
                    "WHERE TarifaId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@p", tarifa.Precio);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                comando.Parameters.AddWithValue("@r", tarifa.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados > 0)
                {
                    cadenaComando = "SELECT RowVersion FROM Tarifas WHERE TarifaId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                    tarifa.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad(TipoDeVehiculo tipo=null)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Tarifas");
                if (tipo != null)
                {
                    sb.Append(" WHERE TipoVehiculoId=@tipo");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (tipo != null)
                {
                    comando.Parameters.AddWithValue("@tipo", tipo.TipoDeVehiculoId);
                }
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Tarifa tarifa)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM VehiculosAbonos WHERE TarifaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tarifa.TarifaId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Tarifa> GetListaPaginada(int paginaActual, int registrosPorPagina, TipoDeVehiculo tipo = null, TiempoEstadia tiempo=null)
        {
            List<Tarifa> lista = new List<Tarifa>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TarifaId, NombreTarifa, TiempoId, TipoVehiculoId, Precio, RowVersion FROM Tarifas ");
                if (tipo != null && tiempo==null)
                {
                    sb.Append("WHERE TipoVehiculoId=@tipo");
                }else if (tiempo!=null && tipo==null)
                {
                    sb.Append("WHERE TiempoId=@time");
                }
                else if(tiempo != null && tipo != null)
                {
                    sb.Append("WHERE TipoVehiculoId=@tipo AND TiempoId=@time");
                }
                sb.Append(" ORDER BY TiempoId OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
                if (tipo != null)
                {
                    comando.Parameters.AddWithValue("@tipo", tipo.TipoDeVehiculoId);
                }
                if (tiempo != null)
                {
                    comando.Parameters.AddWithValue("@time", tiempo.TiempoId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tarifa = ConstruirTarifa(reader);
                        lista.Add(tarifa);
                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer de la tabla de Tarifas");
            }
        }


    }
}
