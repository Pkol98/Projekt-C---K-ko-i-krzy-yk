
namespace KK_01
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wyjPrzycisk = new System.Windows.Forms.Button();
            this.aPrzycisk = new System.Windows.Forms.Button();
            this.resPrzycisk = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.wyjPrzycisk);
            this.panel2.Controls.Add(this.aPrzycisk);
            this.panel2.Controls.Add(this.resPrzycisk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 100);
            this.panel2.TabIndex = 1;
            // 
            // wyjPrzycisk
            // 
            this.wyjPrzycisk.Location = new System.Drawing.Point(348, 52);
            this.wyjPrzycisk.Name = "wyjPrzycisk";
            this.wyjPrzycisk.Size = new System.Drawing.Size(140, 40);
            this.wyjPrzycisk.TabIndex = 2;
            this.wyjPrzycisk.Text = "Wyjście";
            this.wyjPrzycisk.UseVisualStyleBackColor = true;
            this.wyjPrzycisk.Click += new System.EventHandler(this.wyjPrzycisk_Click);
            // 
            // aPrzycisk
            // 
            this.aPrzycisk.Location = new System.Drawing.Point(348, 6);
            this.aPrzycisk.Name = "aPrzycisk";
            this.aPrzycisk.Size = new System.Drawing.Size(140, 40);
            this.aPrzycisk.TabIndex = 1;
            this.aPrzycisk.Text = "Więcej";
            this.aPrzycisk.UseVisualStyleBackColor = true;
            this.aPrzycisk.Click += new System.EventHandler(this.aPrzycisk_Click);
            // 
            // resPrzycisk
            // 
            this.resPrzycisk.Location = new System.Drawing.Point(12, 6);
            this.resPrzycisk.Name = "resPrzycisk";
            this.resPrzycisk.Size = new System.Drawing.Size(120, 82);
            this.resPrzycisk.TabIndex = 0;
            this.resPrzycisk.Text = "Reset";
            this.resPrzycisk.UseVisualStyleBackColor = true;
            this.resPrzycisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 647);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 647);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KołkoiKrzyzyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button wyjPrzycisk;
        private System.Windows.Forms.Button aPrzycisk;
        private System.Windows.Forms.Button resPrzycisk;
        private System.Windows.Forms.Label label1;
    }
}

