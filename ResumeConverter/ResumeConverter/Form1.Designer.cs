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
            this.jsonHere1 = new System.Windows.Forms.TextBox();
            this.readKita1 = new System.Windows.Forms.Button();
            this.generateKita2 = new System.Windows.Forms.Button();
            this.jsonHere2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jsonHere1
            // 
            this.jsonHere1.Location = new System.Drawing.Point(97, 60);
            this.jsonHere1.Multiline = true;
            this.jsonHere1.Name = "jsonHere1";
            this.jsonHere1.Size = new System.Drawing.Size(192, 55);
            this.jsonHere1.TabIndex = 0;
            // 
            // readKita1
            // 
            this.readKita1.Location = new System.Drawing.Point(97, 31);
            this.readKita1.Name = "readKita1";
            this.readKita1.Size = new System.Drawing.Size(75, 23);
            this.readKita1.TabIndex = 2;
            this.readKita1.Text = "button1";
            this.readKita1.UseVisualStyleBackColor = true;
            this.readKita1.Click += new System.EventHandler(this.readKita1_Click);
            // 
            // generateKita2
            // 
            this.generateKita2.Location = new System.Drawing.Point(178, 31);
            this.generateKita2.Name = "generateKita2";
            this.generateKita2.Size = new System.Drawing.Size(75, 23);
            this.generateKita2.TabIndex = 3;
            this.generateKita2.Text = "generateMe1";
            this.generateKita2.UseVisualStyleBackColor = true;
            this.generateKita2.Click += new System.EventHandler(this.kahitAnoMuna2_Click);
            // 
            // jsonHere2
            // 
            this.jsonHere2.Location = new System.Drawing.Point(97, 121);
            this.jsonHere2.Multiline = true;
            this.jsonHere2.Name = "jsonHere2";
            this.jsonHere2.Size = new System.Drawing.Size(192, 61);
            this.jsonHere2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.jsonHere2);
            this.Controls.Add(this.generateKita2);
            this.Controls.Add(this.readKita1);
            this.Controls.Add(this.jsonHere1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jsonHere1;
        private System.Windows.Forms.Button readKita1;
        private System.Windows.Forms.Button generateKita2;
        private System.Windows.Forms.TextBox jsonHere2;
    }
}

