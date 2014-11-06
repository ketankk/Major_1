using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        string user1;
        public Form2(string user)
        {
            InitializeComponent();
            label1.Text = "Hello "+user;
            user1 = user;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void title_OnClick(object sender, EventArgs e)
        {
            
        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (title.Text == ""||title.Text=="Title")
            {
                MessageBox.Show("Please Enter the Title of Message");
            }
            else
            if (message.Text == "" || message.Text == "Type your message here")
            {
                MessageBox.Show("Enter Message");
            }
            else
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Plea select Year");
                }
                else
                {
                    string tag = "login";
                    string content = "title=" + title.Text + "&message=" + message.Text + "&year=" + comboBox1.Text;

                    string URL = "http://localhost/pro/note/index.php";
                    string URI = "http://k3k.bugs3.com/note/index.php";

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
                    request.Method = "POST";
                    byte[] byteArray = Encoding.UTF8.GetBytes(content);
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = byteArray.Length;
                    Stream dataStream = request.GetRequestStream();

                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                    WebResponse response = request.GetResponse();
                    dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd()).Split('<')[0];
                    


                    MessageBox.Show(responseFromServer);
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void title_MouseClick(object sender, MouseEventArgs e)
        {
            title.Text = "";
            title.ForeColor = Color.Black;
        }

       

        private void message_MouseClick(object sender, MouseEventArgs e)
        {
            message.Text = "";
            message.ForeColor = Color.Black;
        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }

       private void message_MouseEnter(object sender, EventArgs e)
        {
            
        }

       private void title_MouseEnter(object sender, EventArgs e)
       {
           message.Text = "";
           message.ForeColor = Color.Black;
       }

       private void button2_Click(object sender, EventArgs e)
       {
           string content = "user="+ user1;

           string URL = "http://localhost/pro/note/index2.php";
           string URI = "http://k3k.bugs3.com/note/index2.php";

           HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
           request.Method = "POST";
           byte[] byteArray = Encoding.UTF8.GetBytes(content);
           request.ContentType = "application/x-www-form-urlencoded";
           request.ContentLength = byteArray.Length;
           Stream dataStream = request.GetRequestStream();

           dataStream.Write(byteArray, 0, byteArray.Length);
           dataStream.Close();
           WebResponse response = request.GetResponse();
           dataStream = response.GetResponseStream();
           StreamReader reader = new StreamReader(dataStream);
           string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd()).Split('<')[0];



           MessageBox.Show(responseFromServer);
       }
        
    }
}
