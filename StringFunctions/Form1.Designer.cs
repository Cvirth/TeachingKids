namespace StringFunctions
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.szokozokSzama = new System.Windows.Forms.Label();
            this.sorokSzama = new System.Windows.Forms.Label();
            this.Szoszam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 754);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Az \'a\' betűk száma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // szokozokSzama
            // 
            this.szokozokSzama.AutoSize = true;
            this.szokozokSzama.Location = new System.Drawing.Point(463, 127);
            this.szokozokSzama.Name = "szokozokSzama";
            this.szokozokSzama.Size = new System.Drawing.Size(90, 13);
            this.szokozokSzama.TabIndex = 3;
            this.szokozokSzama.Text = "Szóközök száma:";
            this.szokozokSzama.Click += new System.EventHandler(this.label2_Click);
            // 
            // sorokSzama
            // 
            this.sorokSzama.AutoSize = true;
            this.sorokSzama.Location = new System.Drawing.Point(463, 175);
            this.sorokSzama.Name = "sorokSzama";
            this.sorokSzama.Size = new System.Drawing.Size(71, 13);
            this.sorokSzama.TabIndex = 4;
            this.sorokSzama.Text = "Sorok száma:";
            // 
            // Szoszam
            // 
            this.Szoszam.AutoSize = true;
            this.Szoszam.Location = new System.Drawing.Point(463, 219);
            this.Szoszam.Name = "Szoszam";
            this.Szoszam.Size = new System.Drawing.Size(79, 13);
            this.Szoszam.TabIndex = 5;
            this.Szoszam.Text = "Szavak száma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 796);
            this.Controls.Add(this.Szoszam);
            this.Controls.Add(this.sorokSzama);
            this.Controls.Add(this.szokozokSzama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label szokozokSzama;
        private System.Windows.Forms.Label sorokSzama;
        private System.Windows.Forms.Label Szoszam;
    }
}

