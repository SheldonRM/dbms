namespace DBMS_Project
{
    partial class Records_UserControl
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
            this.note2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // note2
            // 
            this.note2.AutoSize = true;
            this.note2.Location = new System.Drawing.Point(680, 422);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(155, 13);
            this.note2.TabIndex = 0;
            this.note2.Text = "check records and modify them";
            // 
            // Records_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.note2);
            this.Name = "Records_UserControl";
            this.Size = new System.Drawing.Size(849, 456);
            this.Load += new System.EventHandler(this.Records_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label note2;
    }
}
