using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace HW9_CrawlWinform
{
    public partial class Win : Form
    {
        //爬虫程序
        SimpleCrawler simpleCrawler=new SimpleCrawler();
        public Win()
        {
            InitializeComponent();
        }

        private void Win_Load(object sender, EventArgs e)
        {
            //label1.DataBindings.Add("Text", simpleCrawler, "urls");//simpleCrawler.urls;
            //startUrlText.DataBindings.Add("Text", this.simpleCrawler, "startUrl");
            //statelabel.DataBindings.Add("Text", this.simpleCrawler, "state");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            simpleCrawler.startUrl = startUrlText.Text;
            new Thread(simpleCrawler.Crawl).Start();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void startUrlText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
