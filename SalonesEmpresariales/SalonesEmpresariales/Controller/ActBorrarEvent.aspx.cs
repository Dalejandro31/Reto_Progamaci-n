using SalonesEmpresariales.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalonesEmpresariales.Controller
{
    public partial class ActBorrarEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ActBorrlistarMotivoyEstado();
            }
        }

        protected void ActBorrlistarMotivoyEstado()
        {
            using (SalonesEmpresarialesXYZEntities conexActBorr = new SalonesEmpresarialesXYZEntities())
            {

                var actBorrConex = conexActBorr.Motivo_Estado.Where(x => x.ID_descripcion == "motivo").Select(x => new { Nombre = x.Nombre, x.ID }).ToList();
                DDLmotivo2.DataValueField = "ID";
                DDLmotivo2.DataTextField = "nombre";
                DDLmotivo2.DataSource = actBorrConex;
                DDLmotivo2.DataBind();
                DDLmotivo2.Items.Insert(0, new ListItem("Seleccione un Evento"));


                var borrActConex = conexActBorr.Motivo_Estado.Where(x => x.ID_descripcion == "estado").Select(x => new { Nombre = x.Nombre, x.ID }).ToList();
                DDLestado2.DataValueField = "ID";
                DDLestado2.DataTextField = "nombre";
                DDLestado2.DataSource = borrActConex;
                DDLestado2.DataBind();
                DDLestado2.Items.Insert(0, new ListItem("Seleccione un Estado"));

            }

        }



        protected void DDLmotivo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DDLestado2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnActualizarEvento1_Click(object sender, EventArgs e)
        {
            if (txtFecha2.Text == "")
            {
                lblFechaValidacion.Text = "Todos los campos son obligatorios";
                lblFechaValidacion.Visible = true;
            }
            else if (txtCantidad2.Text == "")
            {
                lblcantidadValidacion.Text = "Este campo es obligaorio";
                lblcantidadValidacion.Visible = true;
            }
            else if (DDLmotivo2.SelectedValue == "")
            {
                lblMotivoValidar.Text = "Este campo es obligaorio";
                lblMotivoValidar.Visible = true;
            }
            else if (txt_observacione2s.Text == "")
            {
                lblObservacionesValidar.Text = "Este campo es obligaorio";
                lblObservacionesValidar.Visible = true;
            }
            else if (DDLestado2.SelectedValue == "")
            {
                lblEstadoValidar.Text = "Este campo es obligaorio";
                lblEstadoValidar.Visible = true;
            }
            if (txtFecha2.Text == "" || txtCantidad2.Text == "" || DDLmotivo2.SelectedValue == "" || txt_observacione2s.Text == "" || DDLestado2.SelectedValue == "")
            {
                lblFechaValidacion.Text = "Todos los campos son obligatorios";
                lblFechaValidacion.Visible = true;
            }
            else
            {
                int Identificacion = Convert.ToInt32(txt_ActBusDocCliente.Text);
                string fecha = txtFecha.Text;
                var Busqueda = LogicaDesarrollo.Busar_Identificacion(Identificacion);
                var id_Cliente = Busqueda.ID_cliente;
                string cantidad = txtCantidad2.Text;
                string motivo = DDLmotivo2.SelectedValue;
                string observaciones = txt_observacione2s.Text;
                string estado = DDLestado2.SelectedValue;

                LogicaDesarrollo.ActualizarEvento(fecha, cantidad, motivo, observaciones, estado, id_Cliente);
            }


        }

        protected void BtnBorrarEvento1_Click(object sender, EventArgs e)
        {
            var Identificacion = Convert.ToInt32(txt_ActBusDocCliente.Text);
            string fecha = txtFecha.Text;
            var Busqueda = LogicaDesarrollo.Busar_Identificacion(Identificacion);

            var id_Cliente = Busqueda.ID_cliente;
            var busqueda_evento = LogicaDesarrollo.buscarEvento(id_Cliente, fecha);
            int idEvento = busqueda_evento.ID_evento;
            LogicaDesarrollo.BorrarDatosEvento(idEvento);
        }

        protected void btnBusActDOC_Click(object sender, EventArgs e)
        {
            if (txt_ActBusDocCliente.Text == "")
            {

            }
            else
            {
                var Identificacion = Convert.ToInt32(txt_ActBusDocCliente.Text);
                string fecha = txtFecha.Text;
                var Busqueda = LogicaDesarrollo.Busar_Identificacion(Identificacion);

                var id_Cliente = Busqueda.ID_cliente;
                var busqueda_evento = LogicaDesarrollo.buscarEvento(id_Cliente, fecha);


                if (Busqueda == null)
                {
                    //el cliente no se encontro

                }
                else
                {
                    VisualizarNombre2.Visible = true;
                    VisualizarApellido2.Visible = true;
                    VisualizarTelefono2.Visible = true;
                    AgentarEventoVisual2.Visible = true;



                    lblNombreVisual2.Text = Busqueda.Nombre_cliente;

                    lblVisualApellido2.Text = Busqueda.Apellido_cliente;

                    lblVisualizarTelefono2.Text = Busqueda.Telefono_cliente;

                    txtFecha2.Text = busqueda_evento.fecha_Evento;

                    txtCantidad2.Text = busqueda_evento.Cantidad_personas.ToString();

                    txt_observacione2s.Text = busqueda_evento.observaciones;

                    DDLmotivo2.SelectedValue = busqueda_evento.Motivo;

                    DDLestado2.SelectedValue = busqueda_evento.estado;


                }

            }
        }
    }
}