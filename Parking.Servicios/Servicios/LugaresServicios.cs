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
    public class LugaresServicios
    {
        private RepoLugares repositorio;
        private RepoVehiculos repositorioIngresos;
        private RepoNiveles repoNiveles;
        private RepoTiposEst repoTipoEst;
        public LugaresServicios()
        {
        }

        public List<Lugar> GetLista()
        {
            try
            {
                List<Lugar> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    repoNiveles = new RepoNiveles(cn);
                    repoTipoEst = new RepoTiposEst(cn);
                    lista = repositorio.GetLista();
                    foreach (var lugar in lista)
                    {
                        lugar.Nivel = repoNiveles.GetNivelPorId(lugar.NivelId);
                        lugar.TipoEstacionamiento = repoTipoEst.GetTipoPorId(lugar.TipoEstacionamientoId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Lugar> GetListaSinEgresar()
        {
            try
            {
                List<Lugar> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    repoNiveles = new RepoNiveles(cn);
                    repoTipoEst = new RepoTiposEst(cn);
                    lista = repositorio.GetListaSinEgresar();
                    foreach (var lugar in lista)
                    {
                        lugar.Nivel = repoNiveles.GetNivelPorId(lugar.NivelId);
                        lugar.TipoEstacionamiento = repoTipoEst.GetTipoPorId(lugar.TipoEstacionamientoId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Lugar> GetListaPaginada(int paginaActual, int registrosPorPagina, Nivel nivel = null, TipoEstacionamiento tipo = null)
        {
            try
            {
                List<Lugar> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    repoNiveles = new RepoNiveles(cn);
                    repoTipoEst = new RepoTiposEst(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina, nivel, tipo);
                    foreach (var lugar in lista)
                    {
                        lugar.Nivel = repoNiveles.GetNivelPorId(lugar.NivelId);
                        lugar.TipoEstacionamiento = repoTipoEst.GetTipoPorId(lugar.TipoEstacionamientoId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Lugar> GetLista(IngresosVehiculos ingreso)
        {
            throw new NotImplementedException();
        }


        public int GetCantidad(Nivel nivel = null, TipoEstacionamiento tipo = null)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    registros = repositorio.GetCantidad(nivel, tipo);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public RepoTarifas repoTarifas;
        public IngresosVehiculos GetIngresoPorLugar(Lugar lugar)
        {
            IngresosVehiculos ingreso=new IngresosVehiculos();
            try
            {
                
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repoTarifas = new RepoTarifas(cn);
                    repositorioIngresos = new RepoVehiculos(cn);
                    ingreso = repositorioIngresos.GetIngresoPorLugar(lugar);
                    ingreso.Tarifa = repoTarifas.GetTarifaPorId(ingreso.TarifaId);
                }
                

                return ingreso;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
