using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalonesEmpresariales.Controller
{
    public partial class masterInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void crear_click()
        {
            Response.Redirect("~/Controller/Datos_Clientes_XYZ.aspx");
        }
    }
}