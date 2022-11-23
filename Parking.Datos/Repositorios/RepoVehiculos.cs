using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoVehiculos
    {
        private SqlConnection cn;

        public RepoVehiculos(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<IngresosVehiculos> GetLista()
        {
            List<IngresosVehiculos> lista = new List<IngresosVehiculos>();
            try
            {
                var cadenaComando =
                    "SELECT IngresoId, LugarId, Patente, FechaIngreso, TipoVehiculoId, RowVersion FROM IngresosVehiculos" +
                    " ORDER BY FechaIngreso";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IngresosVehiculos vehiculo = ConstruirIngresoVehiculo(reader);
                        lista.Add(vehiculo);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<IngresosVehiculos> GetListaDePatente(string patente)
        {
            List<IngresosVehiculos> lista = new List<IngresosVehiculos>();
            try
            {
                var cadenaComando =
                    "SELECT IngresoId, LugarId, Patente, FechaIngreso, TipoVehiculoId, RowVersion FROM IngresosVehiculos" +
                    " WHERE Patente=@pat ORDER BY FechaIngreso ";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@pat", patente);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IngresosVehiculos vehiculo = ConstruirIngresoVehiculo(reader);
                        lista.Add(vehiculo);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        //consulta si la patente que quiero ingresar se encuentra ingresada y no se efectuó egreso. Así que 
        //no podía ingresarlo si no se retiró
        public bool ExisteEnGarage(IngresosVehiculos ingreso)
        {
            try
            {
                var cadenaComando = "SELECT Count(*) FROM IngresosVehiculos IV left join Egresos E on " +
                    "IV.IngresoId = E.IngresoId where E.IngresoId is null AND Patente=@p";

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@p", ingreso.Patente);

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //consulta si el lugar que le paso está en ingresos pero no en engresos.
        //La consuta devuelve si el lugar no encuentra en egresos y por lo tanto esta ocupado
        public bool LugarOcupado(Lugar lugar)
        {
            try
            {
                var cadenaComando = "SELECT Count(*) FROM IngresosVehiculos IV left join Egresos E on " +
                    "IV.IngresoId = E.IngresoId where E.IngresoId is null AND LugarId=@id";

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", lugar.LugarId);

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private IngresosVehiculos ConstruirIngresoVehiculo(SqlDataReader reader)
        {
            return new IngresosVehiculos()
            {
                IngresoId=reader.GetInt32(0),
                LugarId = reader.GetInt32(1),
                Patente = reader.GetString(2),
                FechaIngreso=reader.GetDateTime(3),
                TipoVehiculoId = reader.GetInt32(4),
                RowVersion = (byte[])reader[5]
            };
        }


        public int Agregar(IngresosVehiculos ingreso)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO IngresosVehiculos (LugarId, Patente, FechaIngreso, TipoVehiculoId)" +
                    " VALUES (@lug, @pat, @fec, @tipo)");


                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@lug", ingreso.LugarId);
                comando.Parameters.AddWithValue("@pat", ingreso.Patente);
                comando.Parameters.AddWithValue("@fec", ingreso.FechaIngreso);
                comando.Parameters.AddWithValue("@tipo", ingreso.TipoVehiculoId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    ingreso.IngresoId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM IngresosVehiculos WHERE IngresoId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", ingreso.IngresoId);
                    ingreso.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EstaRelacionado(IngresosVehiculos vehiculo)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Egresos WHERE IngresoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", vehiculo.IngresoId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(IngresosVehiculos vehiculo)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM IngresosVehiculos WHERE IngresoId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", vehiculo.IngresoId);
                comando.Parameters.AddWithValue("@r", vehiculo.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(IngresosVehiculos vehiculo)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE IngresosVehiculos SET LugarId=lug, Patente=@nom, FechaIngreso=@fec, TipoVehiculoId=@tipo");
                sb.Append(" WHERE IngresoId=@id");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", vehiculo.LugarId);
                comando.Parameters.AddWithValue("@fec", vehiculo.Patente);
                comando.Parameters.AddWithValue("@tar", vehiculo.FechaIngreso);
                comando.Parameters.AddWithValue("@tipo", vehiculo.TipoVehiculoId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {
                    cadenaComando = "SELECT RowVersion FROM IngresosVehiculos WHERE IngresoId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", vehiculo.IngresoId);
                    vehiculo.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IngresosVehiculos> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            List<IngresosVehiculos> lista = new List<IngresosVehiculos>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT IngresoId, LugarId, Patente, FechaIngreso, TipoVehiculoId, RowVersion FROM IngresosVehiculos ");
                sb.Append("ORDER BY FechaIngreso  OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var vehiculo = ConstruirIngresoVehiculo(reader);
                        lista.Add(vehiculo);
                    }

                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al leer de la tabla de IngresosVehiculos");
            }

        }

        public int GetCantidadIngresosDePatente(string patente)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM IngresosVehiculos WHERE Patente=@pat");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@pat", patente);
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM IngresosVehiculos");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<IngresosVehiculos> GetListaSinEgresar()
        {
            List<IngresosVehiculos> lista = new List<IngresosVehiculos>();
            try
            {
                var cadenaComando =
                    " SELECT IV.IngresoId,IV.LugarId,IV.Patente,IV.FechaIngreso,IV.TipoVehiculoId,IV.RowVersion " +
                    "FROM IngresosVehiculos IV left join Egresos E on IV.IngresoId = E.IngresoId " +
                    "where E.IngresoId is null ORDER BY FechaIngreso";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IngresosVehiculos ingreso = ConstruirIngresoVehiculo(reader);
                        lista.Add(ingreso);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IngresosVehiculos GetIngresoPorLugar(Lugar lugar)
        {
            IngresosVehiculos ingreso = new IngresosVehiculos(); ;
            try
            {
                var cadenaComando =
                   "SELECT TOP(1) IngresoId, LugarId, Patente, FechaIngreso, TipoVehiculoId, RowVersion" +
                   " FROM IngresosVehiculos WHERE LugarId =@id ORDER BY FechaIngreso DESC";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", lugar.LugarId);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            ingreso = ConstruirIngresoVehiculo(reader);
                        }
                    }
                }
                return ingreso;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IngresosVehiculos GetIngresoPorId(int id)
        {
            IngresosVehiculos ingreso = null;
            try
            {
                var cadenaComando =
                    "SELECT IngresoId, LugarId, Patente, FechaIngreso, TipoVehiculoId, RowVersion " +
                    "FROM IngresosVehiculos WHERE IngresoId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            ingreso = ConstruirIngresoVehiculo(reader);
                        }
                    }
                }
                return ingreso;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
