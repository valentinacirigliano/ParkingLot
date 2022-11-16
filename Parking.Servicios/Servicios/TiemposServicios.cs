using Parking.Datos;
using Parking.Datos.Repositorios;
using Parking.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Servicios.Servicios
{
    public class TiemposServicios
    {
        private RepoTiemposEstadia repositorio;

        public TiemposServicios()
        {
        }

        public List<TiempoEstadia> GetLista()
        {
            try
            {
                List<TiempoEstadia> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTiemposEstadia(cn);
                    lista = repositorio.GetLista();
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public TiempoEstadia GetTiempoEstadiaPorId(int id)
        {
            try
            {
                TiempoEstadia TiempoEstadia;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTiemposEstadia(cn);
                    TiempoEstadia = repositorio.GetTiempoPorId(id);
                }

                return TiempoEstadia;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
