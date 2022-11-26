using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace SalonesEmpresariales.Logica
{
    public class LogicaDesarrollo
    {
        public static void crearCliente(string identificacion, string NombreCliente, string ApellidoCliente, string TelefonoCliente, string CorreoCliente, int departamento, string municipio, string edadCliente)
        {
            using (SalonesEmpresarialesXYZEntities conex = new SalonesEmpresarialesXYZEntities())
            {
                int cedula = Convert.ToInt32(identificacion);
                int edad = Convert.ToInt32(edadCliente);
                clientes cliente = new clientes();

                cliente.Identificacion_cliente = cedula;
                cliente.Nombre_cliente = NombreCliente;
                cliente.Apellido_cliente = ApellidoCliente;
                cliente.Telefono_cliente = TelefonoCliente;
                cliente.Correo_cliente = CorreoCliente;
                cliente.Edad_cliente = edad;
                cliente.Departamento = departamento;
                cliente.Municipio = municipio;
                cliente.Borrado = true;

                conex.clientes.Add(cliente);
                conex.SaveChanges();
            }

        }



        public static List<municipios> ListaMunicipios(int DPTMTS)
        {
            using (SalonesEmpresarialesXYZEntities cnxDPTMTO = new SalonesEmpresarialesXYZEntities())
            {
                var Municipios = cnxDPTMTO.municipios.Where(x => x.departamento_id == DPTMTS).ToList();
                return Municipios;
            }

        }
        public static clientes Busar_Identificacion(int Identificacion)
        {

            using (SalonesEmpresarialesXYZEntities cnxBusqueda = new SalonesEmpresarialesXYZEntities())
            {
                var BuscarCliente = cnxBusqueda.clientes.Where(x => x.Identificacion_cliente == Identificacion && x.Borrado == true).FirstOrDefault();

                return (BuscarCliente);
            }

        }

        public static eventos buscarEvento(int id_Cliente, string fecha)
        {

            using (SalonesEmpresarialesXYZEntities cnxBusqueda = new SalonesEmpresarialesXYZEntities())
            {
                DateTime fecha23 = Convert.ToDateTime("2022-12-23");

                var BuscarCliente = cnxBusqueda.clientes.Where(x => x.ID_cliente == id_Cliente && x.Borrado == true).Select(x=> x.ID_cliente).FirstOrDefault();
                var Buscarfecha = cnxBusqueda.eventos.Where(x => x.Cliente_id==BuscarCliente && x.fecha_Evento == fecha).FirstOrDefault();
                return (Buscarfecha);
            }

        }

        public static clientes BorrarDatosCliente(int Identificacion)
        {
            using (SalonesEmpresarialesXYZEntities cnxBorrar = new SalonesEmpresarialesXYZEntities())
            {
                var BorrarCliente = cnxBorrar.clientes.Where(x => x.Identificacion_cliente == Identificacion).FirstOrDefault();

                if (BorrarCliente != null)
                {
                    BorrarCliente.Borrado = false;
                    cnxBorrar.SaveChanges();
                }
                else
                {
                    BorrarCliente.ID_cliente = 0;
                }
                return (BorrarCliente);
            }
        }

        public static clientes ActualizarDatosCliente(int identificacion, string NombreCliente, string ApellidoCliente, string TelefonoCliente, string CorreoCliente, string edadCliente, int departamento, string municipio)
        {

            using (SalonesEmpresarialesXYZEntities cnxActualizar = new SalonesEmpresarialesXYZEntities())
            {
                var ActualizarCliente = cnxActualizar.clientes.Where(x => x.Identificacion_cliente == identificacion && x.Borrado == true).FirstOrDefault();

                int Documento = Convert.ToInt32(identificacion);
                int edad = Convert.ToInt32(edadCliente);

                if (ActualizarCliente != null)
                {
                    ActualizarCliente.Identificacion_cliente = Documento;
                    ActualizarCliente.Nombre_cliente = NombreCliente;
                    ActualizarCliente.Apellido_cliente = ApellidoCliente;
                    ActualizarCliente.Telefono_cliente = TelefonoCliente;
                    ActualizarCliente.Correo_cliente = CorreoCliente;
                    ActualizarCliente.Edad_cliente = edad;
                    ActualizarCliente.Departamento = departamento;
                    ActualizarCliente.Municipio = municipio;
                    cnxActualizar.SaveChanges();
                }
                else
                {
                    ActualizarCliente.ID_cliente = 0;


                }




                return (ActualizarCliente);
            }


        }

        public static long BuscarDepartamento(int identificacion)
        {
            using (SalonesEmpresarialesXYZEntities conexBuscar = new SalonesEmpresarialesXYZEntities())
            {
                var departamento = conexBuscar.clientes.Where(x => x.Identificacion_cliente == identificacion).Select(x => x.Departamento).FirstOrDefault();
                return Convert.ToInt64(departamento);
            }

        }

        public static long crearEvento(string fecha, string cantidad, string motivo, string observaciones, string identificacion, string estado)
        {
            using (SalonesEmpresarialesXYZEntities conexEvento = new SalonesEmpresarialesXYZEntities())

            {
                var idOut = Convert.ToInt32(identificacion);
                var consultaID = conexEvento.clientes.Where(x => x.Identificacion_cliente == idOut && x.Borrado == true).Select(x => x.ID_cliente).FirstOrDefault();
                eventos evento = new eventos();

                evento.fecha_Evento = fecha;
                evento.Cantidad_personas = Convert.ToInt32(cantidad);
                evento.Motivo = motivo;
                evento.observaciones = observaciones;
                evento.Cliente_id = consultaID;
                evento.estado = estado;
                evento.Borrar = true;

                conexEvento.eventos.Add(evento);
                conexEvento.SaveChanges();

                if (evento.ID_evento > 0)
                {
                    return evento.ID_evento;
                }
                else
                {
                    return 0;
                }
            }

        }

        public static clientes Busar_DocCliente(int Identificacion)
        {

            using (SalonesEmpresarialesXYZEntities cnxBusquedaDoc = new SalonesEmpresarialesXYZEntities())
            {
                var BuscarClientes = cnxBusquedaDoc.clientes.Where(x => x.Identificacion_cliente == Identificacion && x.Borrado == true).FirstOrDefault();

                return (BuscarClientes);
            }

        }

        public static eventos ActualizarEvento(string fecha, string cantidad, string motivo, string observaciones, string estado, int id_Cliente)
        {

            using (SalonesEmpresarialesXYZEntities cnxActualizarEvento = new SalonesEmpresarialesXYZEntities())
            {


                var BuscarCliente = cnxActualizarEvento.clientes.Where(x => x.ID_cliente == id_Cliente && x.Borrado == true).Select(x => x.ID_cliente).FirstOrDefault();
                var ActualizarEventos = cnxActualizarEvento.eventos.Where(x => x.Cliente_id == BuscarCliente && x.fecha_Evento == fecha).FirstOrDefault();

                if (ActualizarEventos != null)
                {
                    ActualizarEventos.fecha_Evento = fecha;
                    ActualizarEventos.Cantidad_personas = Convert.ToInt32(cantidad);
                    ActualizarEventos.Motivo = motivo;
                    ActualizarEventos.observaciones = observaciones;
                    ActualizarEventos.estado = estado;
                    cnxActualizarEvento.SaveChanges();
                }
                else
                {
                    ActualizarEventos.ID_evento = 0;


                }
                return ActualizarEventos;
            }
        }

        public static eventos BorrarDatosEvento(int idEvento)
        {
            using (SalonesEmpresarialesXYZEntities cnxBorrarEvento = new SalonesEmpresarialesXYZEntities())
            {
                int idEVENTO = Convert.ToInt32(idEvento);
                var BorrarEvento = cnxBorrarEvento.eventos.Where(x => x.ID_evento == idEVENTO && x.Borrar == true).FirstOrDefault();

                if (BorrarEvento != null)
                {
                    BorrarEvento.Borrar = false;
                    cnxBorrarEvento.SaveChanges();
                }
                else
                {
                    BorrarEvento.ID_evento = 0;
                }
                return (BorrarEvento);
            }
        }

        public List<pa_Reporte_Result> reporte()
        {
            DataTable tabla = new DataTable();
            using (SalonesEmpresarialesXYZEntities conex= new SalonesEmpresarialesXYZEntities())
            {
                
                var conexion = conex.pa_Reporte().ToList();
                return conexion;
                
               
            }
        }
    }
}
