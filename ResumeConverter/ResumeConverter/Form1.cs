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

    public partial class PDFConverter : Form
    {
        public class Resume
        {
            public string Name { get; set; }
            public string Summary { get; set; }
            public string ContactNo { get; set; }
            public string EmailAdress { get; set; }
            public string Adress { get; set; }
            public string Year { get; set; }
            public string Course { get; set; }
            public string School { get; set; }
            public string Branch { get; set; }
            public string Adress1 { get; set; }
            public string Year1 { get; set; }
            public string School1 { get; set; }
            public string Strand { get; set; }
            public string Adress2 { get; set; }
            public string Year2 { get; set; }
            public string School2 { get; set; }
            public string Adress3 { get; set; }
            public string Year3 { get; set; }
            public string School3 { get; set; }
            public string Adress4 { get; set; }
            public string Experience { get; set; }
            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
            public string Skill4 { get; set; }
            public string Skill5 { get; set; }
            public string Achievement1 { get; set; }
            public string Achievement2 { get; set; }
            public string Achievement3 { get; set; }
            public string Achievement4 { get; set; }
        }        
        public PDFConverter()
        {
            InitializeComponent();
        }
        public void reset()
        {
            nameHere.Text = "";
            personalInfoHere.Text = "";
            summaryHere.Text = "";
            educationHere.Text = "";
            skillsHere.Text = "";
            experienceHere.Text = "";
            jsonClone.Text = "";
            achievementsHere.Text = "";
            namePDF.Text = "";
        }

        private void readKita1_Click(object sender, EventArgs e)
        {
            try
            {
                var pathOfJSONFile = @"C:\Users\valen\source\repos\PDFResumeConverter\ResumeConverter\ResumeConverter\resume.json";
                string jsonReadFile = File.ReadAllText(pathOfJSONFile);
                Resume convert = JsonConvert.DeserializeObject<Resume>(jsonReadFile);
                nameHere.Text = convert.Name;
                personalInfoHere.Text = convert.ContactNo + "\n" + convert.EmailAdress + "\n" + convert.Adress + "\n";
                summaryHere.Text = convert.Summary + "\n";
                educationHere.Text = convert.Year + " " + convert.Course + "\n" + convert.School + "\n" + convert.Branch + "\n" + convert.Adress1
                + "\n" + "\n" + convert.Year1 + " " + convert.Strand + "\n" + convert.School1 + "\n" + convert.Adress2 + "\n" + "\n" + convert.Year2 + " "
                + convert.School2 + "\n" + convert.Adress3 + "\n" + "\n" + convert.Year3 + " " + convert.School3 + "\n" + convert.Adress4 + "\n";
                skillsHere.Text = convert.Skill1 + "\n" + convert.Skill2 + "\n" + convert.Skill3 + "\n" + convert.Skill4 + "\n" + convert.Skill5 + "\n";
                experienceHere.Text = convert.Experience + "\n";
                achievementsHere.Text = convert.Achievement1 + "\n" + convert.Achievement2 + "\n" + convert.Achievement3 + "\n" + convert.Achievement4 + "\n";
            }
            catch (Exception)
            {
                MessageBox.Show("No files detected", "Error!");
            }

        }

        private void kahitAnoMuna2_Click(object sender, EventArgs e)
        {
            if (namePDF.Text == null || namePDF.Text == "")
            {
                MessageBox.Show("Name of File is Required!", "Error!");
                return;
            }
            else
            {
                Document docx = new Document();
                PdfWriter.GetInstance(docx, new FileStream(@"C:\Users\valen\source\repos\PDFResumeConverter\" + namePDF.Text + ".pdf", FileMode.Create));
                docx.Open();
                Chunk lineC = new Chunk("______________________________________________________________________________");
                Paragraph name = new Paragraph(nameHere.Text, FontFactory.GetFont("Times New Roman", 25, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph educ = new Paragraph("Education", FontFactory.GetFont("Times New Roman", 20, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph sum = new Paragraph(summaryHere.Text, FontFactory.GetFont("Times New Roman", 10, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph perin = new Paragraph(personalInfoHere.Text, FontFactory.GetFont("Times New Roman", 8, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph edu = new Paragraph(educationHere.Text, FontFactory.GetFont("Times New Roman", 12, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph skills = new Paragraph("Skills", FontFactory.GetFont("Times New Roman", 20, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph skill = new Paragraph(skillsHere.Text, FontFactory.GetFont("Times New Roman", 12, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph exps = new Paragraph("Experience", FontFactory.GetFont("Times New Roman", 20, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph exp = new Paragraph(experienceHere.Text, FontFactory.GetFont("Times New Roman", 12, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph achivs = new Paragraph("Achievements", FontFactory.GetFont("Times New Roman", 20, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                Paragraph achiv = new Paragraph(achievementsHere.Text, FontFactory.GetFont("Times New Roman", 12, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000000"))));
                perin.Alignment = Element.ALIGN_RIGHT;
                edu.Alignment = Element.ALIGN_CENTER;
                skill.Alignment = Element.ALIGN_CENTER;
                exp.Alignment = Element.ALIGN_CENTER;
                achiv.Alignment = Element.ALIGN_CENTER;
                docx.Add(name);
                docx.Add(perin);
                docx.Add(sum);
                docx.Add(lineC);
                docx.Add(educ);
                docx.Add(edu);
                docx.Add(lineC);
                docx.Add(skills);
                docx.Add(skill);
                docx.Add(lineC);
                docx.Add(exps);
                docx.Add(exp);
                docx.Add(lineC);
                docx.Add(achivs);
                docx.Add(achiv);
                docx.Close();
                MessageBox.Show("File Generated", "Success!");
                reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pathOfJSONFile = @"C:\Users\valen\source\repos\PDFResumeConverter\ResumeConverter\ResumeConverter\resume.json";
            string jsonReadFile = File.ReadAllText(pathOfJSONFile);
            jsonClone.Text = jsonReadFile;
        }

    }
}
