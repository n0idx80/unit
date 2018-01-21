// SDEV_460 Login application
// Michael Harrison 2017 Nov
// Used VS C# Windows Form Template and made modifications
// To Do: Apply try/except for file IO; Apply better closing functions; Refactor all textbox, label, and generic variable names


using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SDEV460_login
{
    public partial class Form1 : Form
    {
        public object DelayFactory { get; private set; }

        public Form1()
        {   //Init main form
            InitializeComponent();

            String path = @"c:\\temp\\test_log.txt"; //Set path for initial log file creation
            String log_init = "Log file created at " + DateTime.Now + Environment.NewLine; //Set text for initial log file
            File.WriteAllText(path, log_init); //Write to log file 
        }
        
        //Login button events
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "password") //Test usernamee and password against hardcoded creds
            {
                this.Hide(); //hide old main
                Main login = new SDEV460_login.Main(); //new instance of main
                login.Show(); //show login form

                //Log successful login
                String path = @"c:\\temp\\test_log.txt";
                File.AppendAllText(path, Environment.NewLine); //Print newline
                String user = "Successful Login Attempt from user: " + textBox1.Text + " with password: " + textBox2.Text + " at " + DateTime.Now + Environment.NewLine;
                File.AppendAllText(path, user);

            } else
                {
                    label3.Text = "Incorrect username or password";

                    //Log unsuccessful login
                    String path = @"c:\\temp\\test_log.txt";
                    File.AppendAllText(path, Environment.NewLine); //Print newline
                    String user = "Invalid Login Attempt from user: " + textBox1.Text + " with password: " + textBox2.Text + " at " + DateTime.Now + Environment.NewLine;
                    File.AppendAllText(path, user);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Clear all fields Button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
}
