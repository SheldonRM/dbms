using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_Project
{
    public partial class Patients_UserControl : UserControl
    {
        private static Patients_UserControl _instance;
        public static Patients_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Patients_UserControl();
                }
                return _instance;
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");



        public Patients_UserControl()
        {
            InitializeComponent();
        }

        private void Patients_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }


        public void refresh_DataGridView()
        {
            try             //general errors
            {
                SqlCommand cmd = new SqlCommand("ShowAllPatients_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try             //sql errors
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("              <<<INVALID SQL OPERATION...:\n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void AddNew_Button_Click(object sender, EventArgs e)       
        {
            SqlCommand cmd = new SqlCommand("PatientAdd_SP", con);    
            cmd.CommandType = CommandType.StoredProcedure;

            //textbox gives value to @pat_id which givesvalue to database Pat_id
            cmd.Parameters.AddWithValue("@Pat_id", PatientID_textBox.Text);      //takes value of pat_id textbox
            cmd.Parameters.AddWithValue("@PName", Name_textBox.Text);
            cmd.Parameters.AddWithValue("@PAddress", Address_textBox.Text);
            cmd.Parameters.AddWithValue("@PDiagnosis", Diagnosis_textBox.Text);
            cmd.Parameters.AddWithValue("@Record_id", RecordID_textBox.Text);
            cmd.Parameters.AddWithValue("@Hosp_id", HospitalID_textBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("              <<<INVALID SQL OPERATION...:\n" + ex);
            }
            con.Close();

            refresh_DataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchPatient_Button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
