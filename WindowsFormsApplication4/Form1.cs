using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.Text = "Faculty Login";

        }

        private void login_Click(object sender, EventArgs e)
        {

            string tag = "login";
            string content = "tag=" + tag + "&email=" + email1.Text + "&password=" + pass.Text;

            string URI = "http://dcetech.com/sagnik/vnb/desktop/login.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(content);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = null;
            try
            {
                dataStream = request.GetRequestStream();
            }
            catch (WebException w)
            {
                MessageBox.Show("Could not connect to the internet! Please check your internet connection.");
                return;
            }

            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException w)
            {
                MessageBox.Show("Server is down! Please try again later" + w);
                
                return;
            }
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd()).Split('<')[0];

            //MessageBox.Show(responseFromServer);
            if (responseFromServer == "#false"||responseFromServer=="")
            {
                //MessageBox.Show("Either Email or Password is wrong");
                pass.Clear();
                label1.Text = "**Incorrect email or password";

            }



            /*
             loading dashboard after successfull login
             */
            else
            {
                string name5 = responseFromServer;

               // MessageBox.Show("Login Successfull " + name5);
                Form2 form = new Form2(name5);
                form.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            reader.Close();
            dataStream.Close();
            response.Close();

        }
    }
}
