namespace ResumeConverter
{
    partial class PDFConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFConverter));
            this.nameHere = new System.Windows.Forms.TextBox();
            this.jsonConverter = new System.Windows.Forms.Button();
            this.generateKita2 = new System.Windows.Forms.Button();
            this.personalInfoHere = new System.Windows.Forms.TextBox();
            this.summaryHere = new System.Windows.Forms.TextBox();
            this.educationHere = new System.Windows.Forms.TextBox();
            this.experienceHere = new System.Windows.Forms.TextBox();
            this.skillsHere = new System.Windows.Forms.TextBox();
            this.achievementsHere = new System.Windows.Forms.TextBox();
            this.jsonClone = new System.Windows.Forms.TextBox();
            this.jsonReader = new System.Windows.Forms.Button();
            this.namePDF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameHere
            // 
            this.nameHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameHere.Location = new System.Drawing.Point(236, 44);
            this.nameHere.Multiline = true;
            this.nameHere.Name = "nameHere";
            this.nameHere.ReadOnly = true;
            this.nameHere.Size = new System.Drawing.Size(192, 25);
            this.nameHere.TabIndex = 0;
            this.nameHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jsonConverter
            // 
            this.jsonConverter.BackColor = System.Drawing.Color.Transparent;
            this.jsonConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jsonConverter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.jsonConverter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jsonConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.jsonConverter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jsonConverter.Location = new System.Drawing.Point(285, 15);
            this.jsonConverter.Name = "jsonConverter";
            this.jsonConverter.Size = new System.Drawing.Size(99, 23);
            this.jsonConverter.TabIndex = 2;
            this.jsonConverter.Text = "Convert Json File";
            this.jsonConverter.UseVisualStyleBackColor = false;
            this.jsonConverter.Click += new System.EventHandler(this.readKita1_Click);
            // 
            // generateKita2
            // 
            this.generateKita2.BackColor = System.Drawing.Color.Transparent;
            this.generateKita2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateKita2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateKita2.Location = new System.Drawing.Point(141, 606);
            this.generateKita2.Name = "generateKita2";
            this.generateKita2.Size = new System.Drawing.Size(159, 31);
            this.generateKita2.TabIndex = 3;
            this.generateKita2.Text = "Generate to PDF";
            this.generateKita2.UseVisualStyleBackColor = false;
            this.generateKita2.Click += new System.EventHandler(this.kahitAnoMuna2_Click);
            // 
            // personalInfoHere
            // 
            this.personalInfoHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personalInfoHere.Location = new System.Drawing.Point(236, 69);
            this.personalInfoHere.Multiline = true;
            this.personalInfoHere.Name = "personalInfoHere";
            this.personalInfoHere.ReadOnly = true;
            this.personalInfoHere.Size = new System.Drawing.Size(192, 44);
            this.personalInfoHere.TabIndex = 4;
            this.personalInfoHere.Tag = "fgdfgdfg";
            this.personalInfoHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // summaryHere
            // 
            this.summaryHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.summaryHere.Location = new System.Drawing.Point(236, 113);
            this.summaryHere.Multiline = true;
            this.summaryHere.Name = "summaryHere";
            this.summaryHere.ReadOnly = true;
            this.summaryHere.Size = new System.Drawing.Size(192, 127);
            this.summaryHere.TabIndex = 5;
            this.summaryHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // educationHere
            // 
            this.educationHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.educationHere.Location = new System.Drawing.Point(236, 240);
            this.educationHere.Multiline = true;
            this.educationHere.Name = "educationHere";
            this.educationHere.ReadOnly = true;
            this.educationHere.Size = new System.Drawing.Size(192, 159);
            this.educationHere.TabIndex = 6;
            this.educationHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // experienceHere
            // 
            this.experienceHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.experienceHere.Location = new System.Drawing.Point(236, 399);
            this.experienceHere.Multiline = true;
            this.experienceHere.Name = "experienceHere";
            this.experienceHere.ReadOnly = true;
            this.experienceHere.Size = new System.Drawing.Size(192, 40);
            this.experienceHere.TabIndex = 7;
            this.experienceHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // skillsHere
            // 
            this.skillsHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillsHere.Location = new System.Drawing.Point(236, 439);
            this.skillsHere.Multiline = true;
            this.skillsHere.Name = "skillsHere";
            this.skillsHere.ReadOnly = true;
            this.skillsHere.Size = new System.Drawing.Size(192, 61);
            this.skillsHere.TabIndex = 8;
            this.skillsHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // achievementsHere
            // 
            this.achievementsHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.achievementsHere.Location = new System.Drawing.Point(236, 500);
            this.achievementsHere.Multiline = true;
            this.achievementsHere.Name = "achievementsHere";
            this.achievementsHere.ReadOnly = true;
            this.achievementsHere.Size = new System.Drawing.Size(192, 61);
            this.achievementsHere.TabIndex = 9;
            this.achievementsHere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jsonClone
            // 
            this.jsonClone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jsonClone.Location = new System.Drawing.Point(12, 44);
            this.jsonClone.Multiline = true;
            this.jsonClone.Name = "jsonClone";
            this.jsonClone.ReadOnly = true;
            this.jsonClone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonClone.Size = new System.Drawing.Size(192, 517);
            this.jsonClone.TabIndex = 10;
            // 
            // jsonReader
            // 
            this.jsonReader.BackColor = System.Drawing.Color.Transparent;
            this.jsonReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jsonReader.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.jsonReader.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jsonReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.jsonReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jsonReader.Location = new System.Drawing.Point(58, 15);
            this.jsonReader.Name = "jsonReader";
            this.jsonReader.Size = new System.Drawing.Size(99, 23);
            this.jsonReader.TabIndex = 11;
            this.jsonReader.Text = "Read Json File";
            this.jsonReader.UseVisualStyleBackColor = false;
            this.jsonReader.Click += new System.EventHandler(this.button1_Click);
            // 
            // namePDF
            // 
            this.namePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePDF.Location = new System.Drawing.Point(12, 577);
            this.namePDF.Multiline = true;
            this.namePDF.Name = "namePDF";
            this.namePDF.Size = new System.Drawing.Size(416, 23);
            this.namePDF.TabIndex = 12;
            this.namePDF.Tag = "";
            // 
            // PDFConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(451, 649);
            this.Controls.Add(this.namePDF);
            this.Controls.Add(this.jsonReader);
            this.Controls.Add(this.jsonClone);
            this.Controls.Add(this.achievementsHere);
            this.Controls.Add(this.skillsHere);
            this.Controls.Add(this.experienceHere);
            this.Controls.Add(this.educationHere);
            this.Controls.Add(this.summaryHere);
            this.Controls.Add(this.personalInfoHere);
            this.Controls.Add(this.generateKita2);
            this.Controls.Add(this.jsonConverter);
            this.Controls.Add(this.nameHere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PDFConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "PDF Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameHere;
        private System.Windows.Forms.Button jsonConverter;
        private System.Windows.Forms.Button generateKita2;
        private System.Windows.Forms.TextBox personalInfoHere;
        private System.Windows.Forms.TextBox summaryHere;
        private System.Windows.Forms.TextBox educationHere;
        private System.Windows.Forms.TextBox experienceHere;
        private System.Windows.Forms.TextBox skillsHere;
        private System.Windows.Forms.TextBox achievementsHere;
        private System.Windows.Forms.TextBox jsonClone;
        private System.Windows.Forms.Button jsonReader;
        private System.Windows.Forms.TextBox namePDF;
    }
}

