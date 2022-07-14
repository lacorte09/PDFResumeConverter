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
                string jsonReadFile;
                var readMe = new StreamReader(@"C:\Users\valen\O-O-P\ResumeConverter\Resume.json");              
                {
                    jsonReadFile = readMe.ReadToEnd();
                    jsonHere1.Text = jsonReadFile;

                }
                
            }
            catch (Exception)
            {

            }
        }

        private void kahitAnoMuna2_Click(object sender, EventArgs e)
        {
            Document docx = new Document();
            PdfWriter.GetInstance(docx, new FileStream(@"C:\Users\valen\O-O-P\ResumeConverter\Resume.pdf", FileMode.Create));
            docx.Open();
            Paragraph par1 = new Paragraph(jsonHere1.Text);
            docx.Add(par1);
            docx.Close();
            
        }
    }
}
