using SalonesEmpresariales.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalonesEmpresariales.Controller
{
    public partial class Eventos_XYZ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listarMotivoyEstado();
            }
        }

        protected void listarMotivoyEstado()
        {
            using (SalonesEmpresarialesXYZEntities conexionEvento = new SalonesEmpresarialesXYZEntities())
            {

                var evntoConex = conexionEvento.Motivo_Estado.Where(x => x.ID_descripcion == "motivo").Select(x => new { Nombre = x.Nombre, x.ID }).ToList();
                DDLmotivo.DataValueField = "ID";
                DDLmotivo.DataTextField = "nombre";
                DDLmotivo.DataSource = evntoConex;
                DDLmotivo.DataBind();
                DDLmotivo.Items.Insert(0, new ListItem("Seleccione un Evento"));


                var estadoConex = conexionEvento.Motivo_Estado.Where(x => x.ID_descripcion == "estado").Select(x => new { Nombre = x.Nombre, x.ID }).ToList();
                DDLestado.DataValueField = "ID";
                DDLestado.DataTextField = "nombre";
                DDLestado.DataSource = estadoConex;
                DDLestado.DataBind();
                DDLestado.Items.Insert(0, new ListItem("Seleccione un Estado"));

            }

        }


        protected void DDLmotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DDLestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnCrearEvento_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                lblValidacionFecha.Text = "Este campo es obligaorio";
                lblValidacionFecha.Visible = true;
            }
            else if (txtCantidad.Text == "")
            {
                lblValidacionCantidad.Text = "Este campo es obligaorio";
                lblValidacionCantidad.Visible = true;
            }
            else if (DDLmotivo.SelectedValue == "Seleccione un Evento")
            {
                lblValidacionMotivo.Text = "Este campo es obligaorio";
                lblValidacionMotivo.Visible = true;
            }
            else if(txt_observaciones.Text == "")
            {
                lblValidacionObservaciones.Text = "Este campo es obligaorio";
                lblValidacionObservaciones.Visible = true;
            }
            else if(DDLestado.SelectedValue == "")
            {
                lblValidacionEstado.Text = "Seleccione un Estado";
                lblValidacionEstado.Visible = true;
            }
            else
            {
                string fecha = txtFecha.Text;
                string cantidad = txtCantidad.Text;
                string motivo = DDLmotivo.SelectedValue;
                string observaciones = txt_observaciones.Text;
                string identificacion = txt_BusquedaDocCliente.Text;
                string estado = DDLestado.SelectedValue;
                long idEvento = LogicaDesarrollo.crearEvento(fecha, cantidad, motivo, observaciones, identificacion, estado);
                IdEvento.Text = idEvento.ToString();
            }



        }

        //protected void BtnActualizarEvento_Click(object sender, EventArgs e)
        //{

        //    string idEvento = IdEvento.Text;
        //    DateTime fecha = Convert.ToDateTime(txtFecha.Text);
        //    string cantidad = txtCantidad.Text;
        //    string motivo = DDLmotivo.SelectedValue;
        //    string observaciones = txt_observaciones.Text;

        //    string estado = DDLestado.SelectedValue;

        //    LogicaDesarrollo.ActualizarEvento(fecha, cantidad, motivo, observaciones, estado, idEvento);
        //}

        //protected void BtnBorrarEvento_Click(object sender, EventArgs e)
        //{
        //    string idEvento = IdEvento.Text;
        //    LogicaDesarrollo.BorrarDatosEvento(idEvento);
        //}

        protected void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            if (txt_BusquedaDocCliente.Text == "")
            {

            }
            else
            {
                var Identificacion = Convert.ToInt32(txt_BusquedaDocCliente.Text);
                var Busqueda = LogicaDesarrollo.Busar_Identificacion(Identificacion);

                if (Busqueda == null)
                {
                    //el cliente no se encontro

                }
                else
                {
                    VisualizarNombre.Visible = true;
                    VisualizarApellido.Visible = true;
                    VisualizarTelefono.Visible = true;
                    AgentarEventoVisual.Visible = true;



                    txtNombreVisual.Text = Busqueda.Nombre_cliente;

                    txtApelliVisual.Text = Busqueda.Apellido_cliente;

                    txtTelefonoVisual.Text = Busqueda.Telefono_cliente;





                }

            }

        }


    }
}