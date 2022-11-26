using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Data;
using SalonesEmpresariales.Logica;
using System.Windows.Forms;

namespace SalonesEmpresariales.Controller
{
    public partial class reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        public void ExportarDatos(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
            exportar.Application.Workbooks.Add(true);

            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in dataListado.Columns)
            {
                indicecolumna++;

                exportar.Cells[1, indicecolumna] = columna.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow fila in dataListado.Rows)
            {
                indiceFila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in dataListado.Columns)
                {
                    indicecolumna++;
                    exportar.Cells[indiceFila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
                 
            }

            exportar.Visible = true;

        }

        protected void btnDescargar_Click(object sender, EventArgs e)
        {
            using (SalonesEmpresarialesXYZEntities conex = new SalonesEmpresarialesXYZEntities())
            {
                var listado = conex.pa_Reporte().Where(x => x.Cliente_id == x.Cliente_id).ToList();
                var prueba = DescargarReport.DataSource = listado;
                ExportarDatos(DescargarReport);
            }
        }

        private void ExportarDatos(GridView descargarReport)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
            exportar.Application.Workbooks.Add(true);

            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in descargarReport.Columns)
            {
                indicecolumna++;

                exportar.Cells[1, indicecolumna] = columna.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow fila in descargarReport.Rows)
            {
                indiceFila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in descargarReport.Columns)
                {
                    indicecolumna++;
                    exportar.Cells[indiceFila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }

            }

            exportar.Visible = true;
        }
    }

}