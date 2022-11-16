using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos.Repositorios
{
    public class RepoEgresos
    {
        private SqlConnection cn;

        public RepoEgresos(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Egreso> GetLista()
        {
            List<Egreso> lista = new List<Egreso>();
            try
            {
                var cadenaComando =
                    "SELECT IngresoId, FechaEgreso, TarifaId, Importe FROM Egresos";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Egreso egreso = ConstruirEgreso(reader);
                        lista.Add(egreso);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private Egreso ConstruirEgreso(SqlDataReader reader)
        {
            return new Egreso()
            {
                IngresoId = reader.GetInt32(0),
                FechaEgreso = reader.GetDateTime(1),
                TarifaId = reader.GetInt32(2),
                Importe = reader.GetDecimal(3)
            };
        }


        public int Agregar(Egreso egreso)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Egresos (IngresoId, FechaEgreso, TarifaId, Importe)" +
                    " VALUES (@id, @fec, @tar, @imp)");


                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", egreso.IngresoId);
                comando.Parameters.AddWithValue("@fec", egreso.FechaEgreso);
                comando.Parameters.AddWithValue("@tar", egreso.TarifaId);
                comando.Parameters.AddWithValue("@imp", egreso.Importe);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int Borrar(Egreso egreso)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Egresos WHERE IngresoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", egreso.IngresoId);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public List<Egreso> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            List<Egreso> lista = new List<Egreso>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT IngresoId, FechaEgreso, TarifaId, Importe FROM Egresos ");
                sb.Append("ORDER BY FechaEgreso  OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var egreso = ConstruirEgreso(reader);
                        lista.Add(egreso);
                    }

                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al leer de la tabla de Egresos");
            }

        }


        public int GetCantidad()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Egresos");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public decimal GetRecaudadoHoy()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT sum(Importe) FROM Egresos WHERE Day(FechaEgreso) = DAY(GETDATE())");

                var cadenaComando = sb.ToString();
                var comando=new SqlCommand(cadenaComando, cn);
                return (decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool Existe(int id)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Egresos WHERE IngresoId=@id");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                return (int)comando.ExecuteScalar()>0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
