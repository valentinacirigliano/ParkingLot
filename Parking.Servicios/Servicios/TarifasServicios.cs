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
    public class TarifasServicios
    {
        private RepoTarifas repositorio;
        private TiemposServicios servicioTiempos;

        public TarifasServicios()
        {
        }

        public List<Tarifa> GetLista(TipoDeVehiculo tipo = null)
        {
            try
            {
                List<Tarifa> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);
                    RepoTiposDeVehiculos repoTiposDeVehiculos= new RepoTiposDeVehiculos(cn);
                    servicioTiempos = new TiemposServicios();
                    lista = repositorio.GetLista(tipo);
                    foreach (var tarifa in lista)
                    {
                        tarifa.TipoVehiculo = repoTiposDeVehiculos.GetTipoPorId(tarifa.TipoVehiculoId);
                        tarifa.Tiempo = servicioTiempos.GetTiempoEstadiaPorId(tarifa.TiempoId);
                    }
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public Tarifa GetTarifaPorId(int id)
        {
            try
            {
                Tarifa tarifa;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);
                    RepoTiposDeVehiculos repoTiposDeVehiculos = new RepoTiposDeVehiculos(cn);
                    tarifa = repositorio.GetTarifaPorId(id);
                    tarifa.TipoVehiculo = repoTiposDeVehiculos.GetTipoPorId(tarifa.TipoVehiculoId);
                    
                }

                return tarifa;

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
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);

                    existe = repositorio.Existe(tarifa);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);

                    registros = repositorio.Agregar(tarifa);
                }

                return registros;
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
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);
                    estaRelacionado = repositorio.EstaRelacionado(tarifa);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int Borrar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);

                    registros = repositorio.Borrar(tarifa);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Tarifa tarifa)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);

                    registros = repositorio.Editar(tarifa);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Tarifa> GetListaPaginada(int paginaActual, int registrosPorPagina,
                                    TipoDeVehiculo tipo=null, TiempoEstadia tiempo=null)
        {
            try
            {
                List<Tarifa> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina,tipo,tiempo);

                    return lista;
                }
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
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoTarifas(cn);
                    registros = repositorio.GetCantidad();
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
