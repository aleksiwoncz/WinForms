namespace WindowsFormsApp1
{
    partial class Exercise3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Wynik = new System.Windows.Forms.ListBox();
            this.CALCULATE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(125, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mean squared error..";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(136, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Results:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(256, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 49);
            this.label2.TabIndex = 21;
            // 
            // Wynik
            // 
            this.Wynik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wynik.FormattingEnabled = true;
            this.Wynik.ItemHeight = 23;
            this.Wynik.Location = new System.Drawing.Point(143, 236);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(383, 119);
            this.Wynik.TabIndex = 20;
            // 
            // CALCULATE
            // 
            this.CALCULATE.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CALCULATE.Location = new System.Drawing.Point(377, 122);
            this.CALCULATE.Name = "CALCULATE";
            this.CALCULATE.Size = new System.Drawing.Size(149, 53);
            this.CALCULATE.TabIndex = 19;
            this.CALCULATE.Text = "CALCULATE";
            this.CALCULATE.UseVisualStyleBackColor = true;
            this.CALCULATE.Click += new System.EventHandler(this.CALCULATE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 414);
            this.panel1.TabIndex = 17;
            // 
            // Zadanie3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.CALCULATE);
            this.Controls.Add(this.panel1);
            this.Name = "Zadanie3";
            this.Text = "Zadanie3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Wynik;
        private System.Windows.Forms.Button CALCULATE;
        private System.Windows.Forms.Panel panel1;
    }
}