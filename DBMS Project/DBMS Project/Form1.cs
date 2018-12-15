using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sqlconnection connects this to the tables
        //backslashes are used to remove escame sequences
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True"); 
        SqlCommand cmd;     
        SqlDataReader dr;   //to read data from 


        private String getUserName()
        {
            //fetch data from the tables
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();  //values are stored as 2d array
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }


        private String getPassword()
        {
            //fetch data from the tables
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();  //values are stored as 2d array
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = getUserName(), upass = getPassword(), name, pass;
            name = textBox1.Text.ToLower();
            pass = textBox2.Text.ToLower();
            if(name.Equals(uname) && pass.Equals(upass))
            {
                //log in
                label4.Hide();

                AppBody obj = new AppBody();    //object of new form
                this.Hide();
                obj.Show();
            }
            else
            {
                //log in fail
                label4.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
