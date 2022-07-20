namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCelc = new System.Windows.Forms.TextBox();
            this.textBoxFahre = new System.Windows.Forms.TextBox();
            this.convertbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxhide = new System.Windows.Forms.CheckBox();
            this.buttonzmiana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCelc
            // 
            this.textBoxCelc.Location = new System.Drawing.Point(660, 235);
            this.textBoxCelc.Multiline = true;
            this.textBoxCelc.Name = "textBoxCelc";
            this.textBoxCelc.PlaceholderText = "Celc";
            this.textBoxCelc.Size = new System.Drawing.Size(216, 28);
            this.textBoxCelc.TabIndex = 2;
            this.textBoxCelc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFahre
            // 
            this.textBoxFahre.Location = new System.Drawing.Point(660, 432);
            this.textBoxFahre.Multiline = true;
            this.textBoxFahre.Name = "textBoxFahre";
            this.textBoxFahre.PlaceholderText = "Fahre";
            this.textBoxFahre.ReadOnly = true;
            this.textBoxFahre.Size = new System.Drawing.Size(216, 28);
            this.textBoxFahre.TabIndex = 3;
            this.textBoxFahre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFahre.TextChanged += new System.EventHandler(this.textBoxFahre_TextChanged);
            // 
            // convertbutton
            // 
            this.convertbutton.Location = new System.Drawing.Point(678, 521);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(181, 72);
            this.convertbutton.TabIndex = 4;
            this.convertbutton.Text = "Convert!";
            this.convertbutton.UseVisualStyleBackColor = true;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ostanie konwercje:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBoxhide
            // 
            this.checkBoxhide.AutoSize = true;
            this.checkBoxhide.Location = new System.Drawing.Point(12, 125);
            this.checkBoxhide.Name = "checkBoxhide";
            this.checkBoxhide.Size = new System.Drawing.Size(137, 19);
            this.checkBoxhide.TabIndex = 7;
            this.checkBoxhide.Text = "Hide last convertions";
            this.checkBoxhide.UseVisualStyleBackColor = true;
            this.checkBoxhide.CheckedChanged += new System.EventHandler(this.checkBoxhide_CheckedChanged);
            // 
            // buttonzmiana
            // 
            this.buttonzmiana.Location = new System.Drawing.Point(727, 297);
            this.buttonzmiana.Name = "buttonzmiana";
            this.buttonzmiana.Size = new System.Drawing.Size(84, 71);
            this.buttonzmiana.TabIndex = 8;
            this.buttonzmiana.Text = "⇅";
            this.buttonzmiana.UseVisualStyleBackColor = true;
            this.buttonzmiana.Click += new System.EventHandler(this.buttonzmiana_click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 151);
            this.label1.TabIndex = 10;
            this.label1.Text = "Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open errors file";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 824);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonzmiana);
            this.Controls.Add(this.checkBoxhide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertbutton);
            this.Controls.Add(this.textBoxFahre);
            this.Controls.Add(this.textBoxCelc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxCelc;
        private TextBox textBoxFahre;
        private Button convertbutton;
        private Label label3;
        private CheckBox checkBoxhide;
        private Button buttonzmiana;
        private Label label1;
        private Button button1;
    }
}