namespace TaskManagerProcess
{
    partial class UserControlProcess
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconProcess = new System.Windows.Forms.PictureBox();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // iconProcess
            // 
            this.iconProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconProcess.Location = new System.Drawing.Point(0, 0);
            this.iconProcess.Name = "iconProcess";
            this.iconProcess.Size = new System.Drawing.Size(100, 110);
            this.iconProcess.TabIndex = 2;
            this.iconProcess.TabStop = false;
            // 
            // txtProcessName
            // 
            this.txtProcessName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcessName.Location = new System.Drawing.Point(100, 0);
            this.txtProcessName.Multiline = true;
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(193, 110);
            this.txtProcessName.TabIndex = 3;
            // 
            // UserControlProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.iconProcess);
            this.Name = "UserControlProcess";
            this.Size = new System.Drawing.Size(293, 110);
            ((System.ComponentModel.ISupportInitialize)(this.iconProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconProcess;
        private System.Windows.Forms.TextBox txtProcessName;
    }
}
