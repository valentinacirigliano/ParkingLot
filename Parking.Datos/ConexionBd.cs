using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Datos
{
    public class ConexionBd
    {
        private readonly string cadenaConexion;
        private SqlConnection cn;

        public static ConexionBd instancia = null;

        public static ConexionBd GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBd();
            }

            return instancia;
        }
        private ConexionBd()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                cn = new SqlConnection(cadenaConexion);
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                throw new Exception("No se estableció la conexión");
            }
        }

        public void CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
