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
        private IngresosServicios servicioIngresos;
        private RepoNiveles repoNiveles;
        private RepoTiposEst repoTipoEst;
        public LugaresServicios()
        {
        }

        public Lugar GetLugarPorId(int id)
        {
            try
            {
                Lugar lugar = new Lugar();
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    repoTipoEst = new RepoTiposEst(cn);
                    lugar = repositorio.GetLugarPorId(id);
                    lugar.TipoEstacionamiento = repoTipoEst.GetTipoPorId(lugar.TipoEstacionamientoId);
                    return lugar;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

        public List<Lugar> GetListaLibres()
        {
            try
            {
                List<Lugar> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    repoNiveles = new RepoNiveles(cn);
                    repoTipoEst = new RepoTiposEst(cn);
                    lista = repositorio.GetListaLibres();
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

        

        public int GetCantidad()
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    registros = repositorio.GetCantidad();
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidadSinEgresar()
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoLugares(cn);
                    registros = repositorio.GetCantidadSinEgresar();
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
