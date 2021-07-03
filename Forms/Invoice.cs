using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace DashboardApp.Forms
{
    public partial class Invoice : Form
    {
        public string _total;
        //Constructor
        public Invoice()
        {
            InitializeComponent();
            themeSelected();
        }

        //Display color Control from ThemeSave
        public void themeSelected()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DashboardApp\\Settings\\settings.txt";
            try
            {
                if (File.Exists(path))
                {
                    string themeColor = File.ReadAllText(path);
                    lbl_Name.ForeColor = Color.FromName(themeColor);
                    lbl_ClientName.ForeColor = Color.FromName(themeColor);
                    lbl_TitleInvoice.ForeColor = Color.FromName(themeColor);
                    lbl_ClientFactNumber.ForeColor = Color.FromName(themeColor);
                    btn_GenerateFact.BackColor = Color.FromName(themeColor);
                    btn_GenerateFact.ForeColor = Color.White;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        //Generate PDF File
        private void btn_GenerateFact_Click(object sender, EventArgs e)
        {
            GeneratePDF();
        }

        //Method
        private void GeneratePDF()
        {
            try
            {
                //Set Type of Document
                string type = "";
                if (checkBoxDevis.Checked) type = "Devis";
                else if (checkBoxFacture.Checked) type = "FV";
                else if (checkBoxRefound.Checked) type = "Av";
                else MessageBox.Show("Merci de faire un choix sur le type de document");

                //Set Path for Document
                string date = DateTime.Now.ToString();
                string fileName = string.Format(type + (DateTime.Now.ToString("yyyyddMHHmmss")) + ".pdf");
                string outFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DashboardApp\\Invoices\\";
                string path = System.IO.Path.Combine(outFile, fileName);

                //Check if Type of Document is Selected
                if (checkBoxDevis.Checked || checkBoxFacture.Checked || checkBoxRefound.Checked)
                {
                    //Create Document with iText7
                    PdfWriter writer = new PdfWriter(path);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    //Page Content
                    Paragraph factNumber = new Paragraph(Path.GetFileNameWithoutExtension(fileName) + "\n\n")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFontSize(11)
                        ;
                    document.Add(factNumber);

                    Paragraph information = new Paragraph(richTextBoxInfo.Text + "\n\n")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        ;
                    document.Add(information);

                    Paragraph clientInformation = new Paragraph(richTextBoxClientInfo.Text + "\n\n")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFontSize(11)
                        ;
                    document.Add(clientInformation);

                    Paragraph titleInvoice = new Paragraph("Title : " + textBoxTitleInvoice.Text + "\n\n")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        ;
                    document.Add(titleInvoice);

                    //Create HeaderTable in Document
                    Table tableau = new Table(6, true);

                    //Add Cell to Table
                    CreateCellOnTable("Catégorie", tableau);
                    CreateCellOnTable("Désignation", tableau);
                    CreateCellOnTable("Quantité", tableau);
                    CreateCellOnTable("Pu", tableau);
                    CreateCellOnTable("Prix HT", tableau);
                    CreateCellOnTable("TVA", tableau);
                    document.Add(tableau);

                    //Create DataTable in Document
                    Table data = new Table(6, true);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        int qte = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        int pu = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                        int total = qte * pu;
                        dataGridView1.Rows[i].Cells[4].Value = total;
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell celli in row.Cells)
                        {
                            data.AddCell(celli.FormattedValue.ToString())
                                .SetTextAlignment(TextAlignment.CENTER);

                        }
                    }

                    document.Add(data);

                    //Create Price info in Document
                    Paragraph spaceBetweenTable = new Paragraph("\n\n");
                    document.Add(spaceBetweenTable);

                    Table priceInfo = new Table(6, true);

                    CreateCellOnTable("Prix HT", priceInfo);
                    CreateCellOnTable("TVA 2.10%", priceInfo);
                    CreateCellOnTable("TVA 5%", priceInfo);
                    CreateCellOnTable("TVA 10%", priceInfo);
                    CreateCellOnTable("TVA 20%", priceInfo);
                    CreateCellOnTable("Prix TTC", priceInfo);

                    document.Add(priceInfo);

                    //Create tablePrice in Document
                    Table price = new Table(6, true);
                    int totalHT =0;
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        totalHT += Convert.ToInt32(r.Cells[4].Value);
                    }
                    CreateCellOnTable(totalHT.ToString(), price);
                    CreateCellOnTable(totalHT.ToString(), price);
                    CreateCellOnTable(totalHT.ToString(), price);
                    CreateCellOnTable(totalHT.ToString(), price);
                    CreateCellOnTable(totalHT.ToString(), price);
                    CreateCellOnTable(totalHT.ToString(), price);
                    document.Add(price);

                    //Close Document & Run File
                    document.Close();
                    Process.Start(@"cmd.exe", @"/c" + path);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void CreateCellOnTable(string name, Table table)
        {
            Cell cell = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph(name));
            table.AddCell(cell);
        }
    }
}
