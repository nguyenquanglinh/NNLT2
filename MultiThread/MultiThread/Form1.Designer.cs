namespace MultiThread
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
            this.components = new System.ComponentModel.Container();
            this.panelBoardControls = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBoardThread = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBoardControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoardControls
            // 
            this.panelBoardControls.Controls.Add(this.comboBox1);
            this.panelBoardControls.Controls.Add(this.label3);
            this.panelBoardControls.Controls.Add(this.btnOk);
            this.panelBoardControls.Controls.Add(this.txtB);
            this.panelBoardControls.Controls.Add(this.txtA);
            this.panelBoardControls.Controls.Add(this.label2);
            this.panelBoardControls.Controls.Add(this.label1);
            this.panelBoardControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBoardControls.Location = new System.Drawing.Point(0, 0);
            this.panelBoardControls.Name = "panelBoardControls";
            this.panelBoardControls.Size = new System.Drawing.Size(228, 283);
            this.panelBoardControls.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "16",
            "32",
            "64"});
            this.comboBox1.Location = new System.Drawing.Point(107, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Luồng:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(58, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Tìm";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(107, 70);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 10;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(107, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 9;
            this.txtA.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số bắt đầu:";
            // 
            // panelBoardThread
            // 
            this.panelBoardThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBoardThread.Location = new System.Drawing.Point(230, 0);
            this.panelBoardThread.Name = "panelBoardThread";
            this.panelBoardThread.Size = new System.Drawing.Size(374, 283);
            this.panelBoardThread.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 283);
            this.Controls.Add(this.panelBoardControls);
            this.Controls.Add(this.panelBoardThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBoardControls.ResumeLayout(false);
            this.panelBoardControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoardControls;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBoardThread;
        private System.Windows.Forms.Timer timer1;
    }
}

