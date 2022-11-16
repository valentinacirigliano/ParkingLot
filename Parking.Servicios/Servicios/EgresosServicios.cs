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
    public class EgresosServicios
    {
        private RepoEgresos repositorio;
        private IngresosServicios ingresosServicios;
        private TarifasServicios tarifasServicios;

        public EgresosServicios()
        {
            ingresosServicios = new IngresosServicios();
            tarifasServicios = new TarifasServicios();
        }

        public List<Egreso> GetLista()
        {
            try
            {
                List<Egreso> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoEgresos(cn);
                    lista = repositorio.GetLista();
                    foreach (var e in lista)
                    {
                        e.Ingreso = ingresosServicios.GetIngresoPorId(e.IngresoId);
                        e.Tarifa = tarifasServicios.GetTarifaPorId(e.TarifaId);
                    }
                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public int Agregar(Egreso egreso)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoEgresos(cn);

                    registros = repositorio.Agregar(egreso);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public int Borrar(Egreso egreso)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoEgresos(cn);

                    registros = repositorio.Borrar(egreso);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        

        public List<Egreso> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            try
            {
                List<Egreso> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoEgresos(cn);
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
                    repositorio = new RepoEgresos(cn);
                    registros = repositorio.GetCantidad();
                }

                return registros;
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
                decimal total = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoEgresos(cn);
                    total = repositorio.GetRecaudadoHoy();
                }

                return total;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(int ingresoId)
        {
            try
            {
                bool existe = false;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new RepoEgresos(cn);
                    existe = repositorio.Existe(ingresoId);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
