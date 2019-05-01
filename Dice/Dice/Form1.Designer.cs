namespace Dice
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
            this.btn_rolldice = new System.Windows.Forms.Button();
            this.lbl_die_1 = new System.Windows.Forms.Label();
            this.lbl_die_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rolldice
            // 
            this.btn_rolldice.BackColor = System.Drawing.SystemColors.Control;
            this.btn_rolldice.Location = new System.Drawing.Point(185, 247);
            this.btn_rolldice.Name = "btn_rolldice";
            this.btn_rolldice.Size = new System.Drawing.Size(341, 53);
            this.btn_rolldice.TabIndex = 5;
            this.btn_rolldice.Text = "Roll the dice!";
            this.btn_rolldice.UseVisualStyleBackColor = false;
            this.btn_rolldice.Click += new System.EventHandler(this.btn_rolldice_Click);
            // 
            // lbl_die_1
            // 
            this.lbl_die_1.Location = new System.Drawing.Point(133, 48);
            this.lbl_die_1.Name = "lbl_die_1";
            this.lbl_die_1.Size = new System.Drawing.Size(228, 196);
            this.lbl_die_1.TabIndex = 6;
            this.lbl_die_1.Text = "Dice 1";
            // 
            // lbl_die_2
            // 
            this.lbl_die_2.Location = new System.Drawing.Point(367, 48);
            this.lbl_die_2.Name = "lbl_die_2";
            this.lbl_die_2.Size = new System.Drawing.Size(228, 196);
            this.lbl_die_2.TabIndex = 7;
            this.lbl_die_2.Text = "Dice 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 433);
            this.Controls.Add(this.lbl_die_2);
            this.Controls.Add(this.lbl_die_1);
            this.Controls.Add(this.btn_rolldice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_rolldice;
        private System.Windows.Forms.Label lbl_die_1;
        private System.Windows.Forms.Label lbl_die_2;
    }
}

