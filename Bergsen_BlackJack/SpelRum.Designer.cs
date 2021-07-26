
namespace Bergsen_BlackJack
{
    partial class SpelRum
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
            this.Pengar = new System.Windows.Forms.Label();
            this.Betta500 = new System.Windows.Forms.Button();
            this.Betta250 = new System.Windows.Forms.Button();
            this.Betta100 = new System.Windows.Forms.Button();
            this.HitKnapp = new System.Windows.Forms.Button();
            this.StandKnapp = new System.Windows.Forms.Button();
            this.SpelareSumma = new System.Windows.Forms.Label();
            this.DealerSumma = new System.Windows.Forms.Label();
            this.KortBild = new System.Windows.Forms.PictureBox();
            this.KortNummer = new System.Windows.Forms.Label();
            this.Pratbubbla = new System.Windows.Forms.PictureBox();
            this.TextIPratbubbla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KortBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pratbubbla)).BeginInit();
            this.SuspendLayout();
            // 
            // Pengar
            // 
            this.Pengar.AutoSize = true;
            this.Pengar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pengar.Location = new System.Drawing.Point(194, 760);
            this.Pengar.MaximumSize = new System.Drawing.Size(200, 399);
            this.Pengar.Name = "Pengar";
            this.Pengar.Size = new System.Drawing.Size(109, 39);
            this.Pengar.TabIndex = 0;
            this.Pengar.Text = "label1";
            // 
            // Betta500
            // 
            this.Betta500.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Betta500.BackColor = System.Drawing.SystemColors.Info;
            this.Betta500.Location = new System.Drawing.Point(392, 760);
            this.Betta500.Name = "Betta500";
            this.Betta500.Size = new System.Drawing.Size(151, 39);
            this.Betta500.TabIndex = 1;
            this.Betta500.Text = "Bet 500 kr";
            this.Betta500.UseVisualStyleBackColor = false;
            this.Betta500.Click += new System.EventHandler(this.Bet500_Click);
            // 
            // Betta250
            // 
            this.Betta250.BackColor = System.Drawing.SystemColors.Info;
            this.Betta250.Location = new System.Drawing.Point(561, 760);
            this.Betta250.Name = "Betta250";
            this.Betta250.Size = new System.Drawing.Size(151, 39);
            this.Betta250.TabIndex = 2;
            this.Betta250.Text = "Bet 250 kr";
            this.Betta250.UseVisualStyleBackColor = false;
            this.Betta250.Click += new System.EventHandler(this.Bet250_Click);
            // 
            // Betta100
            // 
            this.Betta100.BackColor = System.Drawing.SystemColors.Info;
            this.Betta100.Cursor = System.Windows.Forms.Cursors.Default;
            this.Betta100.Location = new System.Drawing.Point(727, 760);
            this.Betta100.Name = "Betta100";
            this.Betta100.Size = new System.Drawing.Size(151, 39);
            this.Betta100.TabIndex = 3;
            this.Betta100.Text = "Bet 100 kr";
            this.Betta100.UseVisualStyleBackColor = false;
            this.Betta100.Click += new System.EventHandler(this.Bet100_Click);
            // 
            // HitKnapp
            // 
            this.HitKnapp.BackColor = System.Drawing.SystemColors.Info;
            this.HitKnapp.Location = new System.Drawing.Point(193, 642);
            this.HitKnapp.Name = "HitKnapp";
            this.HitKnapp.Size = new System.Drawing.Size(110, 40);
            this.HitKnapp.TabIndex = 4;
            this.HitKnapp.Text = "Hit";
            this.HitKnapp.UseVisualStyleBackColor = false;
            this.HitKnapp.Click += new System.EventHandler(this.HitKnapp_Click);
            // 
            // StandKnapp
            // 
            this.StandKnapp.BackColor = System.Drawing.SystemColors.Info;
            this.StandKnapp.Location = new System.Drawing.Point(193, 700);
            this.StandKnapp.Name = "StandKnapp";
            this.StandKnapp.Size = new System.Drawing.Size(110, 40);
            this.StandKnapp.TabIndex = 5;
            this.StandKnapp.Text = "Stand";
            this.StandKnapp.UseVisualStyleBackColor = false;
            this.StandKnapp.Click += new System.EventHandler(this.StandKnapp_Click);
            // 
            // SpelareSumma
            // 
            this.SpelareSumma.AutoSize = true;
            this.SpelareSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpelareSumma.Location = new System.Drawing.Point(615, 636);
            this.SpelareSumma.MaximumSize = new System.Drawing.Size(200, 399);
            this.SpelareSumma.Name = "SpelareSumma";
            this.SpelareSumma.Size = new System.Drawing.Size(109, 39);
            this.SpelareSumma.TabIndex = 6;
            this.SpelareSumma.Text = "label2";
            // 
            // DealerSumma
            // 
            this.DealerSumma.AutoSize = true;
            this.DealerSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerSumma.Location = new System.Drawing.Point(615, 521);
            this.DealerSumma.MaximumSize = new System.Drawing.Size(200, 399);
            this.DealerSumma.Name = "DealerSumma";
            this.DealerSumma.Size = new System.Drawing.Size(109, 39);
            this.DealerSumma.TabIndex = 7;
            this.DealerSumma.Text = "label3";
            // 
            // KortBild
            // 
            this.KortBild.Location = new System.Drawing.Point(193, 362);
            this.KortBild.Name = "KortBild";
            this.KortBild.Size = new System.Drawing.Size(142, 198);
            this.KortBild.TabIndex = 9;
            this.KortBild.TabStop = false;
            // 
            // KortNummer
            // 
            this.KortNummer.AutoSize = true;
            this.KortNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KortNummer.Location = new System.Drawing.Point(297, 373);
            this.KortNummer.Name = "KortNummer";
            this.KortNummer.Size = new System.Drawing.Size(57, 20);
            this.KortNummer.TabIndex = 10;
            this.KortNummer.Text = "label5";
            // 
            // Pratbubbla
            // 
            this.Pratbubbla.Image = global::Bergsen_BlackJack.Properties.Resources.Chattbubbla;
            this.Pratbubbla.Location = new System.Drawing.Point(832, 24);
            this.Pratbubbla.Name = "Pratbubbla";
            this.Pratbubbla.Size = new System.Drawing.Size(380, 252);
            this.Pratbubbla.TabIndex = 11;
            this.Pratbubbla.TabStop = false;
            // 
            // TextIPratbubbla
            // 
            this.TextIPratbubbla.AutoSize = true;
            this.TextIPratbubbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIPratbubbla.Location = new System.Drawing.Point(964, 135);
            this.TextIPratbubbla.MaximumSize = new System.Drawing.Size(200, 399);
            this.TextIPratbubbla.Name = "TextIPratbubbla";
            this.TextIPratbubbla.Size = new System.Drawing.Size(58, 22);
            this.TextIPratbubbla.TabIndex = 12;
            this.TextIPratbubbla.Text = "label6";
            // 
            // SpelRum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bergsen_BlackJack.Properties.Resources.BGImageRezised;
            this.ClientSize = new System.Drawing.Size(1356, 866);
            this.Controls.Add(this.TextIPratbubbla);
            this.Controls.Add(this.Pratbubbla);
            this.Controls.Add(this.KortNummer);
            this.Controls.Add(this.KortBild);
            this.Controls.Add(this.DealerSumma);
            this.Controls.Add(this.SpelareSumma);
            this.Controls.Add(this.StandKnapp);
            this.Controls.Add(this.HitKnapp);
            this.Controls.Add(this.Betta100);
            this.Controls.Add(this.Betta250);
            this.Controls.Add(this.Betta500);
            this.Controls.Add(this.Pengar);
            this.Name = "SpelRum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KortBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pratbubbla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pengar;
        private System.Windows.Forms.Button Betta500;
        private System.Windows.Forms.Button Betta250;
        private System.Windows.Forms.Button Betta100;
        private System.Windows.Forms.Button HitKnapp;
        private System.Windows.Forms.Button StandKnapp;
        private System.Windows.Forms.Label SpelareSumma;
        private System.Windows.Forms.Label DealerSumma;
        private System.Windows.Forms.PictureBox KortBild;
        private System.Windows.Forms.Label KortNummer;
        private System.Windows.Forms.PictureBox Pratbubbla;
        private System.Windows.Forms.Label TextIPratbubbla;
    }
}