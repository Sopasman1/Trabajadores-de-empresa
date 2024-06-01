using System.Text;
using System.Xml;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Word=Microsoft.Office.Interop.Word;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Trabajadores_de_empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void showMensaje()
        {
            MessageBox.Show("Bienvenido a Registro de Empresa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona fullnombre = new persona();
            fullnombre.Nombre = nombre.Text;
            fullnombre.ApellidoPaterno = apellidop.Text;
            fullnombre.ApellidoMaterno = apellidom.Text;

            Fechas fechas = new Fechas();
            fechas.Edad = EDADtxt.Text;
            fechas.Fdn = fechatxt.Value;

            datoscorreo correo = new datoscorreo("", "", "", "");
            correo.CURP = curptxt.Text;
            correo.RFC = rfctxt.Text;
            correo.Correo = correotxt.Text;
            correo.Phone = telefonotxt.Text;


            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(Datostrabajador);

            file.Cells[0].Value = nombre.Text;
            file.Cells[1].Value = apellidop.Text;
            file.Cells[2].Value = apellidom.Text;
            file.Cells[3].Value = EDADtxt.Text;
            file.Cells[4].Value = fechatxt.Value;
            file.Cells[5].Value = curptxt.Text;
            file.Cells[6].Value = rfctxt.Text;
            file.Cells[7].Value = correotxt.Text;
            file.Cells[8].Value = telefonotxt.Text;
            file.Cells[9].Value = puestocb.Text;
            file.Cells[10].Value = Horascb.Text;
            file.Cells[11].Value = (float.Parse(label14.Text) * float.Parse(label15.Text));

            Datostrabajador.Rows.Add(file);

            nombre.Text = apellidop.Text = apellidom.Text = EDADtxt.Text = fechatxt.Text = curptxt.Text = rfctxt.Text = correotxt.Text = telefonotxt.Text = puestocb.Text = Horascb.Text = "";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float sueldo;
            sueldo = puestocb.SelectedIndex;

            switch (sueldo)
            {
                case 0: label14.Text = "80"; break;
                case 1: label14.Text = "90"; break;
                default: label14.Text = "100"; break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            float Horas;
            Horas = Horascb.SelectedIndex;
            switch (Horas)
            {
                case 0: label15.Text = "2"; break;
                case 1: label15.Text = "4"; break;
                case 2: label15.Text = "5"; break;
                case 3: label15.Text = "6"; break;
                case 4: label15.Text = "7"; break;
                default: label15.Text = "8"; break;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Eliminar empleado",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    Datostrabajador.Rows.Remove(Datostrabajador.CurrentRow);

                }

            }
            catch { }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Documento de Word (*.docx)|*.docx|Archivo Excel (*.xlsx)|*.xlsx|Archivo PDF (*.pdf)|*.pdf|Archivo de Texto (*.txt)|*.txt|Archivo de XML(*.XML)|*.XML|Archivo de json(*.json)*.json|";
            saveFileDialog1.Title = "Guardar como archivo";
            saveFileDialog1.ShowDialog();

            // Si se selecciona un archivo y se confirma la selección
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;

                    // Si el usuario selecciona exportar a un archivo de Word
                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        ExportarAWord(fileName);
                    }
                    // Si el usuario selecciona exportar a un archivo de Excel
                    else if (saveFileDialog1.FilterIndex == 2)
                    {
                        ExportarAExcel(fileName);
                    }
                    // Si el usuario selecciona exportar a un archivo PDF
                    else if (saveFileDialog1.FilterIndex == 3)
                    {
                        ExportarAPDF(fileName);
                    }
                    // Si el usuario selecciona exportar a un archivo de texto
                    else if (saveFileDialog1.FilterIndex == 4)
                    {
                        ExportarATexto(fileName);
                    }

                    else if (saveFileDialog1.FilterIndex == 5)
                    {
                        ExportarAXML(fileName);
                    }

                    else if (saveFileDialog1.FilterIndex == 6)
                    {
                        ExportarAJSON(fileName);
                    }


                    MessageBox.Show("Los datos se exportaron correctamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportarATexto(string fileName)
        {
            // Crear un StringBuilder para construir el contenido del archivo de texto
            StringBuilder sb = new StringBuilder();

            // Escribe los encabezados de las columnas
            foreach (DataGridViewColumn column in Datostrabajador.Columns)
            {
                sb.Append(column.HeaderText + "\t");
            }
            sb.AppendLine();

            // Escribe el contenido de cada celda
            foreach (DataGridViewRow row in Datostrabajador.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        sb.Append(cell.Value.ToString() + "\t");
                    }
                    else
                    {
                        sb.Append("\t"); // Si el valor es nulo, solo agregamos una tabulación
                    }
                }
                sb.AppendLine();
            }

            // Escribir el contenido del StringBuilder en el archivo de texto
            File.WriteAllText(fileName, sb.ToString());
        }

        private void ExportarAExcel(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Crea un nuevo libro de Excel
            Workbook workbook = excelApp.Workbooks.Add();

            // Obtiene la primera hoja de trabajo del libro
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            // Escribe los datos del DataGridView en la hoja de trabajo
            for (int i = 0; i < Datostrabajador.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = Datostrabajador.Columns[i].HeaderText;
            }

            for (int i = 0; i < Datostrabajador.Rows.Count; i++)
            {
                for (int j = 0; j < Datostrabajador.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Datostrabajador.Rows[i].Cells[j].Value;
                }
            }

            // Guarda el libro en un archivo
            workbook.SaveAs(fileName);

            // Cierra el libro y Excel
            workbook.Close();
            excelApp.Quit();
        }

        private void ExportarAWord(string fileName)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();

            Microsoft.Office.Interop.Word.Paragraph para = doc.Paragraphs.Add();
            para.Range.Text = "Datos exportados desde DataGridView:";

            Microsoft.Office.Interop.Word.Table table = doc.Tables.Add(para.Range, Datostrabajador.Rows.Count + 1, Datostrabajador.Columns.Count);
            for (int i = 0; i < Datostrabajador.Columns.Count; i++)
            {
                table.Cell(1, i + 1).Range.Text = Datostrabajador.Columns[i].HeaderText;
            }

            for (int i = 0; i < Datostrabajador.Rows.Count; i++)
            {
                for (int j = 0; j < Datostrabajador.Columns.Count; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = Datostrabajador.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Guarda el documento en un archivo
            object fileNameObject = fileName;
            object fileFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault;
            doc.SaveAs(ref fileNameObject, ref fileFormat);

            // Cierra el documento y Word
            object saveChanges = false;
            doc.Close(ref saveChanges);
            wordApp.Quit();
        }

        private void ExportarAPDF(string fileName)
        {
            // Crear un nuevo documento PDF
            Document doc = new Document();

            // Crear un objeto PdfWriter para escribir en el archivo PDF
            PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));

            // Abrir el documento para escribir en él
            doc.Open();

            // Agregar un párrafo al documento
            Paragraph paragraph = new Paragraph("Datos exportados desde DataGridView:");
            doc.Add(paragraph);

            // Crear una tabla con el mismo número de columnas que el DataGridView
            PdfPTable table = new PdfPTable(Datostrabajador.Columns.Count);

            // Agregar encabezados de columnas a la tabla
            for (int i = 0; i < Datostrabajador.Columns.Count; i++)
            {
                table.AddCell(new Phrase(Datostrabajador.Columns[i].HeaderText));
            }

            // Agregar datos de celdas a la tabla
            for (int i = 0; i < Datostrabajador.Rows.Count; i++)
            {
                for (int j = 0; j < Datostrabajador.Columns.Count; j++)
                {
                    if (Datostrabajador.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new Phrase(Datostrabajador.Rows[i].Cells[j].Value.ToString()));
                    }
                    else
                    {
                        table.AddCell(new Phrase(""));
                    }
                }
            }

            // Agregar la tabla al documento
            doc.Add(table);

            // Cerrar el documento
            doc.Close();
        }
        private void ExportarAXML(string fileName)
        {
            // Crea un objeto XmlWriterSettings para establecer el formato de escritura XML
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; // Formatea el XML para que sea legible

            // Crea un XmlWriter para escribir en el archivo XML
            using (XmlWriter writer = XmlWriter.Create(fileName, settings))
            {
                // Escribe el encabezado del documento XML
                writer.WriteStartDocument();

                // Escribe el elemento raíz del documento XML
                writer.WriteStartElement("Datos");

                // Escribe los datos del DataGridView como elementos XML
                foreach (DataGridViewRow row in Datostrabajador.Rows)
                {
                    writer.WriteStartElement("Registro");

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string columnName = Datostrabajador.Columns[cell.ColumnIndex].HeaderText;
                        writer.WriteElementString(columnName, cell.Value.ToString());
                    }

                    writer.WriteEndElement(); // Cierra el elemento "Registro"
                }

                writer.WriteEndElement(); // Cierra el elemento "Datos"
                writer.WriteEndDocument(); // Finaliza el documento XML
            }


        }
        private void ExportarAJSON(string fileName)
        {
            // Crear una lista para almacenar los datos del DataGridView
            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

            // Recorrer las filas del DataGridView y convertir los datos a un formato compatible con JSON
            foreach (DataGridViewRow row in Datostrabajador.Rows)
            {
                Dictionary<string, object> rowData = new Dictionary<string, object>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string columnName = Datostrabajador.Columns[cell.ColumnIndex].HeaderText;
                    rowData[columnName] = cell.Value;
                }
                data.Add(rowData);
            }

            // Serializar la lista a formato JSON y escribirlo en un archivo
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(fileName, jsonData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TXT files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);

                        // Limpiar el DataGridView antes de cargar nuevos datos
                        Datostrabajador.Rows.Clear();

                        foreach (string line in lines)
                        {
                            // Si la línea comienza con '#' (comentario), no la cargamos
                            if (line.StartsWith("#"))
                            {
                                continue; // Pasamos a la siguiente línea
                            }

                            string[] fields = line.Split('\t'); // Utilizar '\t' como delimitador

                            // Agregar una fila al DataGridView y establecer sus valores de celda
                            Datostrabajador.Rows.Add(fields);
                        }

                        MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedColumnName = FiltrarCB.SelectedItem.ToString();
            if (selectedColumnName == null)
            {
                MessageBox.Show("Por favor, selecciona una columna.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtén el valor seleccionado en la ComboBox
            string filterValue = FiltrarCB.Text;

            // Si el valor seleccionado es nulo o vacío, muestra todas las filas
            if (string.IsNullOrEmpty(filterValue))
            {
                foreach (DataGridViewRow row in Datostrabajador.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Itera sobre las filas del DataGridView y filtra según el valor seleccionado
            foreach (DataGridViewRow row in Datostrabajador.Rows)
            {
                // Obtén el valor de la celda en la columna seleccionada
                string cellValue = row.Cells[selectedColumnName].Value.ToString();

                // Si el valor de la celda coincide con el valor seleccionado, muestra la fila; de lo contrario, ocúltala
                row.Visible = (cellValue != null && cellValue.Equals(filterValue));
            }
        }
    }
}
