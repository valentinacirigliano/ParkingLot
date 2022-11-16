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
    public class IngresosServicios
    {
        private RepoVehiculos repositorio;
        private RepoTarifas repoTarifas;
        private RepoLugares repoLugares;

        public IngresosServicios()
        {
        }

        public List<IngresosVehiculos> GetLista()
        {
            try
            {
                List<IngresosVehiculos> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);
                    repoTarifas = new RepoTarifas(cn);
                    repoLugares = new RepoLugares(cn);
                    lista = repositorio.GetLista();
                    foreach (var ingreso in lista)
                    {
                        ingreso.Tarifa = repoTarifas.GetTarifaPorId(ingreso.TarifaId);
                        ingreso.Lugar = repoLugares.GetLugarPorId(ingreso.LugarId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IngresosVehiculos GetIngresoPorLugar(Lugar lugar)
        {
            try
            {
                IngresosVehiculos ingreso = new IngresosVehiculos();
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);
                    repoTarifas = new RepoTarifas(cn);
                    repoLugares=new RepoLugares(cn);
                    ingreso = repositorio.GetIngresoPorLugar(lugar);
                    ingreso.Tarifa = repoTarifas.GetTarifaPorId(ingreso.TarifaId);
                    ingreso.Lugar = repoLugares.GetLugarPorId(ingreso.LugarId);
                    return ingreso;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IngresosVehiculos GetIngresoPorId(int id)
        {
            try
            {
                IngresosVehiculos ingreso = new IngresosVehiculos();
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);
                    repoTarifas = new RepoTarifas(cn);
                    repoLugares = new RepoLugares(cn);
                    ingreso = repositorio.GetIngresoPorId(id);
                    ingreso.Tarifa = repoTarifas.GetTarifaPorId(ingreso.TarifaId);
                    ingreso.Lugar = repoLugares.GetLugarPorId(ingreso.LugarId);
                    return ingreso;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ExisteEnGarage(IngresosVehiculos ingreso)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);

                    existe = repositorio.ExisteEnGarage(ingreso);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool LugarOcupado(Lugar lugar)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);

                    existe = repositorio.LugarOcupado(lugar);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(IngresosVehiculos ingreso)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);

                    registros = repositorio.Agregar(ingreso);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public int Borrar(IngresosVehiculos ingreso)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);

                    registros = repositorio.Borrar(ingreso);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(IngresosVehiculos ingreso)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);

                    registros = repositorio.Editar(ingreso);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<IngresosVehiculos> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            try
            {
                List<IngresosVehiculos> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoVehiculos(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina);

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
                    repositorio = new RepoVehiculos(cn);
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
