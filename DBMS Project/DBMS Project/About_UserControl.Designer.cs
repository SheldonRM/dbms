namespace DBMS_Project
{
    partial class About_UserControl
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
            this.AboutProject = new System.Windows.Forms.Label();
            this.AboutName = new System.Windows.Forms.Label();
            this.AboutName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutProject
            // 
            this.AboutProject.AutoSize = true;
            this.AboutProject.BackColor = System.Drawing.Color.Transparent;
            this.AboutProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProject.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AboutProject.Location = new System.Drawing.Point(137, 151);
            this.AboutProject.Name = "AboutProject";
            this.AboutProject.Size = new System.Drawing.Size(555, 37);
            this.AboutProject.TabIndex = 0;
            this.AboutProject.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // AboutName
            // 
            this.AboutName.AutoSize = true;
            this.AboutName.BackColor = System.Drawing.Color.Transparent;
            this.AboutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AboutName.Location = new System.Drawing.Point(436, 208);
            this.AboutName.Name = "AboutName";
            this.AboutName.Size = new System.Drawing.Size(256, 25);
            this.AboutName.TabIndex = 1;
            this.AboutName.Text = "by Sheldon Roy Mathews";
            // 
            // AboutName2
            // 
            this.AboutName2.AutoSize = true;
            this.AboutName2.BackColor = System.Drawing.Color.Transparent;
            this.AboutName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutName2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AboutName2.Location = new System.Drawing.Point(493, 233);
            this.AboutName2.Name = "AboutName2";
            this.AboutName2.Size = new System.Drawing.Size(199, 25);
            this.AboutName2.TabIndex = 2;
            this.AboutName2.Text = "Ruchi Purna Nanda";
            // 
            // About_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.AboutName2);
            this.Controls.Add(this.AboutName);
            this.Controls.Add(this.AboutProject);
            this.Name = "About_UserControl";
            this.Size = new System.Drawing.Size(849, 456);
            this.Load += new System.EventHandler(this.About_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutProject;
        private System.Windows.Forms.Label AboutName;
        private System.Windows.Forms.Label AboutName2;
    }
}
