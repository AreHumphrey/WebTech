using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechDep
{
    public class ExportHelper
    {
        public bool Export(DataGridView dgv)
        {
            bool exported = false;
            List<string> lines = new List<string>();

            // Заголовки
            DataGridViewColumnCollection header = dgv.Columns;
            bool firstDone = false;
            StringBuilder headerLine = new StringBuilder();

            foreach (DataGridViewColumn col in header)
            {
                if (!firstDone)
                {
                    headerLine.Append(col.DataPropertyName);
                    firstDone = true;
                }
                else
                {
                    headerLine.Append("," + col.DataPropertyName);
                }
            }
            lines.Add(headerLine.ToString());

            // Данные таблицы
            foreach (DataGridViewRow row in dgv.Rows)
            {
                StringBuilder dataLine = new StringBuilder();
                firstDone = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {
                        dataLine.Append("," + cell.Value);
                    }
                }
                lines.Add(dataLine.ToString());
            }

            string file = @"C:\Users\napap\OneDrive\Рабочий стол\Freelance\диплом\Client_app\Reports\Product_report.csv";
            System.IO.File.WriteAllLines(file, lines);
            System.Diagnostics.Process.Start(file);
            return exported;
        }
    }
}
