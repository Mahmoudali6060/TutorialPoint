using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Consumer
{
    public partial class Form1 : Form
    {
        Boolean isStart;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isStart = true;
            for (int i = 0; i < 10000000; i++)
            {
                if (isStart == false) break;
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            isStart = false;
        }
    }
}
