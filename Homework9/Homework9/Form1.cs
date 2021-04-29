using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        private SimpleCrawler myCrawler = new SimpleCrawler();
        public string strURL { get; set; }
        public string display { get; set; }
        public Form1()
        {
            strURL = "https://www.baidu.com/?tn=44048691_1_oem_dg";
            InitializeComponent();
            textBoxURL.DataBindings.Add("Text", this, "strURL");
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
          /*  textBoxCrawel.DataBindings.Clear();
            textBoxCrawel.DataBindings.Add("Text", this.myCrawler, "strDisplay");*/
            display = myCrawler.Begin(strURL);
            MessageBox.Show(myCrawler.newDisplay);
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // textBoxURL.DataBindings.Add("Text", this, "strURL");
           // textBoxCrawel.DataBindings.Add("Text", this.myCrawler, "strDisplay");
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            /*  textBoxCrawel.DataBindings.Clear();
              textBoxCrawel.DataBindings.Add("Text", this.myCrawler, "newDisplay");*/
            textBoxCrawel.Text = display;
            MessageBox.Show(myCrawler.newDisplay.Length.ToString());
        }

        private void textBoxCrawel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
