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
    public class TipoVehiculosServicios
    {
        private RepoTiposDeVehiculos repositorio;

        public TipoVehiculosServicios()
        {
        }

        public List<TipoDeVehiculo> GetLista()
        {
            try
            {
                List<TipoDeVehiculo> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTiposDeVehiculos(cn);
                    lista = repositorio.GetLista();

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public int Agregar(TipoDeVehiculo tipo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTiposDeVehiculos(cn);

                    registros = repositorio.Agregar(tipo);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public int Borrar(TipoDeVehiculo tipo)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTiposDeVehiculos(cn);

                    registros = repositorio.Borrar(tipo);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public List<TipoDeVehiculo> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            try
            {
                List<TipoDeVehiculo> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTiposDeVehiculos(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina);

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
