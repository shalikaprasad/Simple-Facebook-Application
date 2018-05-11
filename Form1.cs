using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class facebook : Form
    {
        public facebook()
        {
            InitializeComponent();
        }

        private void facebook_Load(object sender, EventArgs e)
        {

        }

        private void facebook_window_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                HtmlDocument doc = facebook_window.Document;
                HtmlElement username = doc.GetElementById("email");
                HtmlElement password = doc.GetElementById("pass");
                HtmlElement submit = doc.GetElementById("loginbutton");
                username.SetAttribute("value", "shalikaprasad38@gmail.com");
                password.SetAttribute("value", "Manchanayaka1995");
                submit.InvokeMember("click");
            }
            catch
            {

            }


        }
    }
}
