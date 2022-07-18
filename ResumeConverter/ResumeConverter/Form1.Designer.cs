namespace ResumeConverter
{
    partial class Form1
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
            this.nameHere = new System.Windows.Forms.TextBox();
            this.readerbtn1 = new System.Windows.Forms.Button();
            this.generateKita2 = new System.Windows.Forms.Button();
            this.personalInfoHere = new System.Windows.Forms.TextBox();
            this.summaryHere = new System.Windows.Forms.TextBox();
            this.educationHere = new System.Windows.Forms.TextBox();
            this.experienceHere = new System.Windows.Forms.TextBox();
            this.skillsHere = new System.Windows.Forms.TextBox();
            this.achievementsHere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameHere
            // 
            this.nameHere.Location = new System.Drawing.Point(97, 60);
            this.nameHere.Multiline = true;
            this.nameHere.Name = "nameHere";
            this.nameHere.Size = new System.Drawing.Size(192, 55);
            this.nameHere.TabIndex = 0;
            // 
            // readerbtn1
            // 
            this.readerbtn1.Location = new System.Drawing.Point(97, 31);
            this.readerbtn1.Name = "readerbtn1";
            this.readerbtn1.Size = new System.Drawing.Size(99, 23);
            this.readerbtn1.TabIndex = 2;
            this.readerbtn1.Text = "Read Json File";
            this.readerbtn1.UseVisualStyleBackColor = true;
            this.readerbtn1.Click += new System.EventHandler(this.readKita1_Click);
            // 
            // generateKita2
            // 
            this.generateKita2.Location = new System.Drawing.Point(302, 31);
            this.generateKita2.Name = "generateKita2";
            this.generateKita2.Size = new System.Drawing.Size(75, 23);
            this.generateKita2.TabIndex = 3;
            this.generateKita2.Text = "generateMe1";
            this.generateKita2.UseVisualStyleBackColor = true;
            this.generateKita2.Click += new System.EventHandler(this.kahitAnoMuna2_Click);
            // 
            // personalInfoHere
            // 
            this.personalInfoHere.Location = new System.Drawing.Point(97, 121);
            this.personalInfoHere.Multiline = true;
            this.personalInfoHere.Name = "personalInfoHere";
            this.personalInfoHere.Size = new System.Drawing.Size(192, 61);
            this.personalInfoHere.TabIndex = 4;
            // 
            // summaryHere
            // 
            this.summaryHere.Location = new System.Drawing.Point(97, 188);
            this.summaryHere.Multiline = true;
            this.summaryHere.Name = "summaryHere";
            this.summaryHere.Size = new System.Drawing.Size(192, 61);
            this.summaryHere.TabIndex = 5;
            // 
            // educationHere
            // 
            this.educationHere.Location = new System.Drawing.Point(295, 60);
            this.educationHere.Multiline = true;
            this.educationHere.Name = "educationHere";
            this.educationHere.Size = new System.Drawing.Size(192, 61);
            this.educationHere.TabIndex = 6;
            // 
            // experienceHere
            // 
            this.experienceHere.Location = new System.Drawing.Point(295, 127);
            this.experienceHere.Multiline = true;
            this.experienceHere.Name = "experienceHere";
            this.experienceHere.Size = new System.Drawing.Size(192, 61);
            this.experienceHere.TabIndex = 7;
            // 
            // skillsHere
            // 
            this.skillsHere.Location = new System.Drawing.Point(295, 188);
            this.skillsHere.Multiline = true;
            this.skillsHere.Name = "skillsHere";
            this.skillsHere.Size = new System.Drawing.Size(192, 61);
            this.skillsHere.TabIndex = 8;
            // 
            // achievementsHere
            // 
            this.achievementsHere.Location = new System.Drawing.Point(493, 60);
            this.achievementsHere.Multiline = true;
            this.achievementsHere.Name = "achievementsHere";
            this.achievementsHere.Size = new System.Drawing.Size(192, 61);
            this.achievementsHere.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.achievementsHere);
            this.Controls.Add(this.skillsHere);
            this.Controls.Add(this.experienceHere);
            this.Controls.Add(this.educationHere);
            this.Controls.Add(this.summaryHere);
            this.Controls.Add(this.personalInfoHere);
            this.Controls.Add(this.generateKita2);
            this.Controls.Add(this.readerbtn1);
            this.Controls.Add(this.nameHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameHere;
        private System.Windows.Forms.Button readerbtn1;
        private System.Windows.Forms.Button generateKita2;
        private System.Windows.Forms.TextBox personalInfoHere;
        private System.Windows.Forms.TextBox summaryHere;
        private System.Windows.Forms.TextBox educationHere;
        private System.Windows.Forms.TextBox experienceHere;
        private System.Windows.Forms.TextBox skillsHere;
        private System.Windows.Forms.TextBox achievementsHere;
    }
}

