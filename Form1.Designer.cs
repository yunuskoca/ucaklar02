namespace ucaklar02
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ucak = new System.Windows.Forms.PictureBox();
            this.mermi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucak1 = new System.Windows.Forms.PictureBox();
            this.mermi1 = new System.Windows.Forms.PictureBox();
            this.lbCan = new System.Windows.Forms.Label();
            this.lbSure = new System.Windows.Forms.Label();
            this.ucak2 = new System.Windows.Forms.PictureBox();
            this.mermi2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ucak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucak1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi2)).BeginInit();
            this.SuspendLayout();
            // 
            // ucak
            // 
            this.ucak.Image = ((System.Drawing.Image)(resources.GetObject("ucak.Image")));
            this.ucak.Location = new System.Drawing.Point(268, 568);
            this.ucak.Name = "ucak";
            this.ucak.Size = new System.Drawing.Size(87, 90);
            this.ucak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucak.TabIndex = 0;
            this.ucak.TabStop = false;
            // 
            // mermi
            // 
            this.mermi.Image = ((System.Drawing.Image)(resources.GetObject("mermi.Image")));
            this.mermi.Location = new System.Drawing.Point(291, 522);
            this.mermi.Name = "mermi";
            this.mermi.Size = new System.Drawing.Size(40, 40);
            this.mermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi.TabIndex = 1;
            this.mermi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucak1
            // 
            this.ucak1.BackColor = System.Drawing.Color.Transparent;
            this.ucak1.Image = ((System.Drawing.Image)(resources.GetObject("ucak1.Image")));
            this.ucak1.Location = new System.Drawing.Point(75, 95);
            this.ucak1.Name = "ucak1";
            this.ucak1.Size = new System.Drawing.Size(87, 90);
            this.ucak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucak1.TabIndex = 2;
            this.ucak1.TabStop = false;
            // 
            // mermi1
            // 
            this.mermi1.Image = ((System.Drawing.Image)(resources.GetObject("mermi1.Image")));
            this.mermi1.Location = new System.Drawing.Point(95, 191);
            this.mermi1.Name = "mermi1";
            this.mermi1.Size = new System.Drawing.Size(40, 40);
            this.mermi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi1.TabIndex = 3;
            this.mermi1.TabStop = false;
            // 
            // lbCan
            // 
            this.lbCan.AutoSize = true;
            this.lbCan.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCan.ForeColor = System.Drawing.Color.White;
            this.lbCan.Location = new System.Drawing.Point(610, 12);
            this.lbCan.Name = "lbCan";
            this.lbCan.Size = new System.Drawing.Size(43, 29);
            this.lbCan.TabIndex = 4;
            this.lbCan.Text = "10";
            // 
            // lbSure
            // 
            this.lbSure.AutoSize = true;
            this.lbSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSure.ForeColor = System.Drawing.Color.White;
            this.lbSure.Location = new System.Drawing.Point(478, 9);
            this.lbSure.Name = "lbSure";
            this.lbSure.Size = new System.Drawing.Size(28, 29);
            this.lbSure.TabIndex = 5;
            this.lbSure.Text = "0";
            this.lbSure.Visible = false;
            // 
            // ucak2
            // 
            this.ucak2.BackColor = System.Drawing.Color.Transparent;
            this.ucak2.Image = ((System.Drawing.Image)(resources.GetObject("ucak2.Image")));
            this.ucak2.Location = new System.Drawing.Point(446, 95);
            this.ucak2.Name = "ucak2";
            this.ucak2.Size = new System.Drawing.Size(87, 90);
            this.ucak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucak2.TabIndex = 6;
            this.ucak2.TabStop = false;
            // 
            // mermi2
            // 
            this.mermi2.Image = ((System.Drawing.Image)(resources.GetObject("mermi2.Image")));
            this.mermi2.Location = new System.Drawing.Point(466, 191);
            this.mermi2.Name = "mermi2";
            this.mermi2.Size = new System.Drawing.Size(40, 40);
            this.mermi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi2.TabIndex = 7;
            this.mermi2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 50);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(526, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Can :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puan :";
            // 
            // lbPuan
            // 
            this.lbPuan.AutoSize = true;
            this.lbPuan.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPuan.ForeColor = System.Drawing.Color.White;
            this.lbPuan.Location = new System.Drawing.Point(85, 12);
            this.lbPuan.Name = "lbPuan";
            this.lbPuan.Size = new System.Drawing.Size(43, 29);
            this.lbPuan.TabIndex = 12;
            this.lbPuan.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(682, 708);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSure);
            this.Controls.Add(this.lbCan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucak);
            this.Controls.Add(this.ucak2);
            this.Controls.Add(this.mermi2);
            this.Controls.Add(this.ucak1);
            this.Controls.Add(this.mermi1);
            this.Controls.Add(this.mermi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BATTLE OF PLANES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ucak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucak1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ucak;
        private System.Windows.Forms.PictureBox mermi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ucak1;
        private System.Windows.Forms.PictureBox mermi1;
        private System.Windows.Forms.Label lbCan;
        private System.Windows.Forms.Label lbSure;
        private System.Windows.Forms.PictureBox ucak2;
        private System.Windows.Forms.PictureBox mermi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPuan;
    }
}

