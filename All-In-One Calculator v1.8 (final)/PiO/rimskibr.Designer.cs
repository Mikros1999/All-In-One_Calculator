namespace PiO
{
    partial class rimskibr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "I      =    1\r\n\r\nII     =    2\r\n\r\nIII    =    3\r\n\r\nIV    =    4\r\n\r\nV     =    5\r\n" +
                "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 117);
            this.label2.TabIndex = 1;
            this.label2.Text = "VI    =   6\r\n\r\nVII   =   7\r\n\r\nVIII  =   8\r\n\r\nIX    =   9\r\n \r\nX     =   10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 91);
            this.label3.TabIndex = 2;
            this.label3.Text = "L   =   50\r\n\r\nC   =   100\r\n\r\nD   =   500\r\n\r\nM   =   1000";
            // 
            // rimskibr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rimskibr";
            this.Text = "Rimski brojevi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}