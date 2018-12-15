namespace DBMS_Project
{
    partial class Patients_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.note1 = new System.Windows.Forms.Label();
            this.PatientID_Label = new System.Windows.Forms.Label();
            this.PatientID_textBox = new System.Windows.Forms.TextBox();
            this.SearchPatient_Button = new System.Windows.Forms.Button();
            this.databaseDataSet = new DBMS_Project.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_Label = new System.Windows.Forms.Label();
            this.RecordID_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Diagnosis_Label = new System.Windows.Forms.Label();
            this.HospitalID_Label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Diagnosis_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.RecordID_textBox = new System.Windows.Forms.TextBox();
            this.HospitalID_textBox = new System.Windows.Forms.TextBox();
            this.AddNew_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Location = new System.Drawing.Point(301, 433);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(213, 13);
            this.note1.TabIndex = 0;
            this.note1.Text = "add patients and assign doctors and reports";
            // 
            // PatientID_Label
            // 
            this.PatientID_Label.AutoSize = true;
            this.PatientID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PatientID_Label.Location = new System.Drawing.Point(39, 33);
            this.PatientID_Label.Name = "PatientID_Label";
            this.PatientID_Label.Size = new System.Drawing.Size(74, 15);
            this.PatientID_Label.TabIndex = 1;
            this.PatientID_Label.Text = "Patient ID:";
            // 
            // PatientID_textBox
            // 
            this.PatientID_textBox.Location = new System.Drawing.Point(119, 32);
            this.PatientID_textBox.Name = "PatientID_textBox";
            this.PatientID_textBox.Size = new System.Drawing.Size(153, 20);
            this.PatientID_textBox.TabIndex = 3;
            // 
            // SearchPatient_Button
            // 
            this.SearchPatient_Button.BackColor = System.Drawing.SystemColors.Window;
            this.SearchPatient_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPatient_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SearchPatient_Button.Location = new System.Drawing.Point(583, 44);
            this.SearchPatient_Button.Name = "SearchPatient_Button";
            this.SearchPatient_Button.Size = new System.Drawing.Size(95, 53);
            this.SearchPatient_Button.TabIndex = 4;
            this.SearchPatient_Button.Text = "SEARCH";
            this.SearchPatient_Button.UseVisualStyleBackColor = false;
            this.SearchPatient_Button.Click += new System.EventHandler(this.SearchPatient_Button_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 160);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name_Label.Location = new System.Drawing.Point(65, 99);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(49, 15);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Name:";
            // 
            // RecordID_Label
            // 
            this.RecordID_Label.AutoSize = true;
            this.RecordID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordID_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RecordID_Label.Location = new System.Drawing.Point(307, 95);
            this.RecordID_Label.Name = "RecordID_Label";
            this.RecordID_Label.Size = new System.Drawing.Size(76, 15);
            this.RecordID_Label.TabIndex = 7;
            this.RecordID_Label.Text = "Record-ID:";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Address_Label.Location = new System.Drawing.Point(52, 163);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(62, 15);
            this.Address_Label.TabIndex = 8;
            this.Address_Label.Text = "Address:";
            // 
            // Diagnosis_Label
            // 
            this.Diagnosis_Label.AutoSize = true;
            this.Diagnosis_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Diagnosis_Label.Location = new System.Drawing.Point(307, 33);
            this.Diagnosis_Label.Name = "Diagnosis_Label";
            this.Diagnosis_Label.Size = new System.Drawing.Size(75, 15);
            this.Diagnosis_Label.TabIndex = 9;
            this.Diagnosis_Label.Text = "Diagnosis:";
            // 
            // HospitalID_Label
            // 
            this.HospitalID_Label.AutoSize = true;
            this.HospitalID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalID_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HospitalID_Label.Location = new System.Drawing.Point(300, 158);
            this.HospitalID_Label.Name = "HospitalID_Label";
            this.HospitalID_Label.Size = new System.Drawing.Size(83, 15);
            this.HospitalID_Label.TabIndex = 10;
            this.HospitalID_Label.Text = "Hospital-ID:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(119, 93);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(153, 20);
            this.Name_textBox.TabIndex = 11;
            // 
            // Diagnosis_textBox
            // 
            this.Diagnosis_textBox.Location = new System.Drawing.Point(387, 33);
            this.Diagnosis_textBox.Name = "Diagnosis_textBox";
            this.Diagnosis_textBox.Size = new System.Drawing.Size(153, 20);
            this.Diagnosis_textBox.TabIndex = 12;
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(119, 157);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(153, 20);
            this.Address_textBox.TabIndex = 13;
            // 
            // RecordID_textBox
            // 
            this.RecordID_textBox.Location = new System.Drawing.Point(387, 94);
            this.RecordID_textBox.Name = "RecordID_textBox";
            this.RecordID_textBox.Size = new System.Drawing.Size(153, 20);
            this.RecordID_textBox.TabIndex = 14;
            // 
            // HospitalID_textBox
            // 
            this.HospitalID_textBox.Location = new System.Drawing.Point(387, 157);
            this.HospitalID_textBox.Name = "HospitalID_textBox";
            this.HospitalID_textBox.Size = new System.Drawing.Size(153, 20);
            this.HospitalID_textBox.TabIndex = 15;
            // 
            // AddNew_Button
            // 
            this.AddNew_Button.BackColor = System.Drawing.SystemColors.Window;
            this.AddNew_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNew_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddNew_Button.Location = new System.Drawing.Point(698, 42);
            this.AddNew_Button.Name = "AddNew_Button";
            this.AddNew_Button.Size = new System.Drawing.Size(95, 53);
            this.AddNew_Button.TabIndex = 16;
            this.AddNew_Button.Text = "ADD NEW";
            this.AddNew_Button.UseVisualStyleBackColor = false;
            this.AddNew_Button.Click += new System.EventHandler(this.AddNew_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Update_Button.Location = new System.Drawing.Point(698, 109);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(95, 53);
            this.Update_Button.TabIndex = 17;
            this.Update_Button.Text = "UPDATE";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Delete_Button.Location = new System.Drawing.Point(583, 109);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(95, 53);
            this.Delete_Button.TabIndex = 19;
            this.Delete_Button.Text = "DELETE";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Clear_Button.Location = new System.Drawing.Point(55, 192);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(91, 24);
            this.Clear_Button.TabIndex = 18;
            this.Clear_Button.Text = "CLEAR";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Patients_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.AddNew_Button);
            this.Controls.Add(this.HospitalID_textBox);
            this.Controls.Add(this.RecordID_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Diagnosis_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.HospitalID_Label);
            this.Controls.Add(this.Diagnosis_Label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.RecordID_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchPatient_Button);
            this.Controls.Add(this.PatientID_textBox);
            this.Controls.Add(this.PatientID_Label);
            this.Controls.Add(this.note1);
            this.Name = "Patients_UserControl";
            this.Size = new System.Drawing.Size(849, 456);
            this.Load += new System.EventHandler(this.Patients_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.Label PatientID_Label;
        private System.Windows.Forms.TextBox PatientID_textBox;
        private System.Windows.Forms.Button SearchPatient_Button;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label RecordID_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Diagnosis_Label;
        private System.Windows.Forms.Label HospitalID_Label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Diagnosis_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox RecordID_textBox;
        private System.Windows.Forms.TextBox HospitalID_textBox;
        private System.Windows.Forms.Button AddNew_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Clear_Button;
    }
}
