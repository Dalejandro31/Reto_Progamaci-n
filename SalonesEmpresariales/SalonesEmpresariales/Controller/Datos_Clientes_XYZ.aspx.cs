using SalonesEmpresariales.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalonesEmpresariales.Controller
{
    public partial class Datos_Clientes_XYZ : System.Web.UI.Page
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
                DDLdepartamento.Items.Insert(0, new ListItem("Seleccione una Departamento...", "0"));
                DDLmunicipios.Items.Insert(0, new ListItem("Seleccione una Municipios...", "0"));
            }


        }

        protected void btn_Crear_Click(object sender, EventArgs e)
        {
            if (txt_identificacion.Text == "")
            {
                lblValidacionID.Text = "Este campo es obligaorio";
                lblValidacionID.Visible = true;
            }
            else if (txt_nombre.Text == "")
            {
                lblValidacionNombre.Text = "Este campo es obligaorio";
                lblValidacionNombre.Visible = true;
            }
            else if (txt_apellido.Text == "")
            {
                lblValidacionApellido.Text = "Este campo es obligaorio";
                lblValidacionApellido.Visible = true;
            }
            else if (txt_telefono.Text == "")
            {
                lblValidacionTelofono.Text = "Este campo es obligaorio";
                lblValidacionTelofono.Visible = true;
            }
            else if (txt_correo.Text == "")
            {
                lblValidacionCorreo.Text = "Este campo es obligaorio";
                lblValidacionCorreo.Visible = true;
            }
            else if (txt_edad.Text == "")
            {
                lblValidacionEdad.Text = "Este campo es obligaorio";
                lblValidacionEdad.Visible = true;
            }
            else

            {
                string Identificacion = txt_identificacion.Text;
                string Nombre = txt_nombre.Text;
                string Apellido = txt_apellido.Text;
                string Telefono = txt_telefono.Text;
                string Correo = txt_correo.Text;
                int departamento = Convert.ToInt32(DDLdepartamento.SelectedValue);
                string municipio = DDLmunicipios.SelectedValue;
                string Edad = txt_edad.Text;
                LogicaDesarrollo.crearCliente(Identificacion, Nombre, Apellido, Telefono, Correo, departamento, municipio, Edad);

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
    }
}