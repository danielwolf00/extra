using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMPILADORCS
{
    public partial class Exportar : Form
    {
        public Exportar()
        {
            InitializeComponent();
        }

        private void Filtrar_Btn_Click(object sender, EventArgs e)
        {
            string query = "select usuarios.Nombre as Nombre_Usuario,lenguajes.Nombre as Nombre_Lenguaje,fecha ,ruta_salida from compilo,usuarios ,lenguajes where compilo.id_usuario = usuarios.id_usuario and lenguajes.id_lenguaje = compilo.id_lenguaje";
            if (Usuario_Ch.Checked)
            {
                query += " and usuarios.nombre ='" + Usuario_Txt.Text + "'";
            }
            if (Lenguaje_Ch.Checked)
            {
                query += " and lenguajes.nombre ='" + Lenguaje_Cb.Text + "'";
            }
            if (Fecha_Ch.Checked)
            {
                query += " and fecha between '" + fecha1_Dtp.Value.ToString("yyyy/MM/dd") + "' and '" + fecha2_Dtp.Value.ToString("yyyy/MM/dd") + "'";
            }
            grd.DataSource = Conexion.query(query);
        }

        private void Exportar_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void Exportar_Csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Csv |*.csv";
            fichero.ShowDialog();

                StreamWriter sw = new StreamWriter(fichero.FileName);
                foreach (DataGridViewRow linea in grd.Rows)
                {
                    sw.WriteLine(linea.Cells["Nombre_Usuario"].Value + "," + linea.Cells["Nombre_Lenguaje"].Value + "," + linea.Cells["fecha"].Value + "," + linea.Cells["ruta_salida"].Value);
                }
                sw.Close();
            }

        private void Exportar_Txt_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Txt |*.txt";
            fichero.ShowDialog();

            StreamWriter sw = new StreamWriter(fichero.FileName);
            foreach (DataGridViewRow linea in grd.Rows)
            {
                sw.WriteLine(linea.Cells["Nombre_Usuario"].Value + " " + linea.Cells["Nombre_Lenguaje"].Value + " " + linea.Cells["fecha"].Value + " " + linea.Cells["ruta_salida"].Value);
            }
            sw.Close();
        }

        private void Exportar_Load(object sender, EventArgs e)
        {
            grd.DataSource = Conexion.query("select usuarios.Nombre as Nombre_Usuario,lenguajes.Nombre as Nombre_Lenguaje,fecha ,ruta_salida from compilo,usuarios ,lenguajes where compilo.id_usuario = usuarios.id_usuario and lenguajes.id_lenguaje = compilo.id_lenguaje");
        }
    }
    }

