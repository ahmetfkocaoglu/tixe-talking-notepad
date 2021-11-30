namespace TalkingNotepad
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCik = new System.Windows.Forms.Button();
            this.btnDurak = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.84974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.15026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.Controls.Add(this.btnCik, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDurak, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDevam, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOku, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 329);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(314, 3);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(273, 114);
            this.btnCik.TabIndex = 4;
            this.btnCik.Text = "Çıkış";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDurak
            // 
            this.btnDurak.Location = new System.Drawing.Point(243, 3);
            this.btnDurak.Name = "btnDurak";
            this.btnDurak.Size = new System.Drawing.Size(65, 114);
            this.btnDurak.TabIndex = 3;
            this.btnDurak.Text = "Durakla";
            this.btnDurak.UseVisualStyleBackColor = true;
            this.btnDurak.Click += new System.EventHandler(this.btnDurak_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(175, 3);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(62, 114);
            this.btnDevam.TabIndex = 2;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(94, 3);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(75, 114);
            this.btnDur.TabIndex = 1;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(3, 3);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(85, 114);
            this.btnOku.TabIndex = 0;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 329);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Button btnDurak;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Button btnOku;
    }
}

