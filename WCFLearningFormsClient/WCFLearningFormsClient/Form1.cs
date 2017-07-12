using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFLearningFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserService.UserServiceClient client = new UserService.UserServiceClient();

            string user = textBox1.Text;

            bool loggedIn = client.Login(user);

            string loginText = "Login Failed";

            if (loggedIn)
            {
                loginText = "Login Successful";

                button2.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                button2.Visible = false;
                textBox2.Visible = false;
            }

            MessageBox.Show(loginText);


            client.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserService.UserServiceClient client = new UserService.UserServiceClient();

            List<string> users = client.GetUsers().ToList();
            textBox2.Text = "";
            foreach (string s in users)
            {
                textBox2.AppendText(s);
                textBox2.AppendText(Environment.NewLine);
               
            }


            ThreadService.ThreadServiceClient threadClient = new ThreadService.ThreadServiceClient();

            List<string> threads = threadClient.GetThreads().ToList();
            foreach (string s in threads)
            {
                textBox2.AppendText(s);
                textBox2.AppendText(Environment.NewLine);

            }

            threadClient.Close();
            client.Close();
        }
    }
}
