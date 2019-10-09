namespace MayTinhDonGian
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soA = new System.Windows.Forms.TextBox();
            this.soB = new System.Windows.Forms.TextBox();
            this.Kq = new System.Windows.Forms.TextBox();
            this.Cong = new System.Windows.Forms.Button();
            this.Chia = new System.Windows.Forms.Button();
            this.Tru = new System.Windows.Forms.Button();
            this.Nhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(88, 30);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(100, 20);
            this.soA.TabIndex = 1;
            this.soA.Text = "0";
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(88, 76);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(100, 20);
            this.soB.TabIndex = 2;
            this.soB.Text = "0";
            // 
            // Kq
            // 
            this.Kq.Location = new System.Drawing.Point(88, 118);
            this.Kq.Name = "Kq";
            this.Kq.Size = new System.Drawing.Size(100, 20);
            this.Kq.TabIndex = 3;
            this.Kq.Text = "0";
            // 
            // Cong
            // 
            this.Cong.Location = new System.Drawing.Point(76, 159);
            this.Cong.Name = "Cong";
            this.Cong.Size = new System.Drawing.Size(44, 23);
            this.Cong.TabIndex = 6;
            this.Cong.Text = "+";
            this.Cong.UseVisualStyleBackColor = true;
            this.Cong.Click += new System.EventHandler(this.Cong_Click);
            // 
            // Chia
            // 
            this.Chia.Location = new System.Drawing.Point(144, 201);
            this.Chia.Name = "Chia";
            this.Chia.Size = new System.Drawing.Size(44, 23);
            this.Chia.TabIndex = 7;
            this.Chia.Text = "/";
            this.Chia.UseVisualStyleBackColor = true;
            this.Chia.Click += new System.EventHandler(this.Chia_Click);
            // 
            // Tru
            // 
            this.Tru.Location = new System.Drawing.Point(144, 159);
            this.Tru.Name = "Tru";
            this.Tru.Size = new System.Drawing.Size(44, 23);
            this.Tru.TabIndex = 8;
            this.Tru.Text = "-";
            this.Tru.UseVisualStyleBackColor = true;
            this.Tru.Click += new System.EventHandler(this.Tru_Click);
            // 
            // Nhan
            // 
            this.Nhan.Location = new System.Drawing.Point(76, 201);
            this.Nhan.Name = "Nhan";
            this.Nhan.Size = new System.Drawing.Size(44, 23);
            this.Nhan.TabIndex = 9;
            this.Nhan.Text = "*";
            this.Nhan.UseVisualStyleBackColor = true;
            this.Nhan.Click += new System.EventHandler(this.Nhan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Nhan);
            this.Controls.Add(this.Tru);
            this.Controls.Add(this.Chia);
            this.Controls.Add(this.Cong);
            this.Controls.Add(this.Kq);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.soA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Máy tính cơ bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soA;
        private System.Windows.Forms.TextBox soB;
        private System.Windows.Forms.TextBox Kq;
        private System.Windows.Forms.Button Cong;
        private System.Windows.Forms.Button Chia;
        private System.Windows.Forms.Button Tru;
        private System.Windows.Forms.Button Nhan;
    }
}

