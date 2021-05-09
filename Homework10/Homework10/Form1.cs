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
        SimpleCrawler myCrawler = new SimpleCrawler();
       
        public string strURL { get; set; }
        public string display { get; set; }
        //myCrawler.refreshTxt = func;
        public Form1()
        {
           // strURL = "https://www.baidu.com/?tn=44048691_1_oem_dg";
            InitializeComponent();
           // strURL ="http://www.baidu.com";
            textBoxURL.DataBindings.Add("Text", this, "strURL");
            myCrawler.refreshTxt += func;
            //myCrawler.d1 = new downloading(this.func);
          //  listBox1.DataSource = myCrawler.bs;
        }
        public void func() {
            if (listBox1.InvokeRequired)
            {
                Action myaction = new Action(()=>listBox1.Items.Add(myCrawler.item.Last()));
                this.Invoke(myaction,null);
            }
            else
                listBox1.Text += myCrawler.item.Last();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            /*  textBoxCrawel.DataBindings.Clear();
              textBoxCrawel.DataBindings.Add("Text", thi()=>s.myCrawler, "strDisplay");*/
            //new Thread(()=>myCrawler.Begin(strURL)).Start();
            myCrawler.urls.Add(strURL, false);//加入初始页面
            Thread myThread1 = new Thread(myCrawler.Crawl);
            //Thread myThread2 = new Thread(myCrawler.Crawl);
            myThread1.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // textBoxURL.DataBindings.Add("Text", this, "strURL");
           // textBoxCrawel.DataBindings.Add("Text", this.myCrawler, "strDisplay");
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            
           // bs.ResetBindings(false);
            
        }

        private void textBoxCrawel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
