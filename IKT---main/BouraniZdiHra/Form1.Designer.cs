namespace BouraniZdiHra
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbHraciPole = new System.Windows.Forms.PictureBox();
            this.pbPlatno = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHraciPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHraciPole
            // 
            this.pbHraciPole.BackColor = System.Drawing.Color.White;
            this.pbHraciPole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHraciPole.Location = new System.Drawing.Point(9, 10);
            this.pbHraciPole.Margin = new System.Windows.Forms.Padding(2);
            this.pbHraciPole.Name = "pbHraciPole";
            this.pbHraciPole.Size = new System.Drawing.Size(748, 461);
            this.pbHraciPole.TabIndex = 0;
            this.pbHraciPole.TabStop = false;
            // 
            // pbPlatno
            // 
            this.pbPlatno.Location = new System.Drawing.Point(9, 12);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(748, 459);
            this.pbPlatno.TabIndex = 1;
            this.pbPlatno.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "<----";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "<----------";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(427, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 69);
            this.button4.TabIndex = 5;
            this.button4.Text = "---------->";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(803, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 67);
            this.button5.TabIndex = 6;
            this.button5.Text = "RESTART";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 606);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbPlatno);
            this.Controls.Add(this.pbHraciPole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bourani zdi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHraciPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHraciPole;
        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

