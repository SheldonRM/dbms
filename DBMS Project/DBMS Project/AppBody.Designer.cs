namespace DBMS_Project
{
    partial class AppBody
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
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.MedicalRecordsButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SlidingPanel.Controls.Add(this.LogOutButton);
            this.SlidingPanel.Controls.Add(this.AboutButton);
            this.SlidingPanel.Controls.Add(this.SettingsButton);
            this.SlidingPanel.Controls.Add(this.StaffButton);
            this.SlidingPanel.Controls.Add(this.MedicalRecordsButton);
            this.SlidingPanel.Controls.Add(this.PatientsButton);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(849, 53);
            this.SlidingPanel.TabIndex = 0;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LogOutButton.Location = new System.Drawing.Point(766, -10);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(83, 65);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AboutButton.Location = new System.Drawing.Point(613, -10);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(157, 65);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SettingsButton.Location = new System.Drawing.Point(468, -10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(148, 65);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StaffButton
            // 
            this.StaffButton.BackColor = System.Drawing.Color.Transparent;
            this.StaffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffButton.ForeColor = System.Drawing.SystemColors.Window;
            this.StaffButton.Location = new System.Drawing.Point(265, -9);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(131, 65);
            this.StaffButton.TabIndex = 6;
            this.StaffButton.Text = "Staff";
            this.StaffButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StaffButton.UseVisualStyleBackColor = false;
            this.StaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // MedicalRecordsButton
            // 
            this.MedicalRecordsButton.BackColor = System.Drawing.Color.Transparent;
            this.MedicalRecordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicalRecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedicalRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalRecordsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.MedicalRecordsButton.Location = new System.Drawing.Point(128, -10);
            this.MedicalRecordsButton.Name = "MedicalRecordsButton";
            this.MedicalRecordsButton.Size = new System.Drawing.Size(140, 65);
            this.MedicalRecordsButton.TabIndex = 5;
            this.MedicalRecordsButton.Text = "Records";
            this.MedicalRecordsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MedicalRecordsButton.UseVisualStyleBackColor = false;
            this.MedicalRecordsButton.Click += new System.EventHandler(this.MedicalRecordsButton_Click);
            // 
            // PatientsButton
            // 
            this.PatientsButton.BackColor = System.Drawing.Color.Transparent;
            this.PatientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.PatientsButton.Location = new System.Drawing.Point(0, -9);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Size = new System.Drawing.Size(131, 65);
            this.PatientsButton.TabIndex = 4;
            this.PatientsButton.Text = "Patients";
            this.PatientsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PatientsButton.UseVisualStyleBackColor = false;
            this.PatientsButton.Click += new System.EventHandler(this.PatientsButton_Click);
            // 
            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel_ToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(386, -9);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(85, 65);
            this.SlidingPanel_ToggleButton.TabIndex = 1;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(0, 51);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(849, 456);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // AppBody
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 506);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.HelpButton = true;
            this.Name = "AppBody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Button MedicalRecordsButton;
        private System.Windows.Forms.Button PatientsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}