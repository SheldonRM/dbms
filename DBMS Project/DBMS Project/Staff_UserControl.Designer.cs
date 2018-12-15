namespace DBMS_Project
{
    partial class Staff_UserControl
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
            this.note3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // note3
            // 
            this.note3.AutoSize = true;
            this.note3.Location = new System.Drawing.Point(736, 434);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(110, 13);
            this.note3.TabIndex = 0;
            this.note3.Text = "show list of all doctors";
            // 
            // Staff_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.note3);
            this.Name = "Staff_UserControl";
            this.Size = new System.Drawing.Size(849, 456);
            this.Load += new System.EventHandler(this.Staff_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label note3;
    }
}
