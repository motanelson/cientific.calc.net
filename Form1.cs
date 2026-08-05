using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cientific.calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.DocumentText = 

            webBrowser1.Document.Write("<input type=\"text\" id=\"fname\" ><br><br><p id=\"p1\"><p><br><br><button \"type = \"button\" onclick = \'var fname = document.getElementById(\"fname\").value;document.getElementById(\"p1\").innerHTML =eval(fname)\' > calc! </button >");
            webBrowser1.Visible = true;
        }

        private void refressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
