
namespace Bergsen_BlackJack
{
    partial class StartSida
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
            this.Rubrik = new System.Windows.Forms.PictureBox();
            this.StartHärKnapp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rubrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartHärKnapp)).BeginInit();
            this.SuspendLayout();
            // 
            // Rubrik
            // 
            this.Rubrik.Image = global::Bergsen_BlackJack.Properties.Resources.Logo;
            this.Rubrik.Location = new System.Drawing.Point(230, 129);
            this.Rubrik.Name = "Rubrik";
            this.Rubrik.Size = new System.Drawing.Size(655, 89);
            this.Rubrik.TabIndex = 1;
            this.Rubrik.TabStop = false;
            this.Rubrik.Click += new System.EventHandler(this.StartaKnapp_Click);
            // 
            // StartHärKnapp
            // 
            this.StartHärKnapp.Image = global::Bergsen_BlackJack.Properties.Resources.StartaHärKnapp;
            this.StartHärKnapp.Location = new System.Drawing.Point(314, 337);
            this.StartHärKnapp.Name = "StartHärKnapp";
            this.StartHärKnapp.Size = new System.Drawing.Size(487, 103);
            this.StartHärKnapp.TabIndex = 0;
            this.StartHärKnapp.TabStop = false;
            this.StartHärKnapp.Click += new System.EventHandler(this.StartHärKnapp_Click);
            this.StartHärKnapp.MouseEnter += new System.EventHandler(this.StartHärKnapp_MouseEnter);
            this.StartHärKnapp.MouseLeave += new System.EventHandler(this.StartHärKnapp_MouseLeave);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1158, 640);
            this.Controls.Add(this.Rubrik);
            this.Controls.Add(this.StartHärKnapp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Rubrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartHärKnapp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartHärKnapp;
        private System.Windows.Forms.PictureBox Rubrik;
    }
}

