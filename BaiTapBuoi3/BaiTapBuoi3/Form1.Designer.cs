namespace BaiTapBuoi3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtRusult = new System.Windows.Forms.TextBox();
            this.panel_number = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(480, 30);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "0";
            // 
            // txtRusult
            // 
            this.txtRusult.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRusult.Location = new System.Drawing.Point(0, 30);
            this.txtRusult.Multiline = true;
            this.txtRusult.Name = "txtRusult";
            this.txtRusult.ReadOnly = true;
            this.txtRusult.Size = new System.Drawing.Size(480, 33);
            this.txtRusult.TabIndex = 2;
            this.txtRusult.Text = "0";
            this.txtRusult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel_number
            // 
            this.panel_number.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_number.Location = new System.Drawing.Point(0, 63);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(480, 271);
            this.panel_number.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(480, 334);
            this.Controls.Add(this.panel_number);
            this.Controls.Add(this.txtRusult);
            this.Controls.Add(this.txtText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Máy tính cơ bản";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtRusult;
        private System.Windows.Forms.Panel panel_number;
    }
}

