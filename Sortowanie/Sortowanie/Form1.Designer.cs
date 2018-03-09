namespace Sortowanie
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
            this.losujKr = new System.Windows.Forms.Button();
            this.losujSr = new System.Windows.Forms.Button();
            this.losujDl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sPrW = new System.Windows.Forms.Button();
            this.sWyPol = new System.Windows.Forms.Button();
            this.czasSPW = new System.Windows.Forms.TextBox();
            this.czasSZP = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sWyPolRow = new System.Windows.Forms.Button();
            this.czasSZPR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // losujKr
            // 
            this.losujKr.Location = new System.Drawing.Point(12, 101);
            this.losujKr.Name = "losujKr";
            this.losujKr.Size = new System.Drawing.Size(349, 29);
            this.losujKr.TabIndex = 1;
            this.losujKr.Text = "Losuj krótką";
            this.losujKr.UseVisualStyleBackColor = true;
            this.losujKr.Click += new System.EventHandler(this.losujKr_Click);
            // 
            // losujSr
            // 
            this.losujSr.Location = new System.Drawing.Point(367, 101);
            this.losujSr.Name = "losujSr";
            this.losujSr.Size = new System.Drawing.Size(349, 29);
            this.losujSr.TabIndex = 2;
            this.losujSr.Text = "Losuj średnią";
            this.losujSr.UseVisualStyleBackColor = true;
            this.losujSr.Click += new System.EventHandler(this.losujSr_Click);
            // 
            // losujDl
            // 
            this.losujDl.Location = new System.Drawing.Point(722, 101);
            this.losujDl.Name = "losujDl";
            this.losujDl.Size = new System.Drawing.Size(349, 29);
            this.losujDl.TabIndex = 3;
            this.losujDl.Text = "Losuj długą";
            this.losujDl.UseVisualStyleBackColor = true;
            this.losujDl.Click += new System.EventHandler(this.losujDl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1060, 83);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 136);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(350, 258);
            this.textBox2.TabIndex = 5;
            // 
            // sPrW
            // 
            this.sPrW.Enabled = false;
            this.sPrW.Location = new System.Drawing.Point(12, 400);
            this.sPrW.Name = "sPrW";
            this.sPrW.Size = new System.Drawing.Size(349, 49);
            this.sPrW.TabIndex = 6;
            this.sPrW.Text = "Sortuj przez wybór";
            this.sPrW.UseVisualStyleBackColor = true;
            this.sPrW.Click += new System.EventHandler(this.sPrW_Click);
            // 
            // sWyPol
            // 
            this.sWyPol.Enabled = false;
            this.sWyPol.Location = new System.Drawing.Point(367, 400);
            this.sWyPol.Name = "sWyPol";
            this.sWyPol.Size = new System.Drawing.Size(349, 49);
            this.sWyPol.TabIndex = 7;
            this.sWyPol.Text = "Sortuj z podziałem";
            this.sWyPol.UseVisualStyleBackColor = true;
            this.sWyPol.Click += new System.EventHandler(this.sWyPol_Click);
            // 
            // czasSPW
            // 
            this.czasSPW.Location = new System.Drawing.Point(13, 456);
            this.czasSPW.Name = "czasSPW";
            this.czasSPW.ReadOnly = true;
            this.czasSPW.Size = new System.Drawing.Size(348, 20);
            this.czasSPW.TabIndex = 8;
            // 
            // czasSZP
            // 
            this.czasSZP.Location = new System.Drawing.Point(367, 456);
            this.czasSZP.Name = "czasSZP";
            this.czasSZP.ReadOnly = true;
            this.czasSZP.Size = new System.Drawing.Size(348, 20);
            this.czasSZP.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(368, 136);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(349, 258);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(723, 136);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(349, 258);
            this.textBox4.TabIndex = 17;
            // 
            // sWyPolRow
            // 
            this.sWyPolRow.Enabled = false;
            this.sWyPolRow.Location = new System.Drawing.Point(722, 400);
            this.sWyPolRow.Name = "sWyPolRow";
            this.sWyPolRow.Size = new System.Drawing.Size(349, 49);
            this.sWyPolRow.TabIndex = 18;
            this.sWyPolRow.Text = "Sortuj z podziałem rówolegle";
            this.sWyPolRow.UseVisualStyleBackColor = true;
            this.sWyPolRow.Click += new System.EventHandler(this.sWyPolRow_Click);
            // 
            // czasSZPR
            // 
            this.czasSZPR.Location = new System.Drawing.Point(721, 455);
            this.czasSZPR.Name = "czasSZPR";
            this.czasSZPR.ReadOnly = true;
            this.czasSZPR.Size = new System.Drawing.Size(348, 20);
            this.czasSZPR.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 489);
            this.Controls.Add(this.czasSZPR);
            this.Controls.Add(this.sWyPolRow);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.czasSZP);
            this.Controls.Add(this.czasSPW);
            this.Controls.Add(this.sWyPol);
            this.Controls.Add(this.sPrW);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.losujDl);
            this.Controls.Add(this.losujSr);
            this.Controls.Add(this.losujKr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button losujKr;
        private System.Windows.Forms.Button losujSr;
        private System.Windows.Forms.Button losujDl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sPrW;
        private System.Windows.Forms.Button sWyPol;
        private System.Windows.Forms.TextBox czasSPW;
        private System.Windows.Forms.TextBox czasSZP;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button sWyPolRow;
        private System.Windows.Forms.TextBox czasSZPR;
    }
}

