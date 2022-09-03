using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kali_Tools_for_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            couttextbox.AppendText("正在启动KaliTools for Windows\n");
            couttextbox.AppendText("正在获取下载地址...\n");
            couttextbox.AppendText("加载完毕 软件 by adnogpu\n");
        }
    }
}
