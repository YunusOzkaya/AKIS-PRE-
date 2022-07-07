namespace Akis3
{
    partial class Anasayfa
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
            this.btnAv = new System.Windows.Forms.Button();
            this.btnIntibak = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAv
            // 
            this.btnAv.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAv.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAv.ForeColor = System.Drawing.Color.Crimson;
            this.btnAv.Location = new System.Drawing.Point(9, 56);
            this.btnAv.Name = "btnAv";
            this.btnAv.Size = new System.Drawing.Size(303, 119);
            this.btnAv.TabIndex = 0;
            this.btnAv.Text = "STAJYER AV.";
            this.btnAv.UseVisualStyleBackColor = false;
            this.btnAv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIntibak
            // 
            this.btnIntibak.BackColor = System.Drawing.Color.AliceBlue;
            this.btnIntibak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntibak.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIntibak.ForeColor = System.Drawing.Color.Crimson;
            this.btnIntibak.Location = new System.Drawing.Point(9, 202);
            this.btnIntibak.Name = "btnIntibak";
            this.btnIntibak.Size = new System.Drawing.Size(303, 119);
            this.btnIntibak.TabIndex = 24;
            this.btnIntibak.Text = "İNTİBAK HESAPLA";
            this.btnIntibak.UseVisualStyleBackColor = false;
            this.btnIntibak.Click += new System.EventHandler(this.btnIntibak_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(345, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 119);
            this.button2.TabIndex = 0;
            this.button2.Text = "PERSONEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(345, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 119);
            this.button3.TabIndex = 0;
            this.button3.Text = "NÖBET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 372);
            this.Controls.Add(this.btnIntibak);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAv);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAv;
        private Button btnIntibak;
        private Button button2;
        private Button button3;
    }
}