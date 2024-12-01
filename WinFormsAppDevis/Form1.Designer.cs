namespace WinFormsAppDevis
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
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau Devis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 101);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(271, 74);
            this.info.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vos Cordonnées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cordonnées Client";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(517, 192);
            this.client.Multiline = true;
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(271, 74);
            this.client.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titre du devis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Désignation ";
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(12, 367);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(213, 27);
            this.designation.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Qte";
            // 
            // qte
            // 
            this.qte.Location = new System.Drawing.Point(586, 367);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(202, 27);
            this.qte.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prix";
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(272, 367);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(253, 27);
            this.prix.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(284, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Générer le devis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Générateur Devis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox info;
        private Label label2;
        private Label label3;
        private TextBox client;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox designation;
        private Label label6;
        private TextBox qte;
        private Label label7;
        private TextBox prix;
        private Button button1;
    }
}