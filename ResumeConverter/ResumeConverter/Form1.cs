using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ResumeConverter
{
    public class Resume
    {
        public string Name { get; set; }
        public string[] PersonalInfo { get; set; }
        public string Summary { get; set; }
        public string[] Education { get; set; }
        public string Experience { get; set; }
        public string[] Skills { get; set; }
        public string[] Achievements { get; set; }

    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void readKita1_Click(object sender, EventArgs e)
        {
            try
            {
                var pathOfJSONFile = @"C:\Users\dillon\source\repos\PDFResumeConverter\ResumeConverter\ResumeConverter\resume.json";
                string jsonReadFile = File.ReadAllText(pathOfJSONFile);

                Resume convert = JsonConvert.DeserializeObject<Resume>(jsonReadFile);
                nameHere.Text = convert.Name;
            }
            catch (Exception)
            {

            }

        }        
        
        private void kahitAnoMuna2_Click(object sender, EventArgs e)
        {
            Document docx = new Document();
            PdfWriter.GetInstance(docx, new FileStream(@"C:\Users\dillon\source\repos\PDFResumeConverter\Resume.pdf", FileMode.Create));
            docx.Open();
            Chunk lineChunk = new Chunk("______________________________________________________________________________");
            Paragraph par1 = new Paragraph(nameHere.Text, FontFactory.GetFont("Times New Roman", 30, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
            Paragraph par2 = new Paragraph("Education", FontFactory.GetFont("Times New Roman", 20, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
            Paragraph par3 = new Paragraph(personalInfoHere.Text, FontFactory.GetFont("Times New Roman", 10, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));


            docx.Add(par1);
            docx.Add(lineChunk);
            docx.Add(par2);
            docx.Add(par3);
            docx.Close();
            
        }

    }
}
