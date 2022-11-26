using SalonesEmpresariales.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalonesEmpresariales.Controller
{
    public partial class busqueda_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListasMunicipiosDepartamentos();
            }
        }

        protected void ListasMunicipiosDepartamentos()
        {
            using (SalonesEmpresarialesXYZEntities lstDPTOS = new SalonesEmpresarialesXYZEntities())
            {
                var ListaDepartamento = lstDPTOS.departamentos.Where(x => x.ID_departamento == x.ID_departamento).Select(x => new { Nombre = x.nombre, x.ID_departamento }).ToList();
                DDLdepartamento.DataValueField = "ID_departamento";
                DDLdepartamento.DataTextField = "nombre";
                DDLdepartamento.DataSource = ListaDepartamento;
                DDLdepartamento.DataBind();

                DDLdepartamento.Items.Insert(0, new ListItem("Seleccione un Departamento...", "0"));
                DDLmunicipios.Items.Insert(0, new ListItem("Seleccione una Municipios...", "0"));
            }


        }

        protected void btnBuscar_Click(object sender, EventArgs e)

        {
            if (txt_BusquedaIdentificacion.Text == "")
            {

            }
            else
            {
                var Identificacion = Convert.ToInt32(txt_BusquedaIdentificacion.Text);
                var Busqueda = LogicaDesarrollo.Busar_Identificacion(Identificacion);
                var Departamento = LogicaDesarrollo.BuscarDepartamento(Identificacion);

                if (Busqueda == null)
                {
                    //el cliente no se encontro

                }
                else
                {
                    ActualizarDatosCLi.Visible = true;
                    ActualizarApellido.Visible = true;
                    ActualizarTelefono.Visible = true;
                    ActualizarCorreo.Visible = true;
                    ActualizarEdad.Visible = true;
                    BotonActualizar.Visible = true;
                    ActualizarDepartemento.Visible = true;
                    ActualizarMunicipios.Visible = true;

                    txtNombreBusqueda.Text = Busqueda.Nombre_cliente;

                    txtApellidoBusqueda.Text = Busqueda.Apellido_cliente;

                    txtTelefonoBusqueda.Text = Busqueda.Telefono_cliente;

                    txtCorreoBusqueda.Text = Busqueda.Correo_cliente;

                    txtEdadBusqueda.Text = Busqueda.Edad_cliente.ToString();

                    DDLdepartamento.SelectedValue = Departamento.ToString();

                    DDLmunicipios.SelectedValue = DDLmunicipios.SelectedValue;
                }

            }


        }

        protected void BorrarDatos_Click(object sender, EventArgs e)
        {
            var BorrarCliente = Convert.ToInt32(txt_BusquedaIdentificacion.Text);
            var BorrarCliente1 = LogicaDesarrollo.BorrarDatosCliente(BorrarCliente);

            txtNombreBusqueda.Text = "";

            txtApellidoBusqueda.Text = "";

            txtTelefonoBusqueda.Text = "";

            txtCorreoBusqueda.Text = "";

            txtEdadBusqueda.Text = "";

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombreBusqueda.Text == "")
            {
                lblValidacionAct1.Text = "Este campo es obligaorio";
                lblValidacionAct1.Visible = true;
            }
            else if (txtApellidoBusqueda.Text == "")
            {
                lblValidacionAct2.Text = "Este campo es obligaorio";
                lblValidacionAct2.Visible = true;
            }
            else if(txtTelefonoBusqueda.Text == "")
            {
                lblValidacionAct3.Text = "Este campo es obligaorio";
                lblValidacionAct3.Visible = true;
            }
            else if(txtCorreoBusqueda.Text == "")
            {
                lblValidacionAct4.Text = "Este campo es obligaorio";
                lblValidacionAct4.Visible = true;
            }
            else if(txtEdadBusqueda.Text == "")
            {
                lblValidacionAct5.Text = "Este campo es obligaorio";
                lblValidacionAct5.Visible = true;
            }
            else
            {
                //capturara datos
                var ActualizarCliente = Convert.ToInt32(txt_BusquedaIdentificacion.Text);
                string nombre = txtNombreBusqueda.Text;
                string Apellido = txtApellidoBusqueda.Text;
                string Telefono = txtTelefonoBusqueda.Text;
                string Correo = txtCorreoBusqueda.Text;
                string Edad = txtEdadBusqueda.Text;
                int departamento = Convert.ToInt32(DDLdepartamento.SelectedValue);
                string municipios = DDLmunicipios.SelectedValue;
                var ActCliente = LogicaDesarrollo.ActualizarDatosCliente(ActualizarCliente, nombre, Apellido, Telefono, Correo, Edad, departamento, municipios);
            }








        }

        protected void DDLdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SalonesEmpresarialesXYZEntities conext = new SalonesEmpresarialesXYZEntities())
            {
                int DPTMTS = Convert.ToInt32(DDLdepartamento.SelectedValue);
                var municipios = LogicaDesarrollo.ListaMunicipios(DPTMTS);
                List<string> vs = new List<string>();
                string itemNombre = "";
                foreach (var item in municipios)
                {
                    vs.Add(item.nombre);
                }


                DDLmunicipios.DataSource = vs;
                DDLmunicipios.DataBind();


            }
        }

        protected void btnFKbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}